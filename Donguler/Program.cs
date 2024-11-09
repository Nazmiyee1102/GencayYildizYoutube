
#region Döngüler 

#region for döngüsü


//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{i}- Nazmiye KURBAN");
//}

//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine("a");
//}

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int toplamSonuc = 0;

//for (int i = 1; i <= 40; i++)
//{
//    if (i % 2 == 0)
//    {
//        toplamSonuc += i;
//    }
//}
//Console.WriteLine(toplamSonuc);


#endregion

#region for örnek

//Console.Write("Sayıyı giriniz : ");
//int sayi = int.Parse(Console.ReadLine());

//int faktoriyel = 1;
//string sonuc = "";

#region çözüm 1
//for (int i = 1; i <= sayi; i++)
//{
//    faktoriyel *= i;
//}
//Console.WriteLine($"Faktöriyel : {faktoriyel}");

#endregion

#region çözüm 2

//for (int i = sayi; i > 0; i--)
//{
//    faktoriyel *= i;
//    sonuc += i + (i == 1 ? "  =" : " x ");
//    if (i == 1)
//    {
//        sonuc += i + " = ";
//    }
//    else
//    {
//        sonuc += i + " x ";
//    }
//}

//Console.WriteLine($"Sonuç : {sonuc} {faktoriyel}  ");
#endregion

#endregion

//farklı bir varyasyon 
//int i = 0;
//for (; i < 10; i++)
//{

//}

//sonsuz döngü
//for (int i = 0; ; i++)
//{
//    Console.WriteLine("Hello ");
//}

//sonsuz döngü
//for (; ; )
//{
//    Console.WriteLine("kjjjj");
//}

//varyasyon
//for (int i = 0, j = 10; i < 10 & j < 5; i++, j++)
//{
//    Console.WriteLine(i);
//    Console.WriteLine(j);
//}

#region while döngüsü

#region örnek 1
//int i = 0;
//while (i < 10)
//{
//    Console.WriteLine("jsh");
//    i++;
//}
#endregion

#region örnek 2

//ekrana 10 merhaba
//int metin = 0;
//while (metin < 10)
//{
//    Console.WriteLine("merhaba");
//    metin++;
//}

#endregion

#region örnek 3

//klavyeden girilen sayıdan geriye doğru 0 a kadar sayan program

//Console.Write("Sayı : ");
//int sayi = int.Parse(Console.ReadLine());

//while (sayi >= 0)
//{
//   // sayi--;//buraya yazılırsa yazılan sayı dahil olmaz. negatif sayılara doğru sayar.
//    Console.WriteLine(sayi);
//    sayi--;

//}

#endregion

#region örnek 4

//0 ile 100 arasındaki tek sayıları toplayan program
//int i = 0, toplam = 0; ;
//while (i <= 100)
//{
//    if (i % 2 == 1)
//    {
//        toplam += i;

//    }
//    i++;
//}
//Console.WriteLine(toplam);

#endregion

#region örnek 5

//klavyeden girilen sayının faktöriyeli
//Console.WriteLine("Sayı : ");
//int sayi = int.Parse(Console.ReadLine());

//int faktoriyel = 1;

//while (sayi > 0 )
//{
//    faktoriyel *= sayi--;
//    //sayi--;
//}

//Console.WriteLine(faktoriyel);
#endregion

#region örnek 6

//o anki tarihin saniye değeri 5 in katıysa tarihi ekranda yazan program
//while (true)
//{
//    if (DateTime.Now.Second % 5 == 0)
//        Console.WriteLine(DateTime.Now);
//}

#endregion

#region do while

//while (false)
//{
//    Console.WriteLine("while döngüsü");
//}

//do
//{
//    Console.WriteLine("do while döngüsü");
//} while (false);

#endregion



#endregion

#region scope suz döngüler

//for(int i = 0; i < 10; i++)
//    Console.WriteLine("kfdgn");

//while (true)
//    Console.WriteLine("fgbkghnh");


//do
//    Console.WriteLine("kdfmg");
//while (true);

#endregion

#region sonsuz döngüler

#region sonsuz döngü - for döngüsü
//bool dongu = true;
//for (; dongu; )
//{
//    if (true)
//    {
//        dongu = !dongu;

//    }
//}

#endregion

#region sonsuz döngü - while

//bool durum = false;
//while (!durum)
//{
//    if (true)
//    {
//        durum = !durum;
//    }
//}

#endregion

#region sonsuz döngü - do while
//bool durum = true;
//do
//{
//    if (true)
//    {
//        durum = !durum; 
//    }
//} while (durum);

#endregion

#endregion

#region iç içe döngüler

//for (int i = 0; i < 10; i++)
//{
//    for (global::System.Int32 j = 0; j < 5; j++)
//    {
//        while (true)
//        {

//        }
//    }
//}


#region iç içe döngüler - for
//bu döngünün maliyeti => 10 * 5 * 3 * 4 = 600
//for (int i = 0; i < 10; i++)//10 tur
//{
//	for (int j = 0; j < 5; j++)//5 tur
//	{
//        for (int k = 0; k < 3; k++)//3 tur
//        {
//            int p = 0;
//            while (p < 4)//4 tur
//            {
//                p++;
//            }
//        }
//    }
//}

#endregion


#endregion

#region döngülerde boş scope kullanmak istemediğimiz durumlarda ;(noktalı virgül) operatörüyle temiz kod yazımı

while (true)
{

}

while (true) ;//sonsuz döngü 

for (;  ; )
{
    
}

for (; ; );//sonsuz döngü

do
{
    
}
while (true);

do;           //sonsuz
while (true);//döngü

#endregion

#endregion

