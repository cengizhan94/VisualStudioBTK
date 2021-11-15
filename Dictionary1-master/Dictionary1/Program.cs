using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332, "Konya"},
                {424, "Elazığ"},
                {466, "Artvin"}
            };

            //Ekleme
            telefonKodlari.Add(322,"Adana");
            telefonKodlari.Add(212, "Istanbul");
            telefonKodlari.Add(216, "Istanbul");
            telefonKodlari.Add(422, "Malatya");
            //Erişme
            telefonKodlari[466] = "Artvin";

            //ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\a Ankara'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni Kod Eklendi!");
            }

            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\a Malatya'nın kod bilgisi tanimli değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni Kod eklendi");
            }

            telefonKodlari.Remove(422);

            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();






        }
    }
}
