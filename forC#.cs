/*
for (int i = 0; i < 10; i++)
{
    System.Console.WriteLine(i);
}
*/

/*
int j = 20;
for (int i = j-4 ; i < j+1; i++){
    System.Console.WriteLine(i);
}
*/

int[,] nums = { { 1, 2, 3, 1}, 
                { 4, 5, 6, 4}, 
                { 7, 8, 9, 7},
                { 10, 11, 12, 10},
};

for (int i = 0; i < nums.Length ; i++)
{
    for(int j  = 0; j < Math.Sqrt(nums.Length); j++)
    {
        System.Console.WriteLine(nums[i,j] + " ");
    }
}
