using System.Text.RegularExpressions;

#region Regular Expressions 

#region  ^ Operatörü, Regex Sınıfının Kullanımı

//^9

string test = "95321556+52145554850ksdfvgyujıkanjfdduıaosldkj";

Regex regex = new Regex("^9");
Match match = regex.Match(test);

Console.WriteLine(match.Success);

#endregion

#region \ Operatörü

/* \ Operatörü ve Türevleri
 
\ Operatörü: Belirli karakter gruplarını içermesi istendiğinde kullanılır.

1- \D : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir.
2- \d : Metinsel değerin ilgili yerinde 0 - 9 arasında tek bir sayı olacağı ifade edilir.

3- \W : Metinsel değerin ilgili yerinde alfanümerik olması gerektiği belirtilir. Alfanümerik karakterler : a - z   A - Z   0 - 9
4- \w: Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.

5- \S : Metinsel değerin ilgili yerinde boşluk karakterleri (tab/space) dışında herhangi bir karakterin olamayacağı belirtilir.
6- \s : Metinsel değerin ilgili yerinde sadece boşluk karakterinin olacağı ifade edilir.

 */

//örnek : 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
//^\d\s
string test2 = "9ldfldkjdddddddfvvvggbb";
Regex regex1 = new Regex(@"^9\d\S");
Match match1 = regex1.Match(test2);
Console.WriteLine(match1.Success);

#endregion

#region + Operatörü

//örnek : 9 ile başlayan, arada herhangi bir sayısal değerleri olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
//^9\d+\S

string test3 = "9a58643145d";
Regex regex2 = new Regex(@"^9\d+\S");
Match match2 = regex2.Match(test3);
Console.WriteLine(match2.Success);

#endregion

#region | (veya) Operatörü

//baş harfi a ya da b ya da c olan metinsel ifadeyi girelim.
//a|b|c
string test4 = "ahmet";
Regex regex3 = new Regex(@"a|b|c");
Match match3 = regex3.Match(test4);
Console.WriteLine(match3.Success);

#endregion

#region {n} Operatörü

//555-5555555
//\d{3}-\d{6} ==> \d\d\d-\d\d\d\d\d\d

string test5 = "555-5555555";
Regex regex4 = new Regex(@"\d{3}-\d{6}");
Match match4 = regex4.Match(test4);
Console.WriteLine(match4.Success);

#endregion

#region  ? Operatörü

//\d{3}B?A ==> 234BA, 543BA, 543A, 123BBA ==> yani diyorki sen 0-9 arasında 3 tane sayı kullan, A dan önce B yi en az bir defa kullan kullanmasan da olur. 123BBA olmaz çünkü B yi iki kere kullanmış.

string test6 = "234BA";
Regex regex5 = new Regex(@"\d{3}B?A");
Match match5 = regex5.Match(test6);
Console.WriteLine(match5.Success);

#endregion

#region . Operatörü

//\d{3}.A
string test7 = "123*A";
Regex regex6 = new Regex(@"\d{3}.A");
Match match6 = regex6.Match(test7);
Console.WriteLine(match6.Success);

#endregion

#region \b – \B Operatörleri

//d{3}dır\B ==> 3 sayı olacak dır ile başlayıp bitmeyecek. 123dır, dır123, 123dır2. sondaki hariç diğerleri olmaz. çünkü başında ya da sonunda dır olmayacak. sonuncuda ortada bulunuyor.
string test8 = "123dır";
Regex regex7 = new Regex(@"d{3}dır\B");
Match match7 = regex7.Match(test8);
Console.WriteLine(match7.Success);

#endregion

#region [n] Operatörleri

//\d{3}[A-E]
//(555) 555 55 55
//[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

string test9 = "(555) 555 55 55";
Regex regex8 = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
Match match8 = regex8.Match(test9);
Console.WriteLine(match8.Success);

#endregion

#region Match Sınıfı Özellikleri

Console.WriteLine($"Success : {match8.Success}");
Console.WriteLine($"Value : {match8.Value}");
Console.WriteLine($"Index : {match8.Index}");
Console.WriteLine($"Length : {match8.Length}");

#endregion

#endregion