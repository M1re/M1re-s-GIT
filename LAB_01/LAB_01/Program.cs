using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mori
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours;
            int minutes;
            int seconds;
            seconds = int.Parse(Console.ReadLine());
            hours = (int)(Math.Floor((double)(seconds / 3600)));
            seconds = seconds % 3600;
            minutes = (int)(Math.Floor((double)(seconds / 60)));
            seconds = seconds % 60;
            string time = hours + ":" + minutes + ":" + seconds;
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}