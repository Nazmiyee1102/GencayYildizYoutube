

#region if  

//bool medeniHal = true;
//if (medeniHal == true)
//{
//    Console.WriteLine("Mutlu yıllar");
//}

#endregion

#region Kritik 1

//int i = 10;
//if (i != 10)
//{
//    Console.WriteLine("Merhaba");
//}
//Console.WriteLine("Dünya");

#endregion

#region Kritik 2

//bool medeniHal2 = true;
//if (medeniHal)
//{
//    Console.WriteLine("Hayırlı Olsun");
//}

#endregion

#region if-else

//int i = 10;
//if (i > 5)
//{
//    Console.WriteLine("i değeri 5'ten büyüktür.");
//}
//else
//{
//    Console.WriteLine("i değeri 5'ten büyük değildir.");
//}

#endregion

#region if-else kritik1


//int a = 10;
//if (a != 5)
//{
//    Console.WriteLine("a 10'a eşittir.");
//}

//else
//{
//    Console.WriteLine("a 10' a eşit değildir.");
//}
#endregion

#region if-else kritik2

//int b = -5;
//if (b == 5)
//{
//    Console.WriteLine("sayı 5");
//}

//else
//{
//    Console.WriteLine("sayı 5 değil");
//}

//Console.WriteLine("merhaba");

#endregion

#region if-else if

//int sayi = 31;
//if (sayi > 5 & sayi <= 10)
//{
//    Console.WriteLine(sayi * 5);
//}

//else if (sayi > 10 & sayi <= 20)
//{
//    Console.WriteLine(sayi * 10);

//}

//else if (sayi > 20 & sayi <= 30)
//{
//    Console.WriteLine(sayi * 20);
//}

//else
//{
//    Console.WriteLine(sayi);
//}

#endregion

#region if-else if kritik 1

//int sayi = int.Parse(Console.ReadLine());
//if (sayi == 100 & sayi <= 200)
//{
//    Console.WriteLine("100-200 arasında");
//}

//else if (sayi > 200 & sayi <= 300)
//{
//    Console.WriteLine("200-300 arasında");
//}

//else if (sayi > 300 & sayi <= 400)
//{
//    Console.WriteLine("300-400 arasında");
//}

#endregion

#region scope suz if

//if (true)
//    Console.WriteLine("jnfkmvh");

#endregion

#region Örnek 1

//klavyeden 2 ürünün fiyatı girildiğinde toplam fiyat 200 tl den 
//fazla ise, ikinci üründen %25 indirim yaparak ödenecek tutarı 
//gösteren uygulama

/*
 int fiyat1, fiyat2;
Console.Write("1. Ürünün Fiyatı : ");
fiyat1 = int.Parse(Console.ReadLine());

Console.Write("2. Ürünün Fiyatı : ");
fiyat2 = int.Parse(Console.ReadLine());

int toplam = fiyat1 + fiyat2;

if (toplam > 200)
{
    int odenecekTutar = fiyat1 + (fiyat2 * 75/100);
    Console.WriteLine(odenecekTutar);
}

else
{
    Console.WriteLine(toplam);
}
*/
#endregion

#region Örnek 2

//belirlenen kullanıcı adı ve şifre doğru girildiğinde "Giriş Başarılı", yanlış giril-
//diğinde "Girdiğiniz kullanıcı adı veya şifre hatalı" mesajı veren program

//string kullaniciAdi, sifre;

//Console.Write("Kullanıcı adını giriniz : ");
//kullaniciAdi = Console.ReadLine();

//Console.Write("Şifre giriniz : ");
//sifre = Console.ReadLine();

////if (kullaniciAdi == "Nazmiye123" & sifre == "123")
////{
////    Console.WriteLine("Giriş Başarılı");
////}

////else
////{
////    Console.WriteLine("Girdiğiniz kullanıcı adı veya şifre hatalı");
////}

////ternary
//Console.WriteLine(kullaniciAdi == "Nazmiye123" & sifre == "123" ? "Giriş Başarılı" : "Girdiğiniz kullanıcı adı veya şifre hatalı");

#endregion

#region Örnek 3

//kullanıcıdan alınan iki sayının ve yapılacak işlem türünün 
//(toplama,çıkarma,bölme,çarpma) sonucu hesaplayan program

//Console.Write("1.sayı : ");
//int sayi1 = int.Parse(Console.ReadLine());

//Console.Write("2.sayı : ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.Write("Yapmak istediğiniz işlem : ");
//char yapilacakIslem = char.Parse(Console.ReadLine());

//if
//if (yapilacakIslem == '+')
//{
//    Console.WriteLine(sayi1 + sayi2);
//}

//else if (yapilacakIslem == '-')
//{
//    Console.WriteLine(sayi1 - sayi2);
//}

//else if (yapilacakIslem == '*')
//{
//    Console.WriteLine(sayi1 * sayi2);
//}

//else if (yapilacakIslem == '/')
//{
//    Console.WriteLine(sayi1 / sayi2);
//}

//else
//{
//    Console.WriteLine("Böyle bir işlem bulunmamaktadır.");
//}

//switch
//switch (yapilacakIslem)
//{
//    case '+':
//        Console.WriteLine(sayi1 + sayi2);
//        break;
//    case '-':
//        Console.WriteLine(sayi1 - sayi2);
//        break;
//    case '*':
//        Console.WriteLine(sayi1 * sayi2);
//        break;
//    case '/':
//        Console.WriteLine(sayi1 / sayi2);
//        break;

//    default:
//        Console.WriteLine("Böyle bir işlem bulunmamaktadır.");
//        break;
//}

//int sonuc = yapilacakIslem switch
//{
//    '+' => sayi1 + sayi2,
//    '-' => sayi1 - sayi2,
//    '*' => sayi1 * sayi2,
//    '/' => sayi1 / sayi2,
//    _ => 'B'//_ discard operatörüdür. hiçbiri anlamına gelir. default un karşılığıdır.

//};

#endregion

#region Örnek 4

//girilen sayının değeri 10 değilse "sayı yanlış" yazan program

//Console.Write("Sayıyı giriniz : ");
//int sayi = int.Parse(Console.ReadLine());

//if (sayi != 10)
//{
//    Console.WriteLine("sayı yanlış");
//}


#endregion

#region Örnek 5

//girilen sayının negatif ya da pozitif olduğunu bulan program

int sayi = int.Parse(Console.ReadLine());

string sonuc = "";

if (sayi < 0)
    //Console.WriteLine("negatif");
    sonuc = "negatif";
else
    //Console.WriteLine("pozitif");
    sonuc = "pozitif";

Console.WriteLine(sonuc);

#endregion
