using Tyuiu.BerezovskiyAS.Sprint1.Task1.V11.Lib;

{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнил: Березовский А. C. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Организация ввода | вывода в консольных приложениях               *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #11                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая вычисляет выражение 5*x/(6*y)               *");
    Console.WriteLine("* и печатает результат на экране.                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    double x, y;

    Console.WriteLine("Введите значение X:");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение Y:");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate(x, y));

    Console.ReadLine();








}