#region Foreach İterasyonu

//int[] sayilar = { 45, 8, 23, 41, 65, 68, 6, 79 };

//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.WriteLine(sayilar[i]);
//}

using System.Collections;

ArrayList sayilar = new ArrayList { 45, 8, 23, 41, 65, 68, 6, 79 };

foreach (var item in sayilar)
{
    //sayilar.Add(345);//koleksiyonun yapısını bozar. iterasyon patlar.
    Console.WriteLine(item);
}

#endregion