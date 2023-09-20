using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnitManagementAPI.Data;
using UnitManagementAPI.Models;

namespace UnitManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUser()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            var dbUser = await _context.Users.FindAsync(user.Id);
            if (dbUser == null)
            {
                return BadRequest("User not found.");
            }

            dbUser.HoTen = user.HoTen;
            dbUser.Tuoi = user.Tuoi;
            dbUser.GioiTinh = user.GioiTinh;
            dbUser.Email = user.Email;
            dbUser.SoDienThoai = user.SoDienThoai;

            await _context.SaveChangesAsync();

            return Ok(await _context.Users.ToListAsync());
        }
    }
}
