using System;
using System.Collections.Generic;
using System.Text;

namespace OgretimÜyeleriProjesi
{

   public class OgretimElemani
    {      //Property - Özellikleri

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyeti { get; set; }


        public OgretimElemani()
        {
            

        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyeti)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyeti = cinsiyeti;
        }

        public override string ToString()
        {
            return $" {SicilNo,-5} " +
                $"{Adi,-10}" +
                $"{Soyadi, - 10}" +
               string.Format("{0,-8}", Cinsiyeti == true ? "Bay" : "Bayan");
             


                    

        }
    }
         
         


    
}
