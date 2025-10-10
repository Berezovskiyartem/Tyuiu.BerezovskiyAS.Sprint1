using Tyuiu.BerezovskiyAS.Sprint1.Task2.V28.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнил: Березовский А. C. | ПИНб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #28                                                             *");
    Console.WriteLine("* Выполнил: Березовский Артём Станиславович | ПИНб-25-1                   *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Известна температура в градусах Цельсия.                                *");
    Console.WriteLine("* Перевести температуру в градусы Кельвина.                               *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int x;

    Console.WriteLine("Введите значение X:");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("* Температура в градусах Цельсия                                          *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Температура в градусах Кельвина = " + ds.ConvertCelsiusToKelvin(x));

    Console.ReadLine();
}
