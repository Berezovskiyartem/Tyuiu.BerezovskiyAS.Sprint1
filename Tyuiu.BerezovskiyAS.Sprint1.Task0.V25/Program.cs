using Tyuiu.BerezovskiyAS.Sprint1.Task0.V25.Lib;

{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнил: Березовский А. C. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #25                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая вычисляет выражение (30 / 6 - 4) * 3        *");
    Console.WriteLine("* и печатает результат на экране.                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* (30 / 6 - 4) * 3                                                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate());
    Console.ReadLine();
}


