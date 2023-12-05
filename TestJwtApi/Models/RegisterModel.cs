using System.ComponentModel.DataAnnotations;

namespace TestJwtApi.Models
{
    public class RegisterModel
    {
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }


        [StringLength(100)]
        public string Username { get; set; }


        [StringLength(100)]
        public string Email { get; set; }


        [StringLength(100)]
        public string Password { get; set; }
    }
}
