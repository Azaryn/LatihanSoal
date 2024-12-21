using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoalSatu
{ 
    internal class Program 
    {
        static void Main(string[] args)
        {
            Mahasiswa pRafi = new Mahasiswa("Rafi Hadianto", "Laki-laki", "Jember", 2006);
            Sepeda kRafi = new Sepeda("Yamaha", 2022, "Fazzio");
            Console.WriteLine("MAHASISWA FASILKOM");
            pRafi.TampilkanInfo();
            Console.WriteLine(kRafi.info());
            Console.WriteLine(kRafi.mesin());

            Console.WriteLine(" ");

            Dosen pTunggul = new Dosen("Tunggul Abdul", "Laki-laki", "Banyuwangi", 2058);
            Sedan kTunggul = new Sedan("BMW", 2024, "Z4 Roaster");
            Console.WriteLine("DOSEN FASILKOM");
            pTunggul.TampilkanInfo();
            Console.WriteLine(kTunggul.info());
            Console.WriteLine(kTunggul.mesin());

            Console.WriteLine(" ");

            Tendik pLubia = new Tendik("Lubia Fahri", "Laki laki", "Madiun", 2090);
            Truk kLubia = new Truk("Pikap", 2025, "Suzuki New Carry");
            Console.WriteLine("Tendik FASILKOM");
            pLubia.TampilkanInfo();
            Console.WriteLine(kLubia.info());
            Console.WriteLine(kLubia.mesin());

            Console.ReadLine();

        }
    }
    public class Person //class
    {
        public string Nama;
        public string JenisKelamin;
        public string Alamat;

        public Person(string nama, string jenisKelamin, string alamat)
        {
            Nama = nama;
            JenisKelamin = jenisKelamin;
            Alamat = alamat;
        }

    }
    public class Mahasiswa : Person //subclass
    {
        public int NIM;

        public Mahasiswa(string nama, string jenisKelamin, string alamat, int nim)
            : base(nama,jenisKelamin,alamat)
        {
            NIM = nim;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Jenis Kelamin: {JenisKelamin}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"NIM: {NIM}");
        }
    }
    public class Dosen : Person //subclass
    {
        public int NID;

        public Dosen(string nama, string jenisKelamin, string alamat, int nid)
            : base(nama, jenisKelamin, alamat)
        {
            NID = nid;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Jenis Kelamin: {JenisKelamin}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"NID: {NID}");
        }
    }
    public class Tendik : Person //subclass
    {
        public int NIA;

        public Tendik(string nama, string jenisKelamin, string alamat, int nia) 
            : base(nama, jenisKelamin, alamat)
        {
            NIA = nia;
        }
        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Jenis Kelamin: {JenisKelamin}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"NIA: {NIA}");
        }
    }

    public class Kendaraan //class
    {
        public string JenisKendaraan;
        public int Tahun;

        public Kendaraan(string jenisKendaraan, int tahun)
        {
            JenisKendaraan = jenisKendaraan;
            Tahun = tahun;
        }
        public virtual string info()
        {
            return $"Kendaraan: {JenisKendaraan}\nTahun:{Tahun}";
        }
        public virtual string mesin()
        {
            return "kapasitas mesin ini standar";
        }

    }
    public class Sedan : Kendaraan //subclass
    {
        public string Series;
        public Sedan(string jenisKendaraan, int tahun, string series) 
            : base(jenisKendaraan, tahun)
        {
            Series = series;
        }
        public override string info()
        {
            return $"Kendaraan: {JenisKendaraan}\nTahun: {Tahun}\nSeries: {Series}";
        }
        public override string mesin()
        {
            return "Kapasitas mesin mobil sekitar 50–1500 cc";
        }
    }
    public class Truk : Kendaraan //subclass
    {
        public string Series;
        public Truk(string jenisKendaraan, int tahun, string series) 
            : base(jenisKendaraan, tahun)
        {
            Series = series;
        }
        public override string info()
        {
            return $"Kendaraan: {JenisKendaraan}\nTahun: {Tahun}\nSeries: {Series}";
        }
        public override string mesin()
        {
            return "Kapasitas mesin Truk sekitar 3.908-7.790cc";
        }
    }
    public class Sepeda : Kendaraan //subclass
    {
        public string Series;
        public Sepeda(string jenisKendaraan, int tahun, string series)
            : base(jenisKendaraan, tahun)
        {
            Series = series;
        }
        public override string info()
        {
            return $"Kendaraan: {JenisKendaraan}\nTahun: {Tahun}\nSeries: {Series}";
        }
        public override string mesin()
        {
            return "Kapasitas mesin ini 100-600cc";
        }
    }
}
