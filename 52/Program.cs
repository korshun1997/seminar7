Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n"); 
int n = Convert.ToInt32(Console.ReadLine());
int MinValue = 0;
int MaxValue = 9;
int [,] array  = new int [m, n];
Random rnd = new Random();
double [] Avg_array = new double[n];
for (int i = 0; i < n; i++)
{
   Avg_array[i] = 0;
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array[i,j] = rnd.Next(MinValue, MaxValue); 
    }
}
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
       Avg_array[i] = Avg_array[i] + array[j, i]; 
    }
}
for (int i = 0; i < n; i++)
    {
       Avg_array[i] = Avg_array[i]/m; 
    }
for (int i = 0; i < n; i++)
    {
       Console.WriteLine($"{Avg_array[i]} ");
    }