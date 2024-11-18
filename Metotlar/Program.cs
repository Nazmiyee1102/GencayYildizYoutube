using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FileInfo> files = DosyaYazdir(@"C: \Users\ASUS\source\repos\GencayYildizYoutube");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }

            int[] sayilar = new int[10];
            //SayiUret(sayilar);
            //SayiUret(sayilar);
            //SayiUret(sayilar);
           // Console.WriteLine(Topla2(10,20));
            X();
           // A();
            Matematik matematik = new Matematik();
            matematik.Topla(84, 52);

            int sonuc = Topla(5, 3);
            if (sonuc > 10)
            {
                Console.WriteLine("sonuç 10' dan büyük.");
            }

            bool s = PersonelEkle("Rıfkı", "Adaş", 25);
            if (s == true)
            {

            }
            else
            {

            }

            X(15, 10, 52);

            Y(c: "sf", a: 4, b: 5);

            #region Tanımlanmış metodun kullanımı

            X();

            #region tanımlanfığı sınıf içerisinde kullanımı



            #endregion

            #endregion

        }

        #region Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar)

        public static int X2()
        {
            Y();

            void Y()
            {
                Console.WriteLine("Merhaba");
            }
            Y();

            return 0;
        }

        #endregion

        #region Recursive(Tekrarlamalı/Özyinelemeli) Metotlar

        static void A()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("fghjk");
                while (true)
                {
                    A();
                }

            }
        }

        #region örnek 1

        //belirli değer aralığındaki 5 in katı olan tüm sayıları toplayan recursive 
        int Topla2(int baslangic, int bitis)
        {
            if (baslangic % 5 == 0 & baslangic < bitis)
            {
                return baslangic + Topla2(++baslangic, bitis);
            }
            return Topla2(++baslangic, bitis);
        }

        #endregion

        #region örnek 2

       static List<FileInfo> DosyaYazdir(string path)
        {
            List<FileInfo> fileInfos = new();
            DirectoryInfo directoryInfo = new(path);
            DirectoryInfo[] directoryInfos =  directoryInfo.GetDirectories();
            if (directoryInfos.Any())
            {
                foreach (DirectoryInfo  directory in directoryInfos)
                {
                    DosyaYazdir(directory.FullName);
                }
            }
            else
            {
                fileInfos.AddRange(directoryInfo.GetFiles());
            }
            return fileInfos;
        }

        #endregion

        #endregion


        #region Non Trailing Named Arguments Özelliği

        static void Y(int a, int b, string c)
        {

        }

        #endregion

        #region Metotlarda In Parametreleri (C# – In Keywordü)

        static void A(int b, in int a = 555)
        {

            b = 5;
        }

        #endregion


        static void X()
        {

        }

        #region Geriye değer döndürmeyen, parametre almayan

        public void Metot1()
        {
            Console.WriteLine("Geriye değer döndürmeyen, parametre almayan metot oluşturuldu.");
        }

        #endregion

        #region Geriye değer döndürmeyen, parametre alan

        public void Metot2(int a, int b)
        {

        }

        #endregion

        #region Geriye değer döndüren, parametre almayan

        public int Metot3()
        {
            return 2;
        }

        private int Metot4()
        {
            if (DateTime.Now.Second > 10)
                return 5;
            return 0;
        }

        #endregion

        #region Geriye değer döndüren, parametre alan

        bool Metot5(int a)
        {
            return true | false;
        }

        public int Metot6(int x)
        {
            return DateTime.Now.Year > 2000 ? 1 : 0;
        }

        static public int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }

        #endregion

        static public bool PersonelEkle(string ad, string soyadi, int yas)
        {
            if (yas >= 20)
            {
                //veritbanına eklendi
                return true;
            }
            else
            {
                Console.WriteLine("personel yaşı 20 den küçük olamaz.");
                return false;
            }
        }

        private static void SayiUret(int[] sayilar)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = new Random().Next();
            }
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        #region Metotlarda Optional Parameters(İsteğe Bağlı Parametreler)

        static public void X(int a, int x, int y, int b = 2, int c = 5)//Birden fazla parametre içerisinde bir kısmı opsiyonel olabilir. Fakat opsiyonel olanlar sağ tarafta tanımlanmalıdır.
        {

        }



        #endregion
    }

    class Ornek
    {
        public void A()
        {
            B();
        }

        public void B()
        {
            C(5);
        }

        private int C(int a)
        {
            return a;
        }
    }
}