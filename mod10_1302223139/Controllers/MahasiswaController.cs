using Microsoft.AspNetCore.Mvc;

namespace mod10_1302223139.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>()
            {
                new Mahasiswa(" Ihsan Maulana", "1302223139", new List<string> (){"Basis Data"}, 2024),
                new Mahasiswa(" Fachruddin Ghalibi", "1302223107", new List<string> (){"Konstruksi Perangkat Lunak"}, 2024),
                new Mahasiswa(" Muhammad Fadlan Kamal", "1302223095", new List<string>(){"Pemrograman Berbasis Objek"}, 2024)
            };
        [HttpGet]




        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
