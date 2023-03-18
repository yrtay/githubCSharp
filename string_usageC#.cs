using System.Security.Cryptography.X509Certificates;

System.Console.WriteLine("This is \nnew line");
string x = "Abb";
System.Console.WriteLine("we call him \""+x+"\"");
System.Console.WriteLine(x.Length);

//變大寫小寫
System.Console.WriteLine(x.ToLower());
System.Console.WriteLine(x.ToUpper());

//有沒有在字串裡面
System.Console.WriteLine(x.Contains("ab"));
System.Console.WriteLine(x.Contains("Ab"));
System.Console.WriteLine(x.Contains("bb"));

string y = "AbcDefGhih";
//          0123456789
System.Console.WriteLine(y[1]);
System.Console.WriteLine(y[6]);

//找位置
System.Console.WriteLine(y.IndexOf("h"));
System.Console.WriteLine(y.IndexOf("hih"));
System.Console.WriteLine(y.IndexOf("z"));

//切割
System.Console.WriteLine(y.Substring(3));
//3後面四位
System.Console.WriteLine(y.Substring(3,4));
