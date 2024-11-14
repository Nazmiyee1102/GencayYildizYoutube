#region string

//int? a = null;
//string b = null;//bunun alan tahsisinde yeri yok.

//string name = "";//null ==> bunun var

//string a2 = string.Empty;


#endregion

#region isnullorempty

//string x = string.Empty;

//if (x != "" & x is not null)
//{

//}

//if(string.IsNullOrEmpty(x))
//{

//}

#endregion

#region isnullorwhitespace

//string x = "    ";
//if (string.IsNullOrWhiteSpace(x))
//{

//}

#endregion

#region string ram(heap) ilişkisi

//string x = "vbgnhjkl";

#endregion

#region string - char dizisi

//string metin = "sebepsiz boş yere ayrılacaksan...";

//Console.WriteLine(metin[3]);
//Console.WriteLine(metin.Length);

#endregion

#region Döngülerle String Metin İçerisinde Her Bir Karaktere Ulaşma

//for (int i = 0; i < metin.Length; i++)
//{
//    if (metin[i] == 'e')
//    {
//        Console.WriteLine(i);
//    }
//}

//int i = 0;

//do
//{
//    if (metin[i] == 'e')
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}
//while (i < metin.Length);

#endregion

#region String İfadelerde “+” Operatörü

//string a = "Merhaba ", b = " dünya";
//Console.WriteLine($"{a + b}");
//int a2 = 5;
//Console.WriteLine(a + a2);

//Console.WriteLine(5 + 7 + 20 + " nazmiye");//sonucu string olur. çıktı : 32 nazmiye

#endregion

#region String Formatlandırma

//string isim = "Nazmiye", soyisim = "KURBAN", tcNo = "5451545646545";
//int yas = 26;
//bool medeniHal = true;

#region + Operatörü İle Formatlandırma

//Console.WriteLine("Tc No : " + tcNo + " olan " + isim + " " +  soyisim
//    + " şahsın bilgileri | Yaş : " + yas + "| Medeni Hal : " + (medeniHal ? "Evli" : "Bekar"));

#endregion

#region string.Format

//"....{0}.....{1}.....{2}", value1, value2;virgülden sonraki ilk değer 0. indexe,diğeri 1 e şeklinde gider.
//Console.WriteLine("Tc No : {0} olan isim {1}  soyisim {2}  şahsın bilgileri | Yaş : {3}| Medeni Hal : {4}" + (medeniHal ? "Evli" : "Bekar"), tcNo, isim, soyisim, yas, medeniHal);
//string sonuc = string.Format("Tc No: {0} olan {1} {2} şahsın bilgileri | Yaş : {3}| Medeni Hal: {4}", tcNo, isim, soyisim, yas, medeniHal ? "Evli" : "Bekar");
//Console.WriteLine(sonuc);

#endregion

#region $(String Interpolation) (C# 6.0)

//Console.WriteLine($"Tc No : {tcNo} olan {isim} {soyisim} adlı şahsın bilgileri : Yaş : {yas} Medeni Hal : {(medeniHal ? "Evli" : "Bekar")} {{iki string interpolation birbirini ezdi.bu cümle süslü parantez içerisinde string dönecektir.}} ");
#endregion

#endregion

#region Escape(Kaçış) Karakterleri

/*
  \o ==> null sonlandırma karakteridir. Genel olarak dosya veya veri kanalının bitişini belirtmek için kullanılır.
  \a ==> Bip sesini çıkartan karakterdir.
  \b ==> Backspace - geri - önceki karakteri silme
  \t ==> Tab
  \r ==> Satır başı (carriage return)
  \n ==> Bir alt satıra iner.
  \v ==> Dikey tab
  \f ==> Sayfa ilerleme
  \" ==> Çift tırnak
  \' ==> Tek tırnak
  \ ==> Backslash
 */

//Console.WriteLine("\" Bugün hava çok güzel. \"");
//Console.WriteLine("world\\dünya");
//Console.WriteLine("bip \a");
//Console.WriteLine("İsim\tSoyisim\tAdres");
//char c = '\'';



#endregion

#region @(Verbatim Strings) Operatörü

#region 1. Kullanım

int @void = 5;

#endregion

#region 2. Kullanım

Console.WriteLine("hava çok \"güzel\" ");
Console.WriteLine(@"hava çok ""güzel"" ");

#endregion

#region 3. Kullanım

string metin = @"öçşdf
    cvvvhjg
    lcömvkfh
    övfh";

#endregion

#endregion

#region String Interpolation İle Verbatim Strings Birlikteliği (C# 8.0)

//string isim = "Nazmiye", soyisim = "KURBAN", siparisNo = "348814";
//int fiyat = 326;

//string mailMessage = @$"Merhaba {isim} {soyisim} 
//{siparisNo} nolu sipariş talebiniz tarafımızca alınmıştır.
//Fiyat : {fiyat}";

//Console.WriteLine(mailMessage);

#endregion

#region String Fonksiyonlar

#region Contains

string sarki = "laylaylom galiba sana göre sevmeler...";

//bool sonuc = sarki.Contains("sana");
//Console.WriteLine(sonuc);

#endregion

#region StartsWith

Console.WriteLine(metin.StartsWith("laylay"));

#endregion

#region EndsWith

Console.WriteLine(sarki.EndsWith("..."));

#endregion

#region Equals

Console.WriteLine(sarki.Equals("mehmet"));

#endregion

#region Compare

Console.WriteLine(string.Compare(sarki, "z"));
Console.WriteLine(string.Compare(sarki, "a"));
Console.WriteLine(string.Compare(sarki, sarki));

Console.WriteLine(string.Compare(sarki, 9, sarki, 8, 5));

#endregion

#region CompareTo

Console.WriteLine(sarki.CompareTo("z"));
Console.WriteLine(sarki.CompareTo("a"));
Console.WriteLine(sarki.CompareTo(sarki));


#endregion

#region IndexOf

Console.WriteLine(sarki.IndexOf("la"));
Console.WriteLine(sarki.IndexOf("lay"));
Console.WriteLine(sarki.IndexOf("La"));
Console.WriteLine(sarki.IndexOf("sana"));

#endregion

#region Insert

Console.WriteLine(sarki.Insert(0, "5"));

#endregion

#region Remove

Console.WriteLine(sarki.Remove(5));//5. indexten sonraki tüm değerleri sil
Console.WriteLine(sarki.Remove(5, 10));//5. indexten sonra 10 değeri sil

#endregion

#region Replace

Console.WriteLine(sarki.Replace('a', 'b'));
Console.WriteLine(sarki.Replace("la", "lo"));

#endregion

#region Split

//string[] dizi = sarki.Split(' '); 
//string[] dizi = sarki.Split(' ', 'a');
//foreach (var item in metin)
//{
//    Console.WriteLine(item);
//}


#endregion

#region Substring

Console.WriteLine(sarki.Substring(5));//5. indexten sonuna kadar tüm değerleri getir.
Console.WriteLine(sarki.Substring(5, 10));//5. indexten başlar ve 10 karakter getir.

#endregion

#region ToLower

string cumle = "ŞSDKGKKBKY";
Console.WriteLine(cumle.ToLower());

#endregion

#region ToUpper

Console.WriteLine(sarki.ToUpper());

#endregion

#region Trim

Console.WriteLine("         aaaa        ".Trim());

#endregion

#region TrimEnd

Console.WriteLine("aaaa        ".TrimEnd());


#endregion

#region TrimStart

Console.WriteLine("         aaaa".TrimStart());


#endregion

#endregion

#region Örnekler

#region Adımızın İlkten 3. Soyadımızın Sondan 5. Karakterini Getirelim

//1. çözüm
string ad = "Nazmiye Kurban";
Console.WriteLine(ad[2]);
Console.WriteLine(ad[ad.Length - 5]);

//2. çözüm
Console.WriteLine(ad.Substring(2, 12));

//3.çözüm
string aralik = ad[2..^4];
Console.WriteLine(aralik[0]);
Console.WriteLine(aralik[aralik.Length-1]);

#endregion

#region Girilen Metnin İçerisinde Kaç Adet “n” Karakterinin Geçtiğini Hesaplayalım

Console.WriteLine("Metin : ");
string m = Console.ReadLine();

int adet = 0;
for (int i = 0; i < m.Length; i++)
{
    if (m[i] == 'n')
    {
        adet++;
    }
}
Console.WriteLine(adet);

#endregion

#region Girilen Metindeki Kelime Sayısını Hesaplayalım

//1.çözüm
Console.WriteLine("Lütfen bir metin giriniz : ");
string ornek = Console.ReadLine();

string[] kelimeler = ornek.Split(' ');
Console.WriteLine(kelimeler.Length);

//2.çözüm
int adet2 = 1;
while (true)
{
   int index = ornek.IndexOf(' ');
    if (index == -1)
    {
        break; 

    }
    adet2++;
    ornek = ornek.Substring(index + 1);
}

#endregion

#endregion