namespace UnitManagementAPI
{
    public class Unit
    {
        public Guid Id { get; set; }
        public string? TenDoanhNghiep { get; set; }
        public string? ChuDoanhNghiep { get; set; }
        public string? DiaChi { get; set; }
        public int SoDienThoai { get; set; } = 0;
        public int NamThanhLap { get; set; } = 0;
        public int NamThamGia { get; set; } = 0;
    }
}
