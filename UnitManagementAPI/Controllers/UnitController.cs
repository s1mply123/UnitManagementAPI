using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitManagementAPI.Data;

namespace UnitManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly DataContext _context;

        public UnitController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Unit>>> GetUnits()
        {
            return Ok(await _context.Units.ToListAsync());
        }
        [HttpPost]
        public async Task<ActionResult<List<Unit>>> CreateUnit (Unit unit)
        {
            _context.Units.Add(unit);
            await _context.SaveChangesAsync();

            return Ok(await _context.Units.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Unit>>> UpdateUnit (Unit unit)
        {
            var dbUnit = await _context.Units.FindAsync(unit.Id);
            if(dbUnit == null)
            {
                return BadRequest("Unit not found.");
            }

            dbUnit.TenDoanhNghiep = unit.TenDoanhNghiep;
            dbUnit.ChuDoanhNghiep = unit.ChuDoanhNghiep;
            dbUnit.DiaChi = unit.DiaChi;
            dbUnit.SoDienThoai = unit.SoDienThoai;
            dbUnit.NamThanhLap = unit.NamThanhLap;
            dbUnit.NamThamGia = unit.NamThamGia;

            await _context.SaveChangesAsync();

            return Ok(await _context.Units.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Unit>>> DeleteUnit (int id)
        {
            var dbUnit = await _context.Units.FindAsync(id);
            if (dbUnit == null)
            {
                return BadRequest("Unit not found.");
            }

            _context.Units.Remove(dbUnit);
            await _context.SaveChangesAsync();

            return Ok(await _context.Units.ToListAsync());
        }
    }
}
