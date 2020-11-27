using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Columns: ");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("Enter matrix({0},{1}): ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int counter1 = 0;

            for (int i = 0; i < row; i++)
            {
                int STOP = 0;
                for (int j = col - 1; j >= 1; j--)
                {
                    if (matrix[i, j] == matrix[i, j - 1])
                    {
                        STOP = 1;

                        break;

                    }
                }
                if (STOP == 1)
                    continue;
                else counter1++;

            }

            int counter2 = 0;
            for (int j = 0; j < col; j++)
            {
                int STOP2 = 0;
                for (int i = row - 1; i >= 1; i--)
                {
                    if (matrix[i, j] == matrix[i - 1, j])
                    {
                        STOP2 = 1;
                        break;
                    }
                }
                if (STOP2 == 1)
                    continue;
                else counter2++;
            }

            Console.WriteLine("Количество строк, все элементы которых различны: " + counter1);
            Console.WriteLine("Количество рядков, все элементы которых различны: " + counter2);
            Console.ReadKey();
        }

    }
}