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
    array[i] = rnd.Next(100, 1000);
}

ArrayIntOutPut(array); 

int count = 0; // счетчик 
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных элементов -> {count}");


