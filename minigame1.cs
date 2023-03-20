var rand = new Random();
int num = rand.Next(100);
/*
這行打開可以看見隨機什麼數字
System.Console.WriteLine(num);
*/
int rnum;
int time = 5;
do
{
    System.Console.WriteLine("系統已經決定好了一個數字，你可以開始猜了（*整數100以內）");
    rnum = System.Convert.ToInt32(System.Console.ReadLine());time--;
    if(time != 0)
    {
        if(rnum < num)
        {
            System.Console.WriteLine("大一點");
        }
        else if(rnum > num)
        {
            System.Console.WriteLine("小一點");
        }
    }
    else
    {
        System.Console.WriteLine("次數用完了，系統獲勝");
    }
}
while (rnum != num && time != 0);
if(rnum == num)
{
    System.Console.WriteLine("恭喜猜對了");
}
