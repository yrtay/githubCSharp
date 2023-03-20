var rand = new Random();
int num = rand.Next(100);
/*
這行打開可以看見隨機什麼數字
System.Console.WriteLine(num);
*/
int rnum;
do
{
    System.Console.WriteLine("系統已經決定好了一個數字，你可以開始猜了（*整數100以內）");
    rnum = System.Convert.ToInt32(System.Console.ReadLine());
    if(rnum < num)
    {
        System.Console.WriteLine("大一點");
    }
    else if(rnum > num)
    {
        System.Console.WriteLine("小一點");
    }
}
while (rnum != num);
if(rnum == num)
{
    System.Console.WriteLine("恭喜猜對了");
}
