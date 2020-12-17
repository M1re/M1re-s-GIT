
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Garage
    {
        public string name;
        public string color;
        public int speed;
        public int year;

        public Garage(string _name, string _color, int _speed, int _year)
        {
            name = _name;
            color = _color;
            speed = _speed;
            year = _year;
        }
        public void Print()
        {
            Console.WriteLine("Name " + name);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Speed " + speed);
            Console.WriteLine("Year " + year);

        }
    }

    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1. Купить машину");
            Console.WriteLine("2. Продать машину");
            Console.WriteLine("3. Выбрать машину");
            Console.WriteLine("4. Покинуть гараж");
        }
        static void Main(string[] args)
        {
            List<Garage> auto = new List<Garage>();



            while (true)
            {
                Console.WriteLine("Выберите пункт: ");
                Menu();
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите марку: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите цвет: ");
                            string color = Console.ReadLine();
                            Console.WriteLine("Введите скорость: ");
                            int speed = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска: ");
                            int year = int.Parse(Console.ReadLine());
                            auto.Add(new Garage(name, color, speed, year));
                            Console.WriteLine("Вы успешно купили новую машину!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите марку: ");
                            string nameDel = Console.ReadLine();
                            Console.WriteLine("Введите цвет: ");
                            string colorDel = Console.ReadLine();

                            for (int i = 0; i < auto.Count; i++)
                            {
                                if (nameDel == auto[i].name && colorDel == auto[i].color)
                                    auto.RemoveAt(i);
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите марку: ");
                            string _name = Console.ReadLine();
                            Console.WriteLine("Введите цвет: ");
                            string _color = Console.ReadLine();
                            Console.WriteLine("Введите скорость: ");
                            int _speed = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите год выпуска: ");
                            int _year = int.Parse(Console.ReadLine());

                            for (int i = 0; i < auto.Count; i++)
                            {
                                if (_name == auto[i].name && _color == auto[i].color)
                                    auto[i].Print();
                                else if (_year == auto[i].year && _speed == auto[i].speed)
                                    auto[i].Print();
                                else Console.WriteLine("Подходящих машин нет!");
                                break;
                            }

                            break;
                        }
                    case 4:
                        {

                            goto exit;
                            
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Введите существующий пункт меню!!!");
                            break;
                        }

                }

            }

                      exit:
               Console.ReadKey();

        }
    }
}