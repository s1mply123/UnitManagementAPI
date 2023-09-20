namespace UnitManagementAPI.DTOs
{
    public class UnitDTO
    {
        public Guid Id { get; set; }
        public string? TenDoanhNghiep { get; set; }
        public string? ChuDoanhNghiep { get; set; }
        public string? DiaChi { get; set; }
        public int? SoDienThoai { get; set; }
        public int? NamThanhLap { get; set; }
        public int? NamThamGia { get; set; }
    }
}
