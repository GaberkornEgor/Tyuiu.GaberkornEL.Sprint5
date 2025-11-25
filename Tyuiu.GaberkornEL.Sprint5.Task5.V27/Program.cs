using Tyuiu.GaberkornEL.Sprint5.Task5.V27.Lib;
namespace Tyuiu.GaberkornEL.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #5                                                             *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                        *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Варинат #27                                                           *");
            Console.WriteLine("* Выполнил: Габеркорн Егор Леонидович | АСОиУб-25-1                     *");
            Console.WriteLine("*************************************************************************");


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            string path = @"C:\Users\Ymir\Downloads\Sprint5Task5\InPutDataFileTask5V27.txt";


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("среднее значение файла = " + ds.LoadFromDataFile(path));
        }
    }
}