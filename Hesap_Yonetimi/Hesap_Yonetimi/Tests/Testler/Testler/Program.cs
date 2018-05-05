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
            int[] M_Gramaj = { 70, 80, 90, 100, 115, 120, 125, 130, 135, 170, 200, 250, 300, 350, 400 };
            int[] M_Tabaka = { 500, 250, 100, 1 };
            int M_IsEn = 157; //Giriş
            int M_IsBoy = 234; //Giriş
            int M_IsSayfa = 624; //Giriş
            int M_BaskiAdedi = 3000; //Giriş
            int M_TabakaEn = 68; //Giriş
            int M_TabakaBoy = 100; //Giriş
            int M_KacForma = 39; //prop olacak
            double M_TonFiyat = 5542.82; //Giriş Euro veya Dolar TL'ye çevir Euro kur 5,0388
            int M_Renk = 4; //Giriş
            double kalipSayisi = M_Renk * M_KacForma; //İşin kalıp sayısı
            int M_kalipFiyati = 90; // Giriş TL bazında kalıp fiyatı

        // Bir top kağıdın ağırlığı
        double TopAgirligi(int g, int y)
            {

                double TBkSonuc = g * y * M_Gramaj[0];
                double TPSonuc = TBkSonuc / Sabit;
                return TPSonuc * M_Tabaka[0];

            }

            // Bir Top kağıttan çıkan kitap sayısı
            double TopCikanKitap()
            {
                return M_Tabaka[0] / M_KacForma; //M_KacForma prop'tan gelecek
            }

            // Baskı için gereken tabaka sayısı
            double TabakaSayisi()
            {
                return M_BaskiAdedi * M_KacForma; //M_KacForma prop'tan gelecek

            }
            
            // Baskı yapılacak sayfa tabakaya uyuyormu
            int kagitOlcusuHesapla()
            {
                M_TabakaEn *= 10; // cm'yi mm'ye çeviriyoruz
                M_TabakaBoy *= 10; // cm'yi mm'ye çeviriyoruz
                M_IsEn += 6;
                M_IsBoy += 6;
                int tabakaOlcu = (M_TabakaEn -25) * (M_TabakaBoy -25); //-25 ile payları çıkarıyoruz
                int sayfaOlcu = M_IsEn * M_IsBoy;
                int forma = tabakaOlcu / sayfaOlcu;
                if (forma < 16)
                {
                    return 0;
                }
                else
                {
                    M_KacForma = M_IsSayfa / forma;
                    return M_KacForma;
                    
                }
            }

            // Kağıt ton fiyatına göre kağıt tutarını alıyoruz
            double kagitFiyati()
            {
                double tpAg = TopAgirligi(M_TabakaEn, M_TabakaBoy) /100; //100'e bölerek mm2 sonucu cm2 yapıyoruz
                double fiyat = tpAg * M_TonFiyat;
                return fiyat / 1000; // 1000 kg fiyatına bölerek 1 top kağıdın fiyatı alınıyor
            }

            // Kalıp fiyatına göre tutar alınıyor
            double kalipFiyat()
            {
                return M_kalipFiyati * kalipSayisi;
            }

            double baskiKagitFiyati()
            {
                double bFiyat = TabakaSayisi() / M_Tabaka[0];
                double tpFiyat = bFiyat * kagitFiyati();
                return tpFiyat / 1000; // TL cinsinden
            }

            // Baskı için gereken top miktarı
            double TopMiktari()
            {
                return TabakaSayisi() / M_Tabaka[0];
            }

            Console.WriteLine("Bir top kağıdın ağırlığı: " + TopAgirligi(M_TabakaEn, M_TabakaBoy) / 1000+ " kg"); //1000'e bölerek gr sonucu kg'a çeviriyoruz
            Console.WriteLine("Bir Top kağıttan çıkan kitap sayısı: "+TopCikanKitap());
            Console.WriteLine("Baskı için gereken tabaka sayısı: " + TabakaSayisi());
            Console.WriteLine("Baskı için gereken top sayısı: " + TopMiktari());
            Console.WriteLine("Kitabın Forma Sayısı: " + kagitOlcusuHesapla());
            Console.WriteLine("Bir top kağıdın fiyatı: " + kagitFiyati() / 1000+ " TL"); // TL cinsinden
            Console.WriteLine("Baskı rengine göre kalıp fiyatı: " + kalipFiyat() + " TL");
            Console.WriteLine("Toplam kağıt tutarı: " + baskiKagitFiyati() + "TL"); 
            Console.Read();
            
        }
    }
}
