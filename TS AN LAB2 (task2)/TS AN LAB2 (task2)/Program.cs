using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task2_
{


    class Rectangle
    {

        //поля
        public double side1;
        public double side2;

        public Rectangle(double a, double b) { side1 = a; side2 = b; }



        
        //Метод возвращает периметр прямоугольника
        public void PerimeterCalculator()
        {
            double perimeter = 2 * side1 + 2 * side2;
            Console.WriteLine($"Периметр = {perimeter}");
        }

        //Метод возвращает площадь прямоугольника
        public void AreaCalculator()
        {
            double area = side1 * side2;
                       
            Console.WriteLine($"Площа = {area}");
        }

        

        class Program

        {
            static double a;
            static double b;

            static void Main(string[] args)

            {
                Console.WriteLine("Введіть першу довжину сторони фігури!");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введіть другу довжину сторони фігури!");
                b = Convert.ToDouble(Console.ReadLine());

                if (a != b)
                {
                    Rectangle figure = new Rectangle(a, b);

                    figure.AreaCalculator();

                    figure.PerimeterCalculator();

                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Данна фігура являється квадратом!");
                }

            }


        }
    }
}
