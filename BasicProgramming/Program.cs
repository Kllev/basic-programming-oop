using System;

namespace BasicProgramming
{
    class Program
    {
        static void HotPromo()
        {
            int sekarang;
            DateTime saatini = DateTime.Today;
            //Console.WriteLine("Today is " + saatini.ToString("dddd dd MMMM yyyy"));
            Console.WriteLine("Today is " + saatini.ToString("D"));
            //Console.WriteLine("Today is " + hariini.ToString("dddd"));
            //Console.WriteLine("Today is : " + (int)hariini.DayOfWeek);
            sekarang = (int)saatini.DayOfWeek;
            if (sekarang == 1)
            {
                Console.WriteLine("Promo makanan hari ini : Nasi Gila");
            }
            if (sekarang == 2)
            {
                Console.WriteLine("Promo makanan hari ini : Nasi Kebuli");
            }
            if (sekarang == 3)
            {
                Console.WriteLine("Promo makanan hari ini : Nasi Bakar");
            }
            if (sekarang == 4)
            {
                Console.WriteLine("Promo makanan hari ini : Nasi Kucing");
            }
            if (sekarang == 5)
            {
                Console.WriteLine("Promo makanan hari ini : Nasi Kuning");
            }
        }
        //static int[] harga = new int[] { 10000, 5000, 7000, 15000, 6000, 20000 };
        static void Main(string[] args)
        {
        Start:
            Produk produk = new Produk();
            Harga harga = new Harga();
            Console.Clear();
            int hasil, total,pesanan, input, j;
            Console.WriteLine("\t\t\t\tSistem Kantin\t\t\t\t");
            HotPromo();
            Console.WriteLine("\tDaftar Makanan");
            Console.WriteLine("No \tMakanan \t\t\tharga");
            produk.ShowData();
            //DaftarMakanan();
            Console.WriteLine("Berapa banyak makanan yang ingin dipesan ? ");
            hasil = 0;
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan makanan yang diinginkan : ");
            for (j = 0; j < input; j++)
            {
                try
                {
                    pesanan = Convert.ToInt32(Console.ReadLine());
                    pesanan = pesanan - 1;
                    hasil = hasil + harga.harga[pesanan];   
                }
                catch (Exception e)
                {
                   Console.WriteLine("error message : " + e.Message); 
                   goto Start;
                }
            }
           total = hasil - Diskon(hasil);
           Console.WriteLine($"Selamat anda mendapat diskon : {Diskon(hasil)}");
           Console.WriteLine($"Harga yang perlu dibayarkan adalah : {total}");
        }

        //static void DaftarMakanan()
        //{
        //    string[] makanan = new string[] { "Bakso\t", "Mie Rebus", "Mie Goreng", "Nasi Goreng", "Bakmi\t", "Promo Spesial\t"};
        //    int i, k = 0;
        //    for(i = 0; i < makanan.Length; i++)
        //    {
        //        k++;
        //        Console.WriteLine(k + "\t" + makanan[i]  + "\t" + "\t\t" + harga[i]);
        //    }
        //}
        static int Diskon(int angka)
        {
            if (angka > 20000 && angka < 30000)
            {
                return 5000;
            }
            if (angka > 30000)
            {
                return 10000;
            }
            return 0;
        }
    }
}