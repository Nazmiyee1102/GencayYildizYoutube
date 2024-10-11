#region Aritmetik Operatörlerde Geriye Dönüş Değerleri

#region İnceleme 1

//int sonuc = 5 + 3;

#endregion

#region İnceleme 2

//int x = 3, y = 5;

//int sonuc = x * y;

#endregion

#region İnceleme 3

//double sayi1 = 123, sayi2 = 321;

//double sonuc = sayi1 + sayi2;

#endregion

#region İnceleme 4

//decimal s1 = 124, s2 = 85;

//decimal sonuc = s1 / s2;

#endregion

#region (int) * (double)

//int sayi1 = 10;
//double sayi2 = 5;

//double sonuc = sayi1 + sayi2;

#endregion

#region (byte) * (int)

//int s1 = 3;

//byte s2 = 123;

//int sonuc = s1 - s2;//int döner

#endregion

#region (byte) * (byte) = ? (İstisna! - Mülakat!!!)

//byte s1 = 10, s2 = 5;

//int sonuc = s1 - s2;

#endregion

#region Karşılaştırma Operatörleri

#region Örnek
//true         //true               //false               //true
//Console.WriteLine(((true & false | false & ((true ^ false) & false) | true)));//true
//false
#endregion

//int a = 5, b = a++;
//Console.WriteLine(a);
//Console.WriteLine(b);

//int i1 = 5, i2 = ++i1, i3 = i1;
//i2 = ++i2;
//Console.WriteLine(i1);
//Console.WriteLine(i2);
//Console.WriteLine(i3);

//string a = "dhd", b = "fvb";



#endregion

#endregion

#region Ternary Operatörü

#region Örnek 1
//bool medeniHal = false;
//string mesaj = medeniHal == true ? "Evlilere kampanya...." : "Bekarlara kampanya.....";
//Console.WriteLine(mesaj);
#endregion

#region Örnek 2
/*
 yaşı 25'ten küçük olanlara A, 25 olanlara B ve 25' ten büyük olanlara
C değerini döndüren ternary operatörünü oluşturalım.

 */

//int yas = 25;

//char deger = yas < 25 ? 'A' : yas == 25 ? 'B' : 'C';
//Console.WriteLine(deger);


#endregion

#region Örnek 3

/*Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz.

sayı < 3                      =>     sayı * 5
sayı > 3 & sayı < 9           =>     sayı * 3
sayı >= 9 & sayı % 2 == 0     =>     sayı * 10
sayı % 2 == 1                 =>     sayı 
hiçbiri değilse               =>     -1 

 */

//Console.Write("Lütfen bir sayı giriniz : ");
//int sayi = int.Parse(Console.ReadLine());

//int sonuc = sayi < 3 ? sayi * 5 : 
//    (sayi > 3 & sayi < 9 ? sayi * 3 : 
//    (sayi >= 9 & sayi % 2 == 0) ? sayi * 10 : 
//    (sayi % 2 == 1 ? sayi : -1));

//Console.WriteLine($"Sonuç: {sonuc}");

#endregion

#region Örnek 4

/*
 Hava durumunu tutan string değişkenin değerine göre aşağıdaki önergeleri uygulayan programı yazınız.

Yağmurlu    =>   Şemsiye almalısın.
Güneşli     =>   Bol bol d vitamini alman dileğiyle
Kapalı      =>   Yağmur yağabilir.
Hiçbiri     =>   -1

 */

//string hava = "Güneşli";
//string durum = hava == "Yağmurlu" ? " Şemsiye almalısın." : (hava == "Güneşli" ? "Bol bol d vitamini alman dileğiyle" : (hava == "Kapalı" ? "Yağmur yağabilir." : "-1"));
//Console.WriteLine(durum);

#endregion


#endregion

#region sizeof

//Console.WriteLine($"int : {sizeof(int)}");
//Console.WriteLine($"long : {sizeof(long)}");
//Console.WriteLine($"decimal : {sizeof(decimal)}");

#endregion

#region typeof

//Type t = typeof(int);
//Console.WriteLine(t.Name);
//Console.WriteLine(t.IsPrimitive);
//Console.WriteLine(t.IsClass);
//Console.WriteLine(t.IsValueType);

#endregion

#region default

//Console.WriteLine(default(decimal));
//Console.WriteLine(default(string));
//Console.WriteLine(default(Program));
//Console.WriteLine(default(short));
//Console.WriteLine(default(byte));

//int a = default;

#endregion

#region is

//object x = true;
//Console.WriteLine(x is bool);
//Console.WriteLine(x is int);
//Console.WriteLine(x is Program);

#endregion

#region is null

//string a = null;

//Console.WriteLine(a is null);

#endregion

#region is not null

//string a = null;
//Console.WriteLine(a is not null);


#endregion

#region as

//cast örneklendirmesi
//object x = "ıjdffc";
//string x2 = (string)x;
//Console.WriteLine(x2);

//object x = "ıjdffc";
//string y = x as string;
//Console.WriteLine(y);

//object x = 123;
//int? y = x as int?;

#endregion

#region nullable (?)

//int? a = 5;
//bool? b = false;

//Console.WriteLine(a is null);

#endregion

#region null-coalescing (??)

//string a = null;
//Console.WriteLine(a ?? "Merhaba");

#endregion

#region null-coalescing assigment (??=) 

//string x = "null";
//Console.WriteLine(x ??= "Merhaba");

#endregion