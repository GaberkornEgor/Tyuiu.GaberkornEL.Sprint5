using Tyuiu.GaberkornEL.Sprint5.Task3.V4.Lib;

namespace Tyuiu.GaberkornEL.Sprint5.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #5                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл           *");
            Console.WriteLine("* Задание #3                                                    *");
            Console.WriteLine("* Вариант #4                                                    *");
            Console.WriteLine("* Выполнил : Габеркорн Егор Леонидович | АСОиУб-25-1            *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Дано выражение. Вычислить его значение при x = 3. Результат   *");
            Console.WriteLine("* сохранить в бинарный файл. Результат округлить до 3 знаков    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*         x + 1                                                 *");
            Console.WriteLine("* y = ln -------                                                *");
            Console.WriteLine("*         x + 2                                                 *");
            Console.WriteLine("*****************************************************************");

            int x = 3;

            var res = ds.SaveToFileTextData(x);

            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(x)} ");
            Console.WriteLine($"* Создан!                                                      *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();

        }
    }
}