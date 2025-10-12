using Tyuiu.BerezovskiyAS.Sprint1.Task4.V18.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнил: Березовский А. С. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #18                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
    Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    double x, y;
    Console.WriteLine("Введите X:");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите Y:");
    y = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine($"{ds.Calculate(x, y)}");
}