
#region Hata Kontrol Mekanizmaları     

#region Çalışma Zamanı Hata Durumları - Örnek

//Console.Write("Lütfen birinci sayıyı giriniz : ");
//int sayi1 = int.Parse(Console.ReadLine());

//Console.Write("Lütfen ikinci sayıyı giriniz : ");
//int sayi2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Toplam : {sayi1 + sayi2}");

#endregion

#region try-catch yapılanması

//Console.Write("Lütfen birinci sayıyı giriniz : ");//try içine yazılması gereksiz, mal

//try
//{
//   // olası çalışma zamanı hatalarını verebilecek kodlar buraya yazılır.
//    int sayi1 = int.Parse(Console.ReadLine());

//    Console.Write("Lütfen ikinci sayıyı giriniz : ");
//    int sayi2 = int.Parse(Console.ReadLine());

//    Console.WriteLine($"Toplam : {sayi1 + sayi2}");

//}
//catch (Exception)
//{
//    //try içerisinde olası hata söz konusuysa kodun akışı orada kesilecek ve akış catch bloğundan devam edecektir.
//    Console.Beep();
//    Console.Beep();
//    Console.Beep();
//    Console.Beep();
//    Console.Beep();
//    Console.WriteLine("Lütfen doğru bir ifade giriniz!");
//}

#endregion

#region hata parametreleri

//int s1 = 0, s2 = 10;

//int a = s2 / s1;//dividedbyzero hatası fırlatılır.

//try
//{
//    int s1 = 0, s2 = 10;

//    int a = s2 / s1;
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Mesaj : {ex.Message}");
//}

#endregion

#region Exception Dışında Farklı Bir Tür ile Hata Yakalama

//try
//{
//	int s1 = 0, s2 = 10;
//	int a = s2 / s1;
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Mesaj : {ex.Message}");
//}

#endregion

#region Birden Fazla Catch Durumu

//try
//{
//	int s1 = 0, s2 = 10;
//	int a = s2 / s1;

//	int.Parse("kdnfbv"); 
//}
//catch (DivideByZeroException ex)//dividebyzeroexception hatası alındığında bu hatayı karşılayacak olan catch haline getirildi
//{

//}

//catch (FormatException)//formatexception hatasını karşılayacak olan catch tanmlanmış oldu.
//{

//}

#endregion

#region finally bloğu

//try
//{
//    Console.WriteLine("try");
//}
//catch
//{
//    Console.WriteLine("catch");
//}
//finally
//{
//    Console.WriteLine("finally");
//}


#endregion

#region when yapısı ile hata filtreleme (C# 6.0)

//try
//{
//	int s1 = 0, s2 = 10;
//	int a = s2 / s1;
//}
//catch (DivideByZeroException ex) when(3 == 3)
//{
//    Console.WriteLine($"Mesaj : {ex.Message}");
//}

#endregion

#region mantıksal hatalar

//Console.WriteLine(2 * 6);

//bool medeniHal = true;

//if (!medeniHal)
//{
//    Console.WriteLine("Hediye gönder!");
//}

//else
//{
//    Console.WriteLine("Hediye gönderme!");
//}

//int i = 20, i2 = 10;
//Console.WriteLine(i + i2);

#endregion



#endregion