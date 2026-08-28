using System;
using SistemKursus;
using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PraktikumClass
//{
//    public class Buku
//    {
//        public string judul;
//        public string penulis;
//        public int tahunTerbit;
//    }


namespace SistemKursus
{
    class peserta
    {
        public string nama;
        public int nomorPeserta;
        static int jumlahPeserta = 0;

        public peserta(string a, int b)
        {
            nama = a;
            nomorPeserta = b;

            jumlahPeserta++;
        }
        public static void tampilkanJumlahPeserta()
        {
            Console.WriteLine($"Jumlah peserta {jumlahPeserta}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        peserta peserta1 = new peserta("david", 67);
        peserta peserta2 = new peserta("andro", 666);
        peserta.tampilkanJumlahPeserta();

        //laundry laundry1 = new laundry(
        //    "ikan", 10, 1000);
        //laundry1.tampilkanData();
        //Buku buku1 = new Buku();

        //buku1.judul = "The Psychology Of Money";
        //buku1.penulis = "Nur Tunggul";
        //buku1.tahunTerbit = 2045;

        //Buku buku2 = new Buku();

        //buku2.judul = "Awal Mula Bencana Aceh";
        //buku2.penulis = "M Galang Ramadhan Tamiang";
        //buku2.tahunTerbit = 2004;

        //Console.WriteLine(buku1.judul);
        //Console.WriteLine(buku1.penulis);
        //Console.WriteLine(buku1.tahunTerbit);
        //Console.WriteLine("================================================");
        //Console.WriteLine(buku2.judul);
        //Console.WriteLine(buku2.penulis);
        //Console.WriteLine(buku2.tahun);
    }
}
//    class laundry
//    {
//        string namaPelanggan;
//        int beratCucian;
//        int HargaPerKg;
//        public laundry(string namaPelanggan, int beratCucian, int HargaPerKg)
//        {
//            this.namaPelanggan = namaPelanggan;
//            this.beratCucian = beratCucian;
//            this.HargaPerKg = HargaPerKg;
//        }

//        public int HitungTotal() {
//            return beratCucian * HargaPerKg;
//                }

//        public void tampilkanData()
//        {
//            Console.WriteLine($"Nama Pelanggan  : {namaPelanggan}");
//            Console.WriteLine($"berat cucian  : {beratCucian}");
//            Console.WriteLine($"harga perkg  : {HargaPerKg}");
//            Console.WriteLine($" total harga : {HitungTotal()}");

//        }

//    }
//}

