void ArrayDoubleOutPut(double[] array) // функция для вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

//функция для сортировки массива пузерковым способом
void ArraySortedDouble(double[] array) 
{
    double num = 0.0;
    for(int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                num = array[j];
                array[j] = array[i];
                array[i] = num;
            }
        }
    }
}

Random rnd = new Random();

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double [n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.NextDouble();
}
ArraySortedDouble(array);
ArrayDoubleOutPut(array);
Console.WriteLine($"{array[array.Length - 1] - array[0]}");


