/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
Console.Write("ВВедите количество чисел:\t");
int elements = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elements];
Console.Write($"ВВедите  числа равные :\t{elements}\n");
     
    for (int x = 0; x < array.Length; x++)       
    if (x%2==0)        
    Console.WriteLine(string.Join(separator,i));    
    Console.WriteLine(x);*/

    Console.WriteLine("Введите длину: ");
int n = Convert.ToInt32(Console.ReadLine());
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0) {
Console.Write($"{i},");
    }