using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PayFast;
using PayFast.AspNetCore;
using play_360.DTOs;
using play_360.EF.Models;
using play_360.Services.Abstration.BusinessLogic;

namespace play_360.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly PayFastSettings _PayFastSettings;
        private readonly ICreditBusinessLogicService _CreditBusinessLogicService;
        private readonly IUserBusinessLogicService _UserBusinessLogicService;
        public PaymentController(
            PayFastSettings PayFastSettings, 
            ICreditBusinessLogicService CreditBusinessLogicService,
            IUserBusinessLogicService UserBusinessLogicService
        ) 
        {
            _PayFastSettings = PayFastSettings;
            _CreditBusinessLogicService = CreditBusinessLogicService;
            _UserBusinessLogicService = UserBusinessLogicService;
        }

        [HttpPost]
        [Route("InitiatePayment")]
        public ActionResult InitiatePayment(PaymentInitializerDTO paymentInitializerDTO)
        {
            var payFastRequest = new PayFastRequest(_PayFastSettings.PassPhrase)
            {
                merchant_id = _PayFastSettings.MerchantId,
                merchant_key = _PayFastSettings.MerchantKey,
                return_url = "https://yourdomain.com/payment/return",
                cancel_url = "https://yourdomain.com/payment/cancel",
                notify_url = "https://yourdomain.com/payment/notify",
                amount = paymentInitializerDTO.Amount * 100, // Payfast requires all amounts to be in cents.
                item_name = paymentInitializerDTO.ProductName,
                email_address = paymentInitializerDTO.UserEmail,
                email_confirmation = true
            };

            var redirectUrl = payFastRequest.ToString();
            return Redirect(redirectUrl);
        }

        [HttpPost]
        [Route("Notify")]
        public async Task<IActionResult> Notify([ModelBinder(BinderType = typeof(PayFastNotifyModelBinder))] PayFastNotify payFastNotify)
        {
            var payfastValidator = new PayFastValidator(this._PayFastSettings, payFastNotify, this.HttpContext.Connection.RemoteIpAddress);

            payFastNotify.SetPassPhrase(this._PayFastSettings.PassPhrase);

            var calculatedSignature = payFastNotify.GetCalculatedSignature();

            var isValid = payFastNotify.signature == calculatedSignature;

            if (isValid)
            {
                var user = await _UserBusinessLogicService.GetUserByEmail(payFastNotify.email_address);

                var credit = new Credit() {
                    Amount = int.Parse(payFastNotify.amount_gross),
                    UserId = user.Id,
                    CreditTypeId = 1,
                    CreatedAt = DateTime.UtcNow
                };

                var isCreditAdded = await _CreditBusinessLogicService.AddCredit(credit);
            }


            //var payfastValidator = new PayFastValidator(this._PayFastSettings, payFastNotify, this.HttpContext.Connection.RemoteIpAddress);

            //var merchantIdValidationResult = payfastValidator.ValidateMerchantId();

            //var ipAddressValidationResult = await payfastValidator.ValidateSourceIp();

            //if (payFastNotify.payment_status == PayFastStatics.CompletePaymentConfirmation)
            //{
            //    var dataValidationResult = await payfastValidator.ValidateData();

            //}

            //if (payFastNotify.payment_status == PayFastStatics.CancelledPaymentConfirmation)
            //{
                
            //}

            // PayFast expects a 200 OK response
            return Ok();
        }
    }
}
