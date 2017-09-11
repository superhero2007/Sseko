using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Web.Utilities
{
    public static class TokenManager
    {
        public static string GenerateTokenAsync(User user, string userToImpersonateId = "")
        {
            var symmetricKey = GetSecurityKey();
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim("uId", user.Id),
                    new Claim("mId", user.MagentoAccountId.ToString()),
                    new Claim("role", user.Role),
                    new Claim("sec", user.SecurityStamp),
                }),
                Expires = now.AddHours(24),

                SigningCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256Signature)
            };

            if (!string.IsNullOrWhiteSpace(userToImpersonateId))
            {
                tokenDescriptor.Subject.AddClaim(new Claim("imp", "true"));
                tokenDescriptor.Subject.AddClaim(new Claim("iId", userToImpersonateId));
            }

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

        internal static SymmetricSecurityKey GetSecurityKey()
        {
            var secret = "e58649662f976416c32996cf1ba61474146feb8792ba4c8d929adb650cde22fef93c5609ba15aa8cd66db4443c15bde0cbb27df1b99394b73cd297ce0c391681";
            var symmetricKey = Convert.FromBase64String(secret);
            return new SymmetricSecurityKey(symmetricKey);
        }

        internal static Token Decode(this string token)
        {
            var decoded = new JwtSecurityToken(token);

            return new Token
            {
                Username = decoded.Claims.FirstOrDefault(c => c.Type == "unique_name").Value,
                Id = decoded.Claims.FirstOrDefault(c => c.Type == "uId").Value,
                MagentoId = int.Parse(decoded.Claims.FirstOrDefault(c => c.Type == "mId").Value),
                Role = decoded.Claims.FirstOrDefault(c => c.Type == "role").Value,
                SecurityStamp = decoded.Claims.FirstOrDefault(c => c.Type == "sec").Value,
                IsImpersonating = decoded.Claims.FirstOrDefault(c => c.Type == "imp").Value
            };
        }
    }

    public class Token
    {
        public string Username { get; set; }
        public string Id { get; set; }
        public int MagentoId { get; set; }
        public string Role { get; set; }
        public string SecurityStamp { get; set; }
        public string IsImpersonating { get; set; }
    }
}
