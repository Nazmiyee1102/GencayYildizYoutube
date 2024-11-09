
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
//while (true)
//{
//    Console.Write("Sayı : ");
//    int s = int.Parse(Console.ReadLine());

//    if (s % 37 == 0)
//    {
//        break;
//    }
//}

#endregion

#region continue


//for (int i = 0; i < 10; i++)
//{
//    if (i % 2 != 0)
//        continue;
//    Console.WriteLine(i);
//}

#endregion

#region return

//while (true)
//{
//	switch (10)
//	{
//		case 10:
//			return;
//			break;
//	}
//}

//kullanıcı c tuşuna basana kadar sonsuz döngüde dönen program

//Console.WriteLine("");
//while (true)
//{
//    if (Console.ReadKey().KeyChar == 'c')
//    {
//        Console.WriteLine("Uygulama sona ermiştir.");
//        return;
//    }
//    Console.WriteLine("Uygulama çalışıyor");
//}

#endregion

#region goto

//switch (10)
//{
//	case 5:
//        Console.WriteLine("mcnvgjbjhxlkdf");
//		break;
//		case 6:
//		break;
//	case 10:
//		break;
//		goto case 5;
//}

#endregion

#region goto - örnek

//1 den 100 e kadar sayan program
//a :
//for (int i = 1; i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

//goto a;

//int i = 1;
//x:
//Console.WriteLine(i++);
//if (i <= 100)
//    goto x;


#endregion

#region goto - kritik

//a:
//for (int i = 0; i < 190; i++)
//{
//      Console.WriteLine(i);
//    goto a;
//}

#endregion