//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void QofPos(int[] arr, out int N)   // QofPos is Quantity of POsitive Numbers
{
    N = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            N ++;
        }
    }
    
}

Console.WriteLine("Insert numbers");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
QofPos(arr , out int N );
Console.WriteLine($"Quantity of positive numbers is "+ N);


