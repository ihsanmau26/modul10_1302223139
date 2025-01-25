using System.Collections.Generic;

namespace mod10_1302223139
{
    public class MahasiswaSingleton
    {
        private static MahasiswaSingleton _instance;
        private static readonly object _lock = new object();

        // List mahasiswa sebagai data
        public List<Mahasiswa> ListMahasiswa { get; private set; }

        // Private constructor untuk mencegah instansiasi langsung
        private MahasiswaSingleton()
        {
            ListMahasiswa = new List<Mahasiswa>
            {
                new Mahasiswa("Ihsan Maulana", "1302223139", new List<string> { "Basis Data" }, 2024),
                new Mahasiswa("Fachruddin Ghalibi", "1302223107", new List<string> { "Konstruksi Perangkat Lunak" }, 2024),
                new Mahasiswa("Muhammad Fadlan Kamal", "1302223095", new List<string> { "Pemrograman Berbasis Objek" }, 2024)
            };
        }

        // Properti untuk mendapatkan instance singleton
        public static MahasiswaSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MahasiswaSingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
