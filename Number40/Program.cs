Console.WriteLine("Введите три целых числа")
// можно было сделать через строку но мне было лень запариваться поэтому я сделал так
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
double p = 0; // полупириметр
double P = 0 // пириметр
double S = 0; // площадь
if ((a+b>c) && (b+c>a) && (a+c>b))
{
    Console.WriteLine("Три целых числа являются сторонами триугольника");
    P = a + b + c; // расчет пириметра
    Console.WriteLine($"Пириметр P: {P}");
    p = (P / 2); // расчет полупириметра 
    S = Sqrt(p * (p - a) * (p - b) * (p - c)); // рачсет площади
    Console.WriteLine($"Площадь S: {S}");
    
}
else 
{
    Console.WriteLine("Не являются ");
}