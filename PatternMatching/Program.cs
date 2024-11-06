#region type pattern

//object x = "Nazmiye";

//if (x is string a)
//{
//   // string _x = (string)x; yenilikle beraber buna gerek yok. if şartının içinde string den sonra değişken tanımlanabilir.
//    Console.WriteLine($"");

//}

//else if(x is int b)
//{

//}

#endregion

#region constant pattern

//object x = 123;
//int a = 123;
//Console.WriteLine(a is 123);//constant pattern
//Console.WriteLine(a is int);//normal is 
//if (x is 123) // değer kontrolü
//{

//}

//if (x is int) // tür kontrolü
//{

//}

#endregion

#region var pattern

//object x = "Türkiye";
//if (x is var a)
//{
//    Console.WriteLine(a);
//}

#endregion

#region recursive pattern



#endregion

#region kritik1

//object x = "hbhgnnkkk";
//if (x is string a)//type pattern
//{
    
//}

//if (x is var b)//var pattern
//{
    
//}

//bool result = x is string o1;
//Console.WriteLine(o1);
//bool result2 = x is var o2;
//Console.WriteLine(o2);



#endregion
