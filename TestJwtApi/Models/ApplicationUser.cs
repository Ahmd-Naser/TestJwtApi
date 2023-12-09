using JWTRefreshTokenInDotNet6.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestJwtApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]

        public string LastName { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}