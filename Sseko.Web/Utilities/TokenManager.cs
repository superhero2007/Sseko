using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Web.Utilities
{
    public static class TokenManager
    {
        public static string GenerateTokenAsync(User user)
        {
            var expirationTime = TimeSpan.FromHours(16);

            var symmetricKey = GetSecurityKey();
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim("userId", user.Id),
                    new Claim("magentoId", user.MagentoAccountId.ToString()),
                    new Claim("role", user.Role), 
                }),
                Expires = now.AddMinutes(180),

                SigningCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

        internal static SymmetricSecurityKey GetSecurityKey()
        {
            var secret = "4fasdf43543ts45raef4asdf42rasdf4asdf4242";
            var symmetricKey = Convert.FromBase64String(secret);
            return new SymmetricSecurityKey(symmetricKey);
        }
    }
}
