using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SsekoWeb.Utilities
{
    public static class TokenManager
    {
        public static string GenerateTokenAsync()
        {
            var secret = "4fasdf43543ts45raef4asdf42rasdf4asdf4242";
            var expirationTime = TimeSpan.FromHours(16);

            var symmetricKey = Convert.FromBase64String(secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "sseko@mailinator.com"),
                    new Claim("userId", Guid.Empty.ToString()),
                    new Claim("role", "fellow")
                }),

                Expires = now.AddMinutes(180),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }
    }
}
