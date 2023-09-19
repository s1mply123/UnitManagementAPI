namespace UnitManagementAPI
{
    public class User : AuthIdentity
    {
        public string?  HoTen { get; set; }
        public int Tuoi { get; set; }
        public int GioiTinh { get; set; }
        public string Email { get; set; } = string.Empty;
        public int SoDienThoai { get; set; }
    }
}
