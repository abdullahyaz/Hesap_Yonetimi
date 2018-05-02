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
            int[] M_Gramaj = { 90, 115, 130, 135, 170, 200, 250, 300, 350, 400 };
            int[] M_Tabaka = { 500, 250, 100 };
            int M_Kirim = 4;
            int M_FormaSayfa;

            // Bir top kağıdın ağırlığı
            double TopAgirligi(int g, int y)
            {
                double TBkSonuc = g * y * M_Gramaj[1];
                double TPSonuc = TBkSonuc / Sabit;
                return TPSonuc * M_Tabaka[0];

            }

            // Bir Top kağıttan çıkan kitap sayısı
            double TopCikanKitap()
            {
                if (M_Kirim == 4)
                {
                    M_FormaSayfa = 32;
                    return M_Tabaka[0] / M_FormaSayfa;
                }
                else
                {
                    return 0;
                }
            }


            Console.WriteLine("Bir top kağıdın ağırlığı " + TopAgirligi(70, 100));
            Console.WriteLine("Bir Top kağıttan çıkan kitap sayısı "+TopCikanKitap());
            Console.Read();
            
        }
    }
}
