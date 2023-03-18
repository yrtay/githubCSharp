int x = 10;
int y = -20;
int z = 30;

System.Console.WriteLine(1 * 2 + 3);
System.Console.WriteLine(1 * (2 + 3));
System.Console.WriteLine(x * y + z);
System.Console.WriteLine(x * (y + z));

//絕對值
System.Console.WriteLine(Math.Abs(y));

//次方
//(x的三次方)
System.Console.WriteLine(Math.Pow(x,3));

//開根號
System.Console.WriteLine(Math.Sqrt(z));

//找最小
System.Console.WriteLine(Math.Min(x,y));

//找最大
System.Console.WriteLine(Math.Max(x, y));

//注意小數點
int w = 7 / 3;
double v = 7 / 3.0;
System.Console.WriteLine(w);
System.Console.WriteLine(v);

//無條件進位
System.Console.WriteLine(Math.Ceiling(v));
//無條件捨棄
System.Console.WriteLine(Math.Floor(v));
//只要二位小數
System.Console.WriteLine(Math.Round(v,2));

