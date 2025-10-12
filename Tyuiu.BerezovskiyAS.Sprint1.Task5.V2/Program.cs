using Tyuiu.BerezovskiyAS.Sprint1.Task5.V2.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнил: Березовский А. С. | ПИНб-25-1";

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #2                                                              *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("* Дано значение температуры в градусах Фаренгейта. Определить значение    *");
    Console.WriteLine("* этой же температуры в градусах Цельсия. Ответ привести к целому с       *");
    Console.WriteLine("* помощью класса Convert.                                                 *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.Write("Введите температуру в градусах Фаренгейта: ");
    double temp = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine($"Температура в градусах Цельсия: {ds.FahrenheitToСelsius(temp)} °C");
    Console.ReadLine();
}