//Bismillahirrahmanirrahim

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testler
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double Sabit = 10000;
            int M_Gramaj = 115;
            int M_Tabaka = 500;

            double TopAgirligi(int g, int y)
            {
                double TBkSonuc = g * y * M_Gramaj;
                double TPSonuc = TBkSonuc / Sabit;
                return TPSonuc * M_Tabaka;

            }

            Console.WriteLine(TopAgirligi(70, 100));
            Console.Read();
            
        }
    }
}
