using System;
using System.Xml.Schema;
using calculator;

Console.WriteLine("請輸入兩個數字:");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());

Calculate add1 = new Calculate();
add1.add(a,b);
add1.sub(a,b);
add1.mul(a,b);
add1.div(a,b);
