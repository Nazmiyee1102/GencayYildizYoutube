using Microsoft.Extensions.Primitives;
using System.Text;

#region inceleme

int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int[] sayilar2 = sayilar[2..7];//[indis numarası, sıra numarası]

sayilar2[0] *= 10;
sayilar2[1] *= 10;
sayilar2[2] *= 10;
sayilar2[3] *= 10;
sayilar2[4] *= 10;


foreach (var item in sayilar2)
{
    Console.WriteLine(item);
}

#endregion

#region ArraySegment

#region ArraySegment İle Dizinin Belli Bir Alanını Referans Etmek

ArraySegment<int> segment1 = new ArraySegment<int>(sayilar);//dizinin tüm elemanlarını temsil eder.
ArraySegment<int> segment2 = new ArraySegment<int>(sayilar[2..7]);
ArraySegment<int> segment3 = new ArraySegment<int>(sayilar, 2, 5);

foreach (var item in segment2)
{
    Console.WriteLine(item);
}

segment1[0] *= 10;
segment1[1] *= 10;
segment1[2] *= 10;
segment1[3] *= 10;
segment1[4] *= 10;


#endregion

#region ArraySegment Slicing(Dilimleme) Özelliği

ArraySegment<int> s = new ArraySegment<int>(sayilar);
ArraySegment<int> s1 = s.Slice(0, 3);
ArraySegment<int> s2 = s.Slice(4, 7);

#endregion

#endregion

#region StringSegment 

string text = "Ölüme gidelim dedin de mazot mu yok dedik.";

#region StringSegment İle Dizinin Belli Bir Alanını Referans Etmek

StringSegment stringSegment = new StringSegment(text);
StringSegment stringSegment1 = new StringSegment(text, 2, 5);

#endregion

#endregion

#region StringBuilder

string isim = "Nazmiye", soyisim = "KURBAN";
StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(isim);
stringBuilder.Append(" ");
stringBuilder.Append(soyisim);
Console.WriteLine(stringBuilder.ToString());

#endregion

#region Span, ReadOnlySpan, Memory ve ReadOnlyMemory Türleri Nedir? Nasıl Kullanılır?

#region span

Span<int> span = new Span<int>(sayilar);
Span<int> span2 = new Span<int>(sayilar, 3, 5);

Span<int> span3 = sayilar.AsSpan();
Span<int> span4 = sayilar.AsSpan(3, 5);

string t = "Sen kalbimde batan güneş, ben yollarda çilekeş...";
ReadOnlySpan<char> readOnlySpan = t.AsSpan();
#endregion

#endregion