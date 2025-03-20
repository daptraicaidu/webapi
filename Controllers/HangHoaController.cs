using Microsoft.AspNetCore.Mvc;
using GoodsAPI2.Data;
using GoodsAPI2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace GoodsAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        private readonly GoodsDbContext _context;

        public HangHoaController(GoodsDbContext context)
        {
            _context = context;
        }

        // GET: api/HangHoa
        
        [HttpGet]
        //[AllowAnonymous]
        public async Task<ActionResult<IEnumerable<HangHoa>>> GetHangHoas()
        {
            return await _context.Goods.ToListAsync();
        }

        // GET: api/HangHoa/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<HangHoa>> GetHangHoa(string id)
        {
            var hangHoa = await _context.Goods.FindAsync(id);
            if (hangHoa == null) return NotFound();
            return hangHoa;
        }

        // POST: api/HangHoa
        [HttpPost]
        public async Task<ActionResult<HangHoa>> PostHangHoa(HangHoa hangHoa)
        {
            _context.Goods.Add(hangHoa);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHangHoa), new { id = hangHoa.MaHangHoa }, hangHoa);
        }

        // PUT: api/HangHoa/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHangHoa(string id, HangHoa hangHoa)
        {
            if (id != hangHoa.MaHangHoa) return BadRequest();

            _context.Entry(hangHoa).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/HangHoa/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHangHoa(string id)
        {
            var hangHoa = await _context.Goods.FindAsync(id);
            if (hangHoa == null) return NotFound();

            _context.Goods.Remove(hangHoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}/ghi-chu")]
        public async Task<IActionResult> UpdateGhiChu(string id, [FromBody] string ghiChu)
        {
            var hangHoa = await _context.Goods.FindAsync(id);
            if (hangHoa == null) return NotFound();

            hangHoa.GhiChu = ghiChu;
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
