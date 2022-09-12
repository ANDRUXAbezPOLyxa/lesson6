// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("введите числа через пробел: ");
int [] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int b = 0;
for ( int i =0; i < a.Length; i++)
{
    if (a[i]>0)
    {
        b++;
    }
}
Console.WriteLine("элементов > 0 " + "=> " + b);