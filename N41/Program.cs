//  Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введи числа: ");
int[] number = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);;
int up = 0;


for (int i = 0; i < number.Length; i++)
{
    if (number[i] > 0)
    {
        up++;
    }
}
 
Console.WriteLine($"Чисел больше нуля: {up}");
