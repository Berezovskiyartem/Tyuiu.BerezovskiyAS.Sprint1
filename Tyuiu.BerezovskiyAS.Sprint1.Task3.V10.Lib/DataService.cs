using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BerezovskiyAS.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rubles = (int)number; // Целая часть - рубли
            int kopecks = (int)((number - rubles) * 100); // Дробная часть - копейки

            return $"{number} руб. - это {rubles} руб. {kopecks} коп.";
        }
    }
}
