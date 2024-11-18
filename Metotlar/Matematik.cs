using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Matematik
    {
        public int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            Console.WriteLine(s1 + s2);
            return sonuc;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bol(int s1, int s2)
        {
            return s1 / s2;
        }

    }
}
