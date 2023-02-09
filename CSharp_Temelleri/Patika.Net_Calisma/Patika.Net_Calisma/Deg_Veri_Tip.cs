using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika.Net_Calisma
{
    internal class Deg_Veri_Tip
    {
        static void Main(string[] args)
        {
            int Deger = 2;
            Console.WriteLine(Deger);



            int Deger2 = 10;
            int Deger3 = Deger2*Deger;
            Console.WriteLine(Deger3);

            bool sonuc =Deger>10;
            Console.WriteLine(sonuc);



            float a = 5.4f;
            Console.WriteLine(a);




            decimal b = 9.99m;
            Console.WriteLine(b);



            char ch = '2';
            Console.WriteLine(ch);



            string str = "Emre";
            Console.WriteLine(str);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object m1 = "M";
            object m2 = "U";
            object m3 = "R";
            object m4 = "A";
            object m5 = "T";
            string kelime = m1 + " " + m2 + " " + m3 + " " + m4 + " " + m5;

            object d1 = 5;
            object d2 = 9;
            object d3 = 7;
            object d4 = 11;
            string Sayilar = d1 + " " + d2 + d3 + d4;
            Console.WriteLine(Sayilar);

            string i1 = "Murat";
            string i2 = "Emre";
            string i3 = "Eren";
            string Name =  i2 + " " + i1;
            string Surname = i3;
            string FullNAme = Name + " " + Surname;
            Console.WriteLine(FullNAme);

            int say1 = 42;
            int say2 = 444;
            int say3 = say1 * say2;
            Console.WriteLine(say3);


            string sSay = "29";
            int iSay = 42;
            string sDeger = sSay + iSay.ToString();
            Console.WriteLine(sDeger);

            int iDeger = iSay + Convert.ToInt32(sSay);
            Console.WriteLine(iDeger);

            int iDeger2 = iSay + int.Parse(sSay);
            Console.WriteLine(iDeger2);

            Console.ReadKey();




        }
    }
}

