using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Produk : Harga
    {
        public string[] makanan = new string[] { "Bakso\t", "Mie Rebus", "Mie Goreng", "Nasi Goreng", "Bakmi\t", "Promo Spesial\t" };
        public int i, k = 0;
        public void ShowData()
        {
            for (i = 0; i < makanan.Length; i++)
            {
                Console.WriteLine(++k + "\t" + makanan[i] + "\t" + "\t\t" + harga[i]);
            }
        }
     }
}
