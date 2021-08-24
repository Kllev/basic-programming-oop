using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramming
{
    class Harga
    {
        public int[] harga{get; set;}

        public Harga()
        {
            harga = new [] { 10000, 5000, 7000, 15000, 6000, 20000 };
        }

        public void Showing()
        {
            foreach (int i in harga)
            {
                Console.WriteLine($"{harga}");
            }
        }
    }
}
