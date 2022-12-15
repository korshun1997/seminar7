// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
Console.WriteLine("Введите число m"); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n");  
int n = Convert.ToInt32(Console.ReadLine()); 
int MinValue = 0; 
int MaxValue = 9; 
int [,] array  = new int [m, n]; 
Random rnd = new Random(); 
for (int i = 0; i < m; i++) 
{ 
    for (int j = 0; j < n; j++) 
    { 
       array[i,j] = rnd.Next(MinValue, MaxValue);  
    } 
} 
Console.WriteLine("Введите число m1"); 
int m1 = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите число n1"); 
int n1 = Convert.ToInt32(Console.ReadLine()); 
for (int i = 0; i < m; i++) 
{ 
    for (int j = 0; j < n; j++) 
    { 
        Console.Write($"{array [i,j]} "); 
    } 
    Console.WriteLine(); 
} 
if (m1>m || n1>n) 
{ 
    Console.WriteLine("такого элемента нет"); 
} 
else 
{ 
    Console.WriteLine($"{array[m1, n1]}"); 
}