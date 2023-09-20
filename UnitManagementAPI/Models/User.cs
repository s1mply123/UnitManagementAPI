namespace UnitManagementAPI.Models
{
    public class User : AuthIdentity
    {
        public Guid Id { get; set; }
        public string HoTen { get; set; } = string.Empty;
        public int? Tuoi { get; set; }
        public int? GioiTinh { get; set; }
        public string Email { get; set; } = string.Empty;
        public int? SoDienThoai { get; set; }
    }
}
