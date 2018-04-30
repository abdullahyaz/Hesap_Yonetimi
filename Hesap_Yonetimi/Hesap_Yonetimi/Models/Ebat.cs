//Bismillahirrahmanirrahim

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Yonetimi.Models
{
    struct Ebat
    {
        public double m_Genislik { get; set; }
        public double m_Yukseklik { get; set; }

        public Ebat(double g, double y)
        {
            m_Genislik = g;
            m_Yukseklik = y;
        }
    }
}
