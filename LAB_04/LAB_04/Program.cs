using System;

namespace LAB_04
{
    class Program
    {

        static void MATH_1(double[]progression)
        {
            double q = progression[1] / progression[0];

            for (int i = 2; i < progression.Length; i++)
            {
                if (progression[i]/ progression[i - 1] == q)
                {
                    if (i + 1 == progression.Length)
                    {
                        Console.WriteLine("Это геометрическая прогрессия!!!");
                        break;
                    }

                    continue;
                }

                else
                {
                    Console.WriteLine("Это не геометрическая прогрессия!!!");
                    break;
                }

            }
        }


        static void MATH(double []progression)
        {

            double d = progression[1] - progression[0];

            for (int i = 2; i < progression.Length; i++)
            {
                if (progression[i] - progression[i - 1] == d)
                {
                    if (i + 1 == progression.Length)
                    {
                        Console.WriteLine("Это арифметическая прогрессия!!!");
                        break;
                    }

                    continue;
                }

                else
                {
                    Console.WriteLine("Это не арифметическая прогрессия!!!");
                    MATH_1(progression);
                    break;
                }
            }

        }



        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            double[] progression = new double[num];

            for(int i=0;i< num; i++)
            {
                progression[i] = int.Parse(Console.ReadLine());
                
            }
            MATH(progression);
        }
    }
}
