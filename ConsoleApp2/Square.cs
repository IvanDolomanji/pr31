using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Square : Figure
    {
        private double side;
        public Square(string name, double side) : base(name)
        {
            this.Side = side;
        }

        public double Side { get => side; set => side = value; }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public static Square Enter()
        {
            Console.WriteLine("Название: ");
            string name = Console.ReadLine();
            Console.Write("Введите сторону:");
            double side = double.Parse(Console.ReadLine());
            return new Square(name, side);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Сторона: {side}");
            Console.WriteLine($"Площадь: {Area()}");
            Console.WriteLine($"Периметр: {Perimeter()}");
        }
    }
}
