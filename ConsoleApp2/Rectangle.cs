using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rectangle : Figure
    {
        private double side1;
        private double side2;

        public Rectangle(string name, double side1, double side2) : base(name)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public override double Area()
        {
           return side1 * side2;
        }
        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public static Rectangle Enter()
        {
            Console.WriteLine("Название: ");
            string name = Console.ReadLine();
            Console.Write("Введите 1 сторону");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите 2 сторону");
            double side2 = double.Parse(Console.ReadLine());
            return new Rectangle(name,side1, side2);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: {side1}, {side2}");
            Console.WriteLine($"Площадь: {Area()}");
            Console.WriteLine($"Периметр: {Perimeter()}");
        }
    }
}

