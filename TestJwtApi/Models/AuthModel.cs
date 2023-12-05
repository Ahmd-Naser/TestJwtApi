namespace TestJwtApi.Models
{
    public class AuthModel
    {
        public string ?Message { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool IsAutenticated { get; set; } = false;
        
        public List<string>Roles { get; set; }
        public string ?Token { get; set; }
        public DateTime ExpiresOn { get; set; }

    }
}
