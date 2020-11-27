using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_SPEC.WORK
{
    public class Whiskey
    {
        public int cost;

        public int exposure;

        public string country;

        public float size;

        public Whiskey(int _cost, int _exposure, string _country, float _size)
        {
            cost = _cost;
            exposure = _exposure;
            country = _country;
            size = _size;
        }

        public void Print()
        {

            Console.WriteLine("Cost: " + cost + '\n' + "Exposure: " + exposure + '\n' + "Country: " + country + '\n' + "Size: " + size);
        }

    }



    class Program
    {

        public static void Input(Whiskey[] WhiskeySelection)
        {
            byte counter = 0;
            Console.WriteLine("Enter cost of desired whiskey: ");
            int cost1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter exposure of desired whiskey: ");
            int exposure1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter country of desired whiskey: ");
            string country1 = Console.ReadLine();
            Console.WriteLine("Enter size of desired whiskey: ");
            float size1 = float.Parse(Console.ReadLine());

            for (int i = 0; i < WhiskeySelection.Length; i++)
            {
                counter = 0;
                if(cost1 >= WhiskeySelection[i].cost)
                {
                    counter++;
                }
                if(exposure1 >= WhiskeySelection[i].exposure)
                {
                    counter++;
                }    
                if(size1 == WhiskeySelection[i].size)
                {
                    counter++;
                    if (counter==3)
                    {
                        WhiskeySelection[i].Print();
                        continue;
                    }
                }
                if (country1 == WhiskeySelection[i].country)
                {
                    counter++;
                    if (counter == 3)
                    {
                        WhiskeySelection[i].Print();
                        continue;
                    }
                }

            }

        }

        

        static void Main(string[] args)
        {
            Whiskey[] WhiskeySelection = new Whiskey[5];


            WhiskeySelection [0] = new Whiskey(150,10,"Scotland",1f);
            WhiskeySelection[1] = new Whiskey(75,15,"Ireland",0.7f);
            WhiskeySelection[2] = new Whiskey(100,10,"USA",0.7f);
            WhiskeySelection[3] = new Whiskey(200,20,"Ireland",0.5f);
            WhiskeySelection[4] = new Whiskey(400,30,"Scotland",0.5f);



            Input(WhiskeySelection);

            Console.ReadKey();
        }
    }
}
