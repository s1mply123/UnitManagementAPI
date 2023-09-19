namespace UnitManagementAPI
{
    public class AuthIdentity
    {
        public Guid Id { get; set; }
        public virtual string Username { get; set; } = string.Empty;
        public virtual byte[]? PasswordHash { get; set; }
        public virtual byte[]? PasswordSalt { get; set; }
        public virtual string RefreshToken { get; set; } = string.Empty;
        public virtual DateTime TokenCreated { get; set; } = DateTime.Today;
        public virtual DateTime TokenExpires { get; set; } = DateTime.Today;
    }
}
