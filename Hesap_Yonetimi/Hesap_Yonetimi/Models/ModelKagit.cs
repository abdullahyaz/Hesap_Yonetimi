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
        public Ebat M_Ebat { get; set; }
        public int M_Birim { get; set; }
        public double M_Gramaj { get; set; }
        public double M_Top { get; set; }

        public double KagitTopKontrol(int TabakaAdet)
        {
            return TabakaAdet;
        }

    }
}
