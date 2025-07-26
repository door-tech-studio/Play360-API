namespace play_360.DTOs
{
    public class PaymentInitializerDTO
    {
        public required string ProductName { get; set; }
        public int Amount { get; set; }
        public string UserEmail { get; set; }
    }
}
