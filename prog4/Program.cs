/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("ВВедите количество чисел:\t");

int elements = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elements];
Console.Write($"ВВедите  числа равные :\t{elements}\n");

for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int c in array) {
   if(c %2 ==0)
    Console.WriteLine($"\nЧетное \nЧисло:    {c}");

else Console.WriteLine($"\nНечетное \nЧисло:     {c}");

}