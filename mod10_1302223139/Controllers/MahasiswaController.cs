using Microsoft.AspNetCore.Mvc;

namespace mod10_1302223139.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private readonly MahasiswaSingleton _mahasiswaSingleton = MahasiswaSingleton.Instance;

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return _mahasiswaSingleton.ListMahasiswa;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= _mahasiswaSingleton.ListMahasiswa.Count)
            {
                return NotFound("Mahasiswa dengan ID tersebut tidak ditemukan.");
            }

            return Ok(_mahasiswaSingleton.ListMahasiswa[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            if (mahasiswa == null)
            {
                return BadRequest("Data mahasiswa tidak valid.");
            }

            _mahasiswaSingleton.ListMahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { id = _mahasiswaSingleton.ListMahasiswa.Count - 1 }, mahasiswa);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Mahasiswa mahasiswa)
        {
            if (id < 0 || id >= _mahasiswaSingleton.ListMahasiswa.Count)
            {
                return NotFound("Mahasiswa dengan ID tersebut tidak ditemukan.");
            }

            if (mahasiswa == null)
            {
                return BadRequest("Data mahasiswa tidak valid.");
            }

            _mahasiswaSingleton.ListMahasiswa[id] = mahasiswa;
            return Ok(mahasiswa);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= _mahasiswaSingleton.ListMahasiswa.Count)
            {
                return NotFound("Mahasiswa dengan ID tersebut tidak ditemukan.");
            }

            _mahasiswaSingleton.ListMahasiswa.RemoveAt(id);
            return NoContent();
        }
    }
}
