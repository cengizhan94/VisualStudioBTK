using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrennciuygulaması
{
    class ogrenci
    {  //<Tanımlama
        private int ogrno;
        private string Adi;
        private string soyAdi;
        private int vize1;
        private int vize2;
        private int final;
        private string okuladi;

        public ogrenci(int _ogrno, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okul)//<Atama Yaptım
        {
            ogrno = _ogrno;
            Adi = _isim;
            soyAdi = _soyisim;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okuladi = _okul;

        }




        public void ogrencibilgilerigoster() //<Yazdırma
        {
            Console.WriteLine("Öğrenci Numarası: " + ogrno);
            Console.WriteLine("Öğrencinin Adı: " + Adi);
            Console.WriteLine("Öğrencinin Soyadı: " + soyAdi);
            Console.WriteLine("Öğrenci Vize1 Notu" + vize1);
            Console.WriteLine("Öğrenci Vize2 Notu" + vize2);
            Console.WriteLine("Öğrenci Final Notu" + final);
            Console.WriteLine("Öğrenci Okul Adı" + okuladi);

        }

        public double ogrencinotubul() //< Ortalama hesaplama
        {
            double ogrenciortalama = (vize1 * 0.2 + vize2 * 0.2 + final * 0.6);
            
            return ogrenciortalama;
        }

        public void okulgetir()
        {
            Console.WriteLine("Öğrencinin Okul İsmi: " + okuladi);
        }

    }
}
