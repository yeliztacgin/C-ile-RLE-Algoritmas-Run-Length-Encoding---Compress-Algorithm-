using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLE_Algoritmasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///run length alg//
            ///aaaaaabbbbbbbddddddddbbbbbbbbcccccccccc
            ////aaaacccggggt
            string veriKaynagi = "aaaacccggggt";
            int sayac = 1;


            for (int i = 0; i <veriKaynagi.Length-1; i++)
            {
                if (veriKaynagi[i] == veriKaynagi[i+1])
                {
                    sayac++;
                }
                else
                {
                    Console.WriteLine(sayac + veriKaynagi[i].ToString());
                    sayac = 1;
                }
            }

            Console.ReadLine();

        }
    }
}
