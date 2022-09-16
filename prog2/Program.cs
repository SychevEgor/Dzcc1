
Console.WriteLine("Введите числа"); 
int[] array = new int [3];
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int max = array[0];
for (int i = 0;i<array.Length;i++) 
{
        if (array[i] > max) 
        max = array[i];
}
Console.WriteLine($"максимальное значение = {max}"); 