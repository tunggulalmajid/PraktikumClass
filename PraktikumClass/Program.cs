using PraktikumClass.Contoh;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Console.WriteLine("Hello, World!");
//        ////String nama = Console.ReadLine();
//        ////Kholish Kholish = new Kholish();
//        //Orang Excel = new Orang();
//        //Orang.umur = 10;
//        ////Orang Diaz = new Orang(12);
//        //Excel.perbandinganUmur();
//        //Excel.umur = 10;

//        //Excel.umur = 12;
//        //Console.WriteLine(Excel.umur);
//        //Kholish.umur = 11;
//        //int umurKholish = 1;
//        //Excel.panggilKholish();

//        int angka1 = 10;
//        int angka2 = 6;
//        int hasil = Kalkulator.Tambah(angka1, angka2);
//        Console.WriteLine(hasil);

//    }
//}

class Orang
{
    public static int umur;
    //public Orang (int umur)
    //{
    //    panggilKholish();
    //}
    public void panggilKholish()
    {
        Console.WriteLine("Kholish kesinilah");
    }

    public int umurKholishplus()
    {
        return umur + 1;
    }

    public void perbandinganUmur()
    {
        Kholish kholishCuy = new Kholish();
        kholishCuy.umur = 10;
        Console.WriteLine($"Umurnya Kholish : {kholishCuy.umur}");
        umur = 12;
        Console.WriteLine($"umur orang : {umur}");
    }
}
    class Kholish
    {
        public int umur;

    }
