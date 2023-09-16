void ArrayIntOutPut(int[] array) // функция для вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Random rnd = new Random();

Console.WriteLine("Видите размерность одномерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
}

ArrayIntOutPut(array); 

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine($"->({sum})");