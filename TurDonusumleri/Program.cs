#region Metinsel İfadelerin Diğer İfadelere Dönüştürülmesi

#region Örnek 1

//string x = "123";
//Console.WriteLine(x);
////short x2 = short.Parse(x);
//Console.WriteLine(short.Parse(x) * 5);

#endregion

#region Örnek 2

//string x = "25";
//Console.WriteLine(Convert.ToInt32(x) + 5);



#endregion

#region Örnek 3

//string x = "3,14";

//Console.WriteLine(Convert.ToDouble(x));

#endregion

#endregion

#region Diğer İfadelerin Metinsel İfadelere Dönüştürülmesi

//int a = 25;
//string a2 = Convert.ToString(a);

//ToString Fonksiyonu

//float f = 35f;
//string f2 = f.ToString();

#endregion

#region Bilinçsiz Tür Dönüşümü

#region Örnek 1
//int a = 3000;
//float f = a;//tür dönüşümü söz konusu. Bilinçsiz tür dönüşümü.
#endregion

#region Örnek 2

//short x = 123;
//long y = x;

#endregion

#endregion

#region Bilinçli Tür Dönüşümü

//checked
//{
//    int x = 500;
//    byte y = (byte)x;
//    Console.WriteLine(y);
//}

//unchecked
//{
//    int x = 500;
//    byte y = (byte)x;
//    Console.WriteLine(y);
//}



#endregion

#region bool-int tür dönüşümü

//bool b = true;
//int i = Convert.ToInt32(b);
//decimal bi = Convert.ToDecimal(b);
//Console.WriteLine(i);

#endregion

#region sayısal türlerin bool türüne dönüşmesi

//int i = 1;
//bool b = Convert.ToBoolean(i);
//Console.WriteLine(b);

#endregion

#region char-int tür dönüşümü - ascii

char a = 'a';
Console.WriteLine((int)a);

#endregion

Console.Read();
