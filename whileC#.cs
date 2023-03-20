int num1 = 1;
//直接判斷
while (num1 <= 10)
{
    System.Console.WriteLine(num1);
    num1++;
}

int  num2 = 9;
//先執行，再判斷
do
{
    System.Console.WriteLine(num2);
    num2--;
}
while (num2 >= 1);