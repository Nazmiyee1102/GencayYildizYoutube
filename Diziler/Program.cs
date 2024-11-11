#region diziler

#region
////type a ==> değişken
////type[] a ==> dizi
////type[] name = new type {.....} ==> dizi nesnesi oluşturmayı sağlar.

//int[] ogrenci = { 20, 23, 25 };

//Console.WriteLine(ogrenci[1]);

//string[] personel = { "Hilmi", "Hüseyin", "Rıfkı", "Şuayip", "Muhiddin", "Naci", "Hüsnü", "Nurullah", "Cabbar", "Akif" };

////foreach (var p in personel)
////{
////    Console.WriteLine(p);
////}

//for (int i = 0; i < personel.Length; i++)
//{
//    Console.WriteLine(personel[i]);
//}

////int i = 0;
////do
////{
////    Console.WriteLine(personel[i++]);
////}
////while (i < 10);
///
#endregion

#region Dizi tanımlama varyasyonları 

#region varyasyon 1

//int[] yas = new int[2];
//yas[0] = 0;
//Console.WriteLine(yas[2]);

#endregion

#region varyasyon 2

//int[] yas = { 4, 85, 4, 52 };//tek satırlık dizi tanımlama


#endregion

#region varyasyon 3

//int[] yas = new int[] { 4, 85, 4, 52 };//tek satırlık dizi tanımlama


#endregion

#region varyasyon 4 - önemli

//int[] yas = new[] { 4, 85, 4, 52 };//tek satırlık dizi tanımlama
//var sayi = new[] { 3, 4, 45, 67 };//önemliiiii

#endregion

#endregion

#region array sınıfı

//Array yas = new int[2];

#endregion

#region  Array Türünden Dizilere Değer Atama/Okuma

#region yöntem 1
//int[] dizi = new int[3];
//dizi[0] = 5;
//dizi[1] = 6;
//dizi[2] = 7;
//Array dizi2 = dizi;


#endregion

#region yöntem 2

//Array dizi = new int[] { 3,6,7,8,99,};
//Array dizi1 = new int[5] { 3,6,7,8,99,};
//Array dizi2 = new[] { 3,6,7,8,99,};
//Array dizi2 = { 3,6,7,8,99,};//kullanılamaz

#endregion

#region yöntem 3

//Array dizi = new int[4];
//dizi.SetValue(30, 0);
//dizi.SetValue(31, 1);
//dizi.SetValue(32, 2);
//dizi.SetValue(33, 3);

#endregion

#region okuma

//Console.WriteLine(dizi.GetValue(0));

#endregion

#endregion

#region metotlar

#region clear

//Array isimler = new[] { "d", "ffg", "efgg", "Rıfkı", "1g", "şlfkjb", "eşgflkbj" };

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i));
//}
//Array.Clear(isimler, 1, 2);
//Console.WriteLine("*****************");
//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler.GetValue(i));
//}

#endregion

#region copy

//string[] isimler2 = new string[isimler.Length];

////Array.Copy(isimler, isimler2, 5);

////for (int i = 0; i < isimler2.Length; i++)
////{
////    Console.WriteLine(isimler2[i]);
////}

//Array.Copy(isimler, 2, isimler2, 0, 2);
//for (int i = 0; i < isimler2.Length; i++)
//{
//    Console.WriteLine(isimler2[i]);
//}

#endregion

#region indexof

//int index = Array.IndexOf(isimler, "efgg");//varsa index numarasını, yoksa -1 verir.

//Console.WriteLine(index);

//int rifki = Array.IndexOf(isimler, "Rıfkı", 0, 3);//rıfkıyı 0 ile 3. index arasında arayacak
//Console.WriteLine(rifki);

#endregion

#region reverse

//Array.Reverse(isimler);
//for(int i = 0; i < isimler.Length; i++)
//     Console.WriteLine(isimler.GetValue(i));

//Array.Reverse(isimler, 0, 3);
//for (int i = 0; i < isimler.Length; i++)
//    Console.WriteLine(isimler.GetValue(i));


#endregion

#region sort

//for (int i = 0; i < isimler.Length; i++)
//     Console.WriteLine(isimler.GetValue(i));

//Array.Sort(isimler);
//for (int i = 0; i < isimler.Length; i++)
//    Console.WriteLine(isimler.GetValue(i));


#endregion

#region CreateInstance

//int[] x = {1,2,3};//esasında arka planda array sınıfının CreateInstance metodunu kullanır.     
//Array x2 = Array.CreateInstance(typeof(int[]), 3);

#endregion

#endregion

#region array sınıfının özellikleri

#region isreadonly

//Console.WriteLine(isimler.IsReadOnly);

#endregion

#region isfixedsize

//Console.WriteLine(isimler.IsFixedSize);

#endregion

#region rank

//Console.WriteLine(isimler.Rank);//tek dereceli

//int[,] x = { { 0, 5 }, { 1, 8 }, { 2, 6 } };//iki dereceli
//Console.WriteLine(x.Rank);

#endregion

#endregion

#endregion

#region Ranges and Indices (C# 8.0)

#region System.Index 

//    0         1        2         3        4
//string[] isimler = { "Hüseyin", "Hilmi", "Rıfkı", "Hatice", "Ayşe" };
//Index index = 3;

//                    //                       3         2        1      
//string[] isimler2 = { "Hüseyin", "Hilmi", "Rıfkı", "Hatice", "Ayşe" };
//Index index2 = ^3;



#endregion

#region System.Range

#region .. operatörü 

//int[] sayilar = { 3, 5, 7, 29, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
//Range range = 5..10;
//var sayilar2 = sayilar[range];
//sayilar2[0] = 100;

//Range range = ..; // Tüm diziye karşılık gelir.

#endregion

#region örnek

//Range range = ^5..^3;
//var sayilar2 = sayilar[range];

#endregion

#region kritik

//Index i1 = 5, i2 = 10;

//Range range = i1..i2;

#endregion

#region ^ operatörü

//Index i = ^3;//457

//Range range = ^7..^3;//31-5643 arası
//var sayilar2 = sayilar[range];

#endregion

#endregion



#endregion

#region Çok Boyutlu Diziler

#region tanımlama
//type[]==> tek boyutlu dizi
//type[,]==> iki (çift) boyutlu dizi
//type[,,,]==> dört boyutlu dizi

//int[,] sayilar = new int[3, 5];

//2 boyutludan fazla dizi tanımlaması
//int[,,,] s2 = new int[3, 4, 5, 6];

#endregion

#region Çok Boyutlu Diziye Değer Atama

//int[,] sayilar = new int[3, 5];
//sayilar[1, 2] = 5;
//sayilar[2, 3] = 6;

//int[,,,] s2 = new int[3, 4, 5, 6];
//s2[0, 0, 0, 0] = 15;

//int[,,] s = new int[2, 3, 4];
//s[0, 0, 0] = 0;

#region değer atama varyasyonları

//int[,] sayi =
//{
//   { 3, 5, 6 },
//   { 6, 7, 8 },
//   { 7, 9, 10 },
//   { 8, 10, 11 },
//};

#endregion

#endregion

#region iç içe döngüler

//int[,,] sayilar = new int[2, 2, 4];
//sayilar[0, 0, 0] = 1;
//sayilar[0, 0, 1] = 2;
//sayilar[0, 0, 2] = 3;
//sayilar[0, 0, 3] = 4;
//sayilar[0, 1, 0] = 5;
//sayilar[0, 1, 1] = 6;
//sayilar[0, 1, 2] = 7;
//sayilar[0, 1, 3] = 8;
//sayilar[1, 0, 0] = 9;
//sayilar[1, 0, 1] = 10;
//sayilar[1, 0, 2] = 11;
//sayilar[1, 0, 3] = 12;
//sayilar[1, 1, 0] = 13;
//sayilar[1, 1, 1] = 14;
//sayilar[1, 1, 2] = 15;
//sayilar[1, 1, 3] = 16;

//for (int i = 0; i < sayilar.GetLength(0); i++)
//{
//    for (global::System.Int32 j = 0; j < sayilar.GetLength(1); j++)
//    {
//        for (global::System.Int32 k = 0; k < sayilar.GetLength(2); k++)
//        {
//            Console.Write(sayilar[i,j,k] + "  ");
//        }
//        Console.WriteLine("");
//    }
//}

#endregion

#endregion

#region düzensiz diziler

//tanımlama
//type[][]

int[][] sayilar = new int[3][];
sayilar[0] = new int[3] { 3, 5, 7 };
sayilar[1] = new int[5] { 38, 65, 57, 54, 61 };
sayilar[2] = new int[10] { 23, 54, 13, 2, 3, 4, 5, 6, 7, 2 };


////değer atama ve okuma
//Console.WriteLine(sayilar[0][0]);
//sayilar[0][0] = 5;
//Console.WriteLine(sayilar[0][0]);

////eleman sayısını öğrenme
//Console.WriteLine(
//    sayilar[0].Length +
//    sayilar[1].Length +
//    sayilar[2].Length);

//döngüler
for (int i = 0; i < sayilar.Length; i++)
{
    for (global::System.Int32 j = 0; j < sayilar[i].Length; j++)
    {
        Console.Write(sayilar[i][j] + "  -  ");
    }
    Console.WriteLine("");
}

#endregion
