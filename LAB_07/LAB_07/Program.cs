using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 100 до 999: ");

            int integer;
            integer = int.Parse(Console.ReadLine());
            if (integer<100 || integer>999)
            {
                Console.WriteLine("Error!!!");
            }

            List<int> a = new List<int>();
            a.Add(integer / 100);
            a.Add((integer % 100)/10);
            a.Add((integer % 100) % 10);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(a[i]);
            }

            a.Sort();
            
            int counter = 0;

            for (int i = 1; i < 3; i++)
            {
                if (a[i - 1] == a[i] && a[i] == a[i + 1])
                {
                    counter = 1;
                    Console.WriteLine("Цифра "+ a[i] + " встречаеться 3 раза");
                    break;
                    
                }
                if (a[i - 1] != a[1] && a[i - 1] != a[i + 1] && a[i] != a[i + 1])
                {
                    counter = 3;
                    Console.WriteLine("Каждая цифра встречаеться один раз");
                    break;
                }
                 if (a[i - 1] == a[i] && a[i - 1] != a[i + 1])
                {
                    counter = 2;
                    Console.WriteLine("Цифра " +  a[i] + " встречаеться 2 раза");
                    Console.WriteLine("Цифра " + a[i+1] + " встречаеться один раз");
                    break;
                }
                 if (a[i] == a[i + 1] && a[i] != a[i - 1])
                {
                    counter = 2;
                    Console.WriteLine("Цифра " + a[i] + " встречаеться 2 раза");
                    Console.WriteLine("Цифра " + a[i - 1] + " встречаеться один раз");
                    break;
                }

            }

            
            


            Console.ReadKey();


        }
    }
}
