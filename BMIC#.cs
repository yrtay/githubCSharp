System.Console.WriteLine("歡迎測試你的BMI：\n");

System.Console.WriteLine("請輸入你的體重：");
double weight = System.Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("請輸入你的身高：");
double heightcm = System.Convert.ToDouble(System.Console.ReadLine());
double heightm = heightcm / 100;

double BMI = weight / (Math.Pow(heightm, 2));

System.Console.WriteLine("你的BMI值為" + BMI);