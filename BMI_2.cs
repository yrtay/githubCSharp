System.Console.WriteLine("歡迎測試你的BMI：\n");

System.Console.WriteLine("請輸入你的體重：");
double weight = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("請輸入你的身高：");
double heightcm = System.Convert.ToDouble(System.Console.ReadLine());
double heightm = heightcm / 100;

double BMI = weight / (Math.Pow(heightm, 2));

System.Console.WriteLine("你的BMI值為" + BMI);

if(BMI >= 35)
{
    System.Console.WriteLine("你的體重重度肥胖，請立刻減肥");
}
else if(BMI >= 30)
{
    System.Console.WriteLine("你的體重中度肥胖，請及時減肥");
}
else if (BMI >= 27)
{
    System.Console.WriteLine("你的體重輕度肥胖，請注意減肥");
}
else if (BMI >= 24)
{
    System.Console.WriteLine("你的體重過重，請減肥");
}
else if (BMI >= 18.5)
{
    System.Console.WriteLine("你的體重在正常範圍，請繼續保持");
}
else
{
    System.Console.WriteLine("你的體重過輕，請注意飲食均衡");
}
