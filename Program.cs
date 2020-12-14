using System;

namespace twoDimensionalArrayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Каква ще бъде размерността на масива?");
            Console.Write("Редове: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Колони: ");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("За коя стойност ще се претърсва масива?");
            Console.Write("Стойност(число): ");
            double lookedValue = double.Parse(Console.ReadLine());

            double[,] arraye = new double[rows,columns];

            Console.WriteLine("Въведете стойностите.");
            arraye = arrayeCompoRead(rows, columns);

            Console.WriteLine("Tук са изобразени елементите на масива в матричен вид:");
            Console.WriteLine(arrayeCompWrite(arraye, rows, columns, lookedValue));
            }

            catch{
                Console.WriteLine("Имате грешка при въвеждането на данните. Опитайте пак. :)");
            }

        }

        static double[,] arrayeCompoRead(int rows, int cols)
        {
            double[,] arraye = new double[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int stabl = 0; stabl < cols; stabl++)
                {
                    arraye[row, stabl] = double.Parse(Console.ReadLine());
                }
            }
            return arraye;
        }

        static string arrayeCompWrite(double[,] arraye,int rowsCount, int stablesCount, double lookedUpOne)
        {
            string oute = "";
            string coordinates = $"Намерена е стойността {lookedUpOne} на координати: ";
            int lookedUpOneCount = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < stablesCount; j++)
                {
                    oute += arraye[i,j] + " ";
                    if (arraye[i,j] == lookedUpOne)
                    {
                        lookedUpOneCount++;
                        //Залагат се +1 за да съответсва на правилото за ред и стълб, които се броят от едно.
                        coordinates += $"({i+1},{j+1}) ";
                    }
                }
                oute += Environment.NewLine;
            }
            if (lookedUpOneCount != 0)
            {
                oute += coordinates;
            }
            return oute;
        }
    }
}
