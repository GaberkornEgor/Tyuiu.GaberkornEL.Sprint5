using Tyuiu.GaberkornEL.Sprint5.Task2.V7.Lib;
namespace Tyuiu.GaberkornEL.Sprint5.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Габеркорн Егор Леонидович | АСОиУб-25-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Габеркорн Егор Леонидович  | АСОиУб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3] { { 9,2,8,},
                                             { 7,1,2},
                                             { 5,5,1 } };
            int r = matrix.GetUpperBound(0) + 1;
            int c = matrix.Length / r;
            Console.WriteLine("Массив");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine(" Создан!");
            Console.ReadKey();
        }
    }
}