using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro();
            string sentence = ("My Name is CengoLand");
            
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is ZeynaLand";
            var result3 = sentence.IndexOf("name");//<Cümlenin içindeki "name" hangi satırdan başladığını bulma
            var result4 = sentence.EndsWith("d");//< Cümle "d" ile bitiyorsa true, bitmiyorsa false yazdırma.
            var result5 = sentence.StartsWith("My name");//<Cümlenin içindeki "My name" kelimesinin yerini bulma.
            var result6 = sentence.LastIndexOf(" "); // <Cümlenin içindeki son "boşluk" ifadesinin nerede olduğunu bulma.
            var result7 = sentence.Insert(0, "Hello ,");//< Cümlenin başına eklenecek olan ifadeyi seçme.
            var result8 = sentence.Substring(3); //< Cümleye belirtilen (3) sıradan itibaren yazdırma.
            var result9 = sentence.Substring(3,4);//< Cümlenin belirtilen aralıklardaki (3,4) karakterlerini yazdırma.
            var result10 = sentence.ToUpper();//<Cümledeki tüm karakterleri büyük harfe çevirme.
            var result11 = sentence.ToLower();//< Cümledeki tüm harfleri küçük harfe çevirme.
            var result12 = sentence.Replace(" ", "-"); //< Cümledeki belirli karakterleri başka bir karakterle değiştirme
            var resut13 = sentence.Remove(1,3);//< Cümle içindeki belirtilen yeri kaldırma.
            
                



            Console.WriteLine(result14);
            Console.ReadLine();
        }

        private static void intro()
        {
            string city = "Ankara";
            string city2 = "Tokat";
            string city3 = "İzmir";
            Console.WriteLine(string.Format("{0}**{1}**{2}", city, city2, city3));
            Console.ReadLine();
        }
    }
}
