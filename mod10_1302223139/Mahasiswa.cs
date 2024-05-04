namespace mod10_1302223139
{
    public class Mahasiswa(string Nama, string NIM, List<String> Course, int Year)
    {
        public string Nama { get; set; } = Nama;
        public string NIM { get; set; } = NIM;
        public List<String> Course { get; set; } = Course;
        public int Year { get; set; } = Year;
    }
}
