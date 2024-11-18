//int a = 5;
//ref int b = ref a;

//int y = 10;
//X(y);bu değeri yazdırır. yani 10 yazar.
////X(ref y);//bu referansı yazdırır. yani 25 yazar.
////Console.WriteLine(y);

#region ÖRNEK

//void X(ref int a)
//{
//    a = 25;
//}

#endregion

#region ref returns

//int a = 5;
//int b = X(ref a);
//Console.WriteLine(a);
//Console.WriteLine(b);

//ref int X(ref int y)
//{
//    y = 25;
//    return ref y;
//}

#endregion

#region out

using System.Globalization;

int a = X(out int _b,133,out string _d);

int X(out int b, int c, out string d)
{
    b = 25;
    d = "35";
    return 0;
}

#region kullanım 2

int a2 = X(out int b, 4434, out string d);
Console.WriteLine(_b);
Console.WriteLine(_d);

#endregion

#endregion

#region tryparse

string s = "wdöfm584";
int.TryParse(s, out int r);

//int r = int.Parse(s);

#endregion