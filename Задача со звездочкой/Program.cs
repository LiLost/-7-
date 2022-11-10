// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994



void Rome(string num)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (num[i] == 'I') array[i] = 1;
        if (num[i] == 'V') array[i] = 5;
        if (num[i] == 'X') array[i] = 10;
        if (num[i] == 'L') array[i] = 50;
        if (num[i] == 'C') array[i] = 100;
        if (num[i] == 'D') array[i] = 500;
        if (num[i] == 'M') array[i] = 1000;
    }
}

Console.Clear();
Console.Write("Введите римское число: ");
string rim = int.Parse(Console.ReadLine()!);
Rome(rim);
