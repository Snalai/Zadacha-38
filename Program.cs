// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void fun(int b)
{
    double[] mas = new double[b];
    double r = new Random().Next(0, 10000);
    r = r / 100;
    mas[0] = r;
    if (b == 1)
    {
        Console.WriteLine($"Нет разницы, {mas[0]} равно само себе.");
    }
    else if (b > 1)
    {

        double min = mas[0];
        double max = mas.Length - 1;
        for (int i = 0; i < mas.Length; i++)
        {
            r = new Random().Next(0, 10000);
            r = r / 100;
            mas[i] = r;
            if (mas[i] >= max)
            {
                max = mas[i];
            }
            else if (mas[i] <= min)
            {
                min = mas[i];
            }
            Console.WriteLine(mas[i]);
        }
        double ras = max - min;
        Console.WriteLine($"Мин: {min}, Макс: {max}");
        Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {ras}");
    }
    else
    {
        Console.Write("Некорректная ширина массива");
    }
}
Console.Write("Выберите ширину массива: ");
int w = Convert.ToInt32(Console.ReadLine());
fun(w);



