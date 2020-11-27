using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_06
{
    class Program
    {

        static void INT(double a)
        {
            string str = a.ToString();

            int index = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == ',')
                {
                    index = i;
                    break;

                }

            }

            for (int i = index - 1; i >= 0; i--)
            {

                Console.Write(str[i]);


            }

            Console.Write(str[index]);

            for (int i = str.Length - 1; i > index; i--)
            {
                Console.Write(str[i]);
            }

        }


        static void INT(int a)
        {
            string str = a.ToString();

            for (int i = str.Length - 1; i >= 0; i--)
            {

                Console.Write(str[i]);

            }

        }


        static void INT(string str)
        {
            int index2 = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]=='.' || str[i]==',')
                {
                    index2 = i;
                }


            }
            if (index2!=0)
            {
                

                for (int i = index2 - 1; i >= 0; i--)
                {

                    Console.Write(str[i]);


                }

                Console.Write(str[index2]);

                for (int i = str.Length - 1; i > index2; i--)
                {
                    Console.Write(str[i]);
                }
            }
            if (index2==0)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {

                    Console.Write(str[i]);

                }
            }

        }

        static void Reverse(ref int[] array,out int []b)
        {

            int c = array.Length;
            b = new int[c];

            for (int i = 0; i < array.Length; i++)
            {

                b[i] = array[c - 1];
                
                c--;
            }

            

        }

        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
                Console.Write(array[i]);
            }

            int[] array2 = new int[array.Length];
            Reverse(ref array, out array2);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }


            Console.ReadKey();

        }
    }
}
