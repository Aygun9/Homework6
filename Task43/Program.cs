//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Crosspoint(double[] array, out double x, out double y)
{
    x = 0;
    y = 0;
    for (int i = 0; i < array.Length; i++)
    {
        x = ((array[2] - array[0]) / (array[1] - array[3]));
        y = (array[1] * x + array[0]);
    }
}

Console.WriteLine("Insert b1, k1, b2, k2");
double[] array = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
Crosspoint(array, out double x, out double y);
Console.WriteLine("[" + x + ";" + y + "]");