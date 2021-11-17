using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methots
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*string[] students = new string[10];
            students[0] = "Cengiz Han";
            students[1] = "Zeynep";
            students[2] = "Karlos";
            students[3] = "Ahmet";
            students[4] = "Ertuğrul";
            students[5] = "Adem"; ;
            students[6] = "Şükrü";
            students[7] = "Ali";
            students[8] = "Hakan";
            students[9] = "Hasan";
            string[] students2 = new[] { "Hüseyin", "Leyla", "Mecnun", "Garip", "Turgut", "Bamsı" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);

            }*/
            //Çok boyutlu diziler:
            string[,] regions = new string[5, 3] //<Türkiyenin 5 bölgesi var ve her bölge için 3 şehir
            {
                { "İstanbul","İzmit","Balıkesir"},
                 {"Ankara","Konya","Kırıkkale" },
                 { "Antalya","Adana","Mersin"},
                 { "Tokat","Rize","Trabzon"},
                 {"İzmir","Muğla","Manisa" }
                 
                 
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**************************");
            }
            

            
            Console.ReadLine();
            
        }
    }
}
