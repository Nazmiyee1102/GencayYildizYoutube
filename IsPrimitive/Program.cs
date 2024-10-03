using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(typeof(decimal).IsPrimitive);//false
            //Console.WriteLine(typeof(int).IsPrimitive);//true
            //Console.WriteLine(typeof(byte).IsPrimitive);//true

            //tople değişken
            //(int a, int b, Type c, Type d) z;

            //(int a, string b) c = (5, "Ahmet");
            //Console.WriteLine(c.b);

            //(int yas, string adi, bool medeniHal) kisi = (28, "Gençay", true);
            //Console.WriteLine(kisi);

            //int sayi = 1_000_000;
            //Console.WriteLine(sayi);

            //varsayılan değerler
            //bool x = default;
            //int y = default;
            //string z = default;
            //char c = default;

            //Console.WriteLine(x);//false
            //Console.WriteLine(y);//0
            //Console.WriteLine(z);//null
            //Console.WriteLine(c);// /0

            //int a = 5, b = 10;
            //int c = b;//c = 10
            //int d = a;// d = 5
            //b = a;// b = 5
            //c = b;//c = 5
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int a = 5;
            //a = a;
            //Console.WriteLine(a);//a = 5

            //sabit değerler
            //const double pi = 3.14;
            //Console.WriteLine(pi);

            //deep copy
            //int a = 5;
            //int b = a;

            //a = a * 5;
            //Console.WriteLine(a);//25
            //Console.WriteLine(b);//5 deep copy

            //shallow copy


            Console.Read();
        }
    }
}
