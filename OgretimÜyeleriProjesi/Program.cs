using System;
using System.Collections.Generic;

namespace OgretimÜyeleriProjesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Liste1 = new List<OgretimElemani>()
           {
                new OgretimElemani(100, "Cengiz Han", "Uyar", true),
                new OgretimElemani(101, "Zeynep", "Uyar", false),
                new OgretimElemani(102, "Pervin", "Oflaz", false),
                new OgretimElemani(103, "Mustafa", "Kurnaz", true),
                new OgretimElemani(104, "Ertuğrul", "Gazi", true),
                new OgretimElemani(105, "Osman", "Gazi", false),    
            };
            Console.WriteLine("Liste 1");
            Liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var Liste2 = Liste1;
            Console.WriteLine("Liste 2");
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.ReadKey();
            

        }


    }
}
