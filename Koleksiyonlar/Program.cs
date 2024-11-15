using System.Collections;

#region ArrayList

#region ArrayList Koleksiyonu Tanımlama

//dizi
int[] yas = new int[5];

ArrayList _yas = new ArrayList();

#endregion

#region ArrayList Tanımlanmış Koleksiyona Değer Atama

for (int i = 0; i < 5; i++)
{
    //dizi
yas[i] = i + 10;

//koleksiyon
_yas.Add(i + 10);
}

#endregion

#region ArrayList Tanımlanmış Koleksiyondan Değer Okuma

//dizi
Console.WriteLine(yas[2]);

//koleksiyon
Console.WriteLine(_yas[2]);

#endregion

#region ArrayList ArrayList Boxing – Unboxing Durumlarından Dolayı Sınırlılıklar

int toplam = 0;
for (int i = 0; i < _yas.Count; i++)
{
    toplam += (int) _yas[i];
}


#endregion

#region ArrayList Collection Initializers(Koleksiyon İlklendirici)

ArrayList arrayList = new ArrayList() 
{
    "Ahmet",
    123,
    'a',
    true
};

#endregion

#endregion