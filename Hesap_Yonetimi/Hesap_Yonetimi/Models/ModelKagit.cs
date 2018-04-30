//Bismillahirrahmanirrahim

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Yonetimi.Models
{
    public class ModelKagit
    {
        public int M_Tabaka { get; set; }
        public string M_KagitCinsi { get; set; }
        public double M_Sayfa { get; set; }
        public int M_Adet { get; set; }
        public int M_Birim { get; set; }
        public double M_Gramaj { get; set; }
        public double M_Top { get; set; }
        
        const double Sabit = 10000;

        public double KagitTopKontrol(int TabakaAdet)
        {
            return TabakaAdet;
        }

        double TopAgirligi(int g, int y)
            {
                double TBkSonuc = g * y * M_Gramaj;
                double TPSonuc = TBkSonuc / Sabit;
                return TPSonuc * M_Tabaka;

            }

    }
}
