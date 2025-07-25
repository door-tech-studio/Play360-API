using Microsoft.IdentityModel.Tokens;
using play_360.Services.Abstration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace play_360.Services.Concrete
{
    public class JWTService : IJWTService
    {
        private IConfiguration _Configuration;
        public JWTService(IConfiguration Configuration) 
        {
            _Configuration = Configuration;
        }
        public string GenerateToken(string UserName)
        {
            var tokenHandler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(JwtRegisteredClaimNames.Sub, UserName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_Configuration["Jwt:TokenExpirationMinutes"])),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
