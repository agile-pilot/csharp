Main();

void Main()
{
    bool isWorking = true;
    while (isWorking)
    {
        Console.Write("Input task number: ");
        switch (Console.ReadLine())
        {
            case "41": Task41(); break;
            case "43": Task43(); break;
            case "exit": isWorking = false; break;
        }
        Console.WriteLine();
    }
}

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
void Task43()
{
}

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void Task41()
{
}

int ReadInt(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return int.Parse(Console.ReadLine());
}


