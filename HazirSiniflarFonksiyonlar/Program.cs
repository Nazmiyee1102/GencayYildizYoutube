
#region Hazır fonksiyon ve sınıflar

#region Matematik(Math) Sınıfı – Fonksiyonları

#region Abs Fonksiyonu

Console.WriteLine(Math.Abs(-5));

#endregion

#region Ceiling Fonksiyonu

Console.WriteLine(Math.Ceiling(3.14));

#endregion

#region  Floor Fonksiyonu

Console.WriteLine(Math.Floor(3.14));

#endregion

#region Round Fonksiyonu

Console.WriteLine(Math.Round(3.4));
Console.WriteLine(Math.Round(3.5));
Console.WriteLine(Math.Round(3.6));

#endregion

#region  Pow Fonksiyonu

Console.WriteLine(Math.Pow(5, 2));

#endregion

#region Sqrt Fonksiyonu

Console.WriteLine(Math.Sqrt(4));
Console.WriteLine(Math.Sqrt(16));
Console.WriteLine(Math.Sqrt(1444));

#endregion

#region Truncate Fonksiyonu

Console.WriteLine(Math.Truncate(3.14));

#endregion



#endregion

#region Tarih - Zaman (DateTime) Fonksiyonları

#region  Now Özelliği

Console.WriteLine(DateTime.Now);

#endregion

#region Today

Console.WriteLine(DateTime.Today);

#endregion

#region Compare

DateTime tarih1 = new DateTime(2024, 11, 11);
DateTime tarih2 = new DateTime(2024, 11, 15);
Console.WriteLine(DateTime.Compare(tarih1, tarih2));

#endregion

#region Tarihsel Zamana Saat, Gün, Ay, Yıl Ekleyerek Sonucu Hesaplamak

#region add fonksiyonları

Console.WriteLine(DateTime.Now.AddYears(999));
Console.WriteLine(DateTime.Now.AddSeconds(999));
Console.WriteLine(DateTime.Now.AddDays(999));
Console.WriteLine(DateTime.Now.AddHours(999));
Console.WriteLine(DateTime.Now.AddMonths(999));

#endregion

#endregion

#region timespan

DateTime t1 = DateTime.Now;
DateTime t2 = new DateTime(2000, 1, 1);

TimeSpan timeSpan =  t1 - t2;
Console.WriteLine(timeSpan.Days);

#endregion

#endregion

#region Random Sınıfı

#region next fonksiyonu

Random random = new Random();
Console.WriteLine(random.Next(0, 100));


#endregion

#region nextdouble fonksiyonu

Console.WriteLine(random.NextDouble());

#endregion

#endregion

#endregion