using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAA_LKM1.Data;
using PAA_LKM1.Models;

namespace PAA_LKM1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerawatanController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PerawatanController(AppDbContext context)
        {
            _context = context;
        }

        // =========================
        // GET ALL
        // =========================
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _context.Perawatan
                .Include(p => p.Pasien)
                .Include(p => p.Dokter)
                .ToListAsync();

            return Ok(new
            {
                status = "success",
                data = data
            });
        }

        // =========================
        // GET BY ID
        // =========================
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _context.Perawatan
                .Include(p => p.Pasien)
                .Include(p => p.Dokter)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (data == null)
            {
                return NotFound(new
                {
                    status = "error",
                    message = "Data tidak ditemukan"
                });
            }

            return Ok(new
            {
                status = "success",
                data = data
            });
        }

        // =========================
        // POST
        // =========================
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Perawatan perawatan)
        {
            _context.Perawatan.Add(perawatan);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                status = "success",
                data = perawatan
            });
        }

        // =========================
        // PUT
        // =========================
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Perawatan perawatan)
        {
            var data = await _context.Perawatan.FindAsync(id);

            if (data == null)
            {
                return NotFound(new
                {
                    status = "error",
                    message = "Data tidak ditemukan"
                });
            }

            data.Pasien_id = perawatan.Pasien_id;
            data.Dokter_id = perawatan.Dokter_id;
            data.Jenis_perawatan = perawatan.Jenis_perawatan;
            data.Harga = perawatan.Harga;
            data.Tanggal = perawatan.Tanggal;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                status = "success",
                data = data
            });
        }

        // =========================
        // DELETE
        // =========================
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _context.Perawatan.FindAsync(id);

            if (data == null)
            {
                return NotFound(new
                {
                    status = "error",
                    message = "Data tidak ditemukan"
                });
            }

            _context.Perawatan.Remove(data);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                status = "success",
                message = "Data berhasil dihapus"
            });
        }
    }
}