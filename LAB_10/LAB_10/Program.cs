using System;

namespace Lab10
{
    public static class Extensions
    {
        public static void PrintReversed(this double Num)
        {
            string str = Num.ToString();
            int Rotation = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == '.' || str[i] == ',')
                {
                    Rotation = i;
                    break;
                }
            }
            for (int i = Rotation - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.Write(str[Rotation]);
            for (int i = str.Length - 1; i > Rotation; i--)
                Console.Write(str[i]);
            Console.WriteLine();
        }

        public static void PrintReversed(this int Num)
        {
            string str = Num.ToString();

            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.WriteLine();
        }

        public static void PrintReversed(this string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
                Console.Write(str[i]);
            Console.WriteLine();
        }

        public static void PrintReversed(this string str, char Rotation)
        {
            int RotationIndex = str.IndexOf(Rotation, 0);
            int OldRotationIndex = -1;
            while (RotationIndex != -1)
            {
                for (int i = RotationIndex - 1; i > OldRotationIndex; i--)
                    Console.Write(str[i]);
                Console.Write(str[RotationIndex]);
                OldRotationIndex = RotationIndex;
                RotationIndex = str.IndexOf(Rotation, RotationIndex + 1);
            }
            if (OldRotationIndex != -1)
            {
                for (int i = str.Length - 1; i > OldRotationIndex; i--)
                    Console.Write(str[i]);
                Console.WriteLine();
            }
            else
                PrintReversed(str);
        }

        public static void Reverse(this int[] InputArray, out int[] OutArray)
        {
            int Size = InputArray.Length;
            OutArray = new int[Size];

            for (int i = 0; i < InputArray.Length; i++)
            {
                OutArray[i] = InputArray[Size - 1];
                Size--;
            }
        }

        public static void ChangeToMax(this int[] InputArray)
        {
            int size = InputArray.Length;
            int Max;
            Max = InputArray[0];

            for (int i = 1; i < size; i++)
            {
                if (InputArray[i]>Max)
                {
                    Max = InputArray[i];
                }

            }

            for (int i = 0; i < size; i++)
            {
                if (InputArray[i] < 0 )
                {
                    InputArray[i] = Max;
                }
            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, -6, 2, 4, 3, 9, -3 };
            int[] Array2;

            Array1.Reverse(out Array2);
            for (int i = 0; i < Array2.Length; ++i)
                Console.Write("{0} ", Array2[i]);
            Console.WriteLine();

            124.765.PrintReversed();
            1337.PrintReversed();
            "ReverseThisText".PrintReversed();
            "Rever,seThi,sText".PrintReversed(',');

            Array1.ChangeToMax();
            for (int i = 0; i < Array1.Length; ++i)
                Console.Write("{0} ", Array1[i]);
            Console.WriteLine();

            Console.Read();
        }
    }
}