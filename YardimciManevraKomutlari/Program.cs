




#region Yardımcı Manevratik Komutlar


//for (int i = 0; i < 100; i++)
//{
//    if (i == 22)
//    {
//     //   i = 100;
//     break;
//    }
//}

#endregion

#region break

//switch (10)
//{
//    case 5:
//        break;

//    case 10:
//        break;
//    case 15:
//        break;
//    default:
//        break;
//}

//while (true)
//{
//    break;
//}

//for (int i = 0; i < 5; i++)
//{
//    break;
//}

//foreach (var item in args)
//{
//    break;
//}

//do
//{
//    if (true)
//    {
//        break;
//    }
//}
//while (true);

//while (true)
//{
//    if (DateTime.Now.Second == 25)
//    {
//        break;
//    }
//    Console.WriteLine(DateTime.Now);

//}

//for (int i = 0; i < 5; i++)
//{
//for (global::System.Int32 j = 0; j < 3; j++)
//{
//    if (j == 1)
//    {
//        break;   
//    }
//    Console.WriteLine($"i : {i} - j : {j}");
//}
//}

#endregion

#region örnek 1

//kullanıcı t harfi girene kadar alınan tüm sayıları toplayan ve sonucu yazdıran program

//int toplam = 0;
//while (true)
//{
//    Console.WriteLine("sayı: ");

//    string girilenDeger = Console.ReadLine();

//    if (girilenDeger == "t")
//    {

//        Console.WriteLine($"Toplam : {toplam}");
//        break;
//    }

//    else
//    {
//        toplam += int.Parse(girilenDeger);
//    }
//}

#endregion

#region örnek 2

//kullanıcıdan alınan sayılardan 37 nin katı olunca sonlanan program
while (true)
{
    Console.Write("Sayı : ");
    int s = int.Parse(Console.ReadLine());
    
    if (s % 37 == 0)
    {
        break;
    }
}

#endregion