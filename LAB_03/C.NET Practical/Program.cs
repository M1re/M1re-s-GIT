using System;

namespace C.NET_Practical
{
    class Program
    {
        static int Main(string[] args)
        {

            string Guess;
            Console.WriteLine("Введите число для сравнения: ");

            Guess = Console.ReadLine();

            if (Guess.Length > 4|| Guess.Length<4)
            {
                Console.WriteLine("Вы ввели неправильное число!!!");
                return -1;
            }

            if (Guess[0] == Guess[3])
            {
                if (Guess[1] == Guess[2])
                {
                    Console.WriteLine("Число читается как слева направо, так и справа налево");
                    Console.WriteLine(Guess);
                }
            }
            else
                Console.WriteLine("Число не читается слева направо и справа налево");
            return 0;

			Console.ReadKey();
		}
    }
}
