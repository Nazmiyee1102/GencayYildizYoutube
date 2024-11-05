#region switch-case

//string adi = "Ahmet";

//switch (adi)
//{
//	case "Mehmet":
//        Console.WriteLine("Adı Mehmet");
//		break;

//	case "Ayşe":
//        Console.WriteLine("Adı Ayşe");
//		break;

//    case "Hilmi":
//        Console.WriteLine("Adı Hilmi");
//        break;

//    default:
//        Console.WriteLine(""); 
//        break;
//}

#endregion

#region when

//int satisTutari = 1000;
//switch (satisTutari)
//{
//	case 1000 when (3 == 5):
//		break;

//	case 1000 when (3 == 3):
//		break;
//}

#endregion

#region goto

//int i = 10;
//switch (i)
//{
//    case 5:
//        Console.WriteLine(i * 10);
//        break;
//    case 6:
//        Console.WriteLine(i / 5);
//        break;
//    case 7:
//     //   goto case 5; //Console.WriteLine(i * 10); birleştirmek için bu satıra gerek yok
//       // break;
//    case 10:
//        goto case 5;  //Console.WriteLine(i * 10);
//       // break;
//}

#endregion

#region Switch Expression

string mesaj = "";
//eski yöntem
switch (DateTime.Now.DayOfWeek)
{
	case DayOfWeek.Sunday:
		mesaj = "Bugün Pazar";
		break;
	case DayOfWeek.Monday:
        mesaj = "Bugün Pazartesi";
        break;
	case DayOfWeek.Tuesday:
        mesaj = "Bugün Salı";
        break;
	case DayOfWeek.Wednesday:
        mesaj = "Bugün Çarşamba";
        break;
	case DayOfWeek.Thursday:
        mesaj = "Bugün Perşembe";
        break;
	case DayOfWeek.Friday:
        mesaj = "Bugün Cuma";
        break;
	case DayOfWeek.Saturday:
        mesaj = "Bugün Cumartesi";
        break;
	default:
		break;
}

//switch expression yeni yöntem
string mesaj2 = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Monday => "Bugün Pazartesi",
    DayOfWeek.Tuesday => "Bugün Salı",
    DayOfWeek.Wednesday => "Bugün Çarşamba",
    DayOfWeek.Thursday => "Bugün Perşembe",
    DayOfWeek.Friday => "Bugün Cuma",
    DayOfWeek.Saturday => "Bugün Cumartesi",
    DayOfWeek.Sunday => "Bugün Pazar"
};
Console.WriteLine(mesaj);

#endregion

#region switch expression ve when anahtar kelimesi

int i = 10;
string isim = i switch
{
    5 when 3 == 3 => "Hilmi",
    var x when x == 7 & x % 2 == 1 => "Rıfkı",
    10 => "Gençay",
    var x => "Hiçbiri"//dafult un karşılığı
};

#endregion

#region tuple patterns

int sayi1 = 10, sayi2 = 20;
//string mesaj3 = "";
//switch (sayi1, sayi2)
//{
//    case (5,10):
//        mesaj = "5 ile 10 değerleri ";
//        break;
//    case (10, 20):
//        mesaj = "10 ile 20 değerleri";
//        break;
//}

string message = (sayi1, sayi2) switch
{
    (5,10) => "5 ile 10 değerleri",
    (10,20) => "10 ile 20 değerleri"
};
Console.WriteLine(message);

#endregion

#region when şartı ile tuple patterns

string message2 = (sayi1, sayi2) switch
{
    (5, 10) when true => "5 ile 10 değerleri",
    var x when x.sayi1 %2 == 1  | x.sayi2 == 10 => "10 ile 20 değerleri"
};
Console.WriteLine(message2);

#endregion