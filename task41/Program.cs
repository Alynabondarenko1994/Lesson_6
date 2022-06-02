/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


string[] Array(string message)
{
    Console.WriteLine(message);
    string[] ar = Console.ReadLine().Replace('.', ',').Split(" ");
    return ar;
}

void PositiveElement(string[] numer)
{

    int result = 0;
    for (int i = 0; i < numer.Length; i++)
    {
        if (double.TryParse(numer[i], out double positiv) && positiv > 0)
            result += 1;
    }
    Console.WriteLine($"Количество введенных чисел больше 0: {result}");

}


string[] output = Array("Введите числа через пробел:");
PositiveElement(output);