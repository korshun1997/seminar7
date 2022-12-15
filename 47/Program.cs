// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите числа m и n");
int m = Convert.ToInt32(Console.ReadLine()); 
int n = Convert.ToInt32(Console.ReadLine());
double[,] array  = new double [m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array[i,j] = rnd.NextDouble(); 
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j<n; j++)
        
        {
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
}
