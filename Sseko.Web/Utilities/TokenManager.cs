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
        public static string GenerateTokenAsync(User user, User userToImpersonate = null)
        {
            var symmetricKey = GetSecurityKey();
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity();
            if (userToImpersonate != null)
            {
                claims.AddClaim(new Claim(ClaimTypes.Name, userToImpersonate.UserName));
                claims.AddClaim(new Claim("uId", userToImpersonate.Id));
                claims.AddClaim(new Claim("mId", userToImpersonate.MagentoAccountId.ToString()));
                claims.AddClaim(new Claim("role", userToImpersonate.Role));
                claims.AddClaim(new Claim("sec", userToImpersonate.SecurityStamp));
                claims.AddClaim(new Claim("imp", "true"));
                claims.AddClaim(new Claim("pId", user.Id));
            }
            else
            {
                claims.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
                claims.AddClaim(new Claim("uId", user.Id));
                claims.AddClaim(new Claim("mId", user.MagentoAccountId.ToString()));
                claims.AddClaim(new Claim("role", user.Role));
                claims.AddClaim(new Claim("sec", user.SecurityStamp));
                claims.AddClaim(new Claim("imp", "false"));
                claims.AddClaim(new Claim("pId", Guid.Empty.ToString()));
            }

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = now.AddHours(24),

                SigningCredentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256Signature)
            };

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
