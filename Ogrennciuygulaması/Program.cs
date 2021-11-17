using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrennciuygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            ogrenci ogrenci1 = new ogrenci(1, "Cengiz Han", "Uyar", 50, 40, 73,  "Hakkari Üniversitesi");
            Console.WriteLine("Uygulamaya Hoşgeldin. Yapmak İstediğin İşlemi Seç: ");
            islemlerigoster();

            while (kontrol)
            {

                string secim = Console.ReadLine();


                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrencibilgilerigoster();
                        break;

                    case "2":
                        double ogrenciortalama = ogrenci1.ogrencinotubul();
                        Console.WriteLine("Öğrenci Ortalaması: "+ ogrenciortalama);
                        break;

                    case "3":
                        ogrenci1.okulgetir();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış Başarılı");
                        kontrol = false;
                        break;

                }
                

            }


        }

        static void islemlerigoster()
        {
            Console.WriteLine("1- Öğrenci Bilgilerini Gör: ");
            Console.WriteLine("2- Öğrenci Ortalamasını Gör: ");
            Console.WriteLine("3- Öğrenci Okulunu Gör: ");
            Console.WriteLine("4- Çıkış Yap!");

        }
    }
}
