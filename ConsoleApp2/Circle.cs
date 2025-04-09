using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Circle : Figure
    {
        private double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public double Radius { get => radius; set => radius = value; }
        public override double Area()
        {
            return Math.PI* radius *radius;
        }
        public override double Perimeter()
        {
            return 2* Math.PI * radius;
        }

        public static Circle Enter()
        {
            Console.WriteLine("Название: ");
            string name = Console.ReadLine();
            Console.Write("Введите радиус");
            double radius = double.Parse(Console.ReadLine());
            return new Circle(name, radius);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}");
            Console.WriteLine($"Площадь: {Area()}");
            Console.WriteLine($"Периметр: {Perimeter()}");
        }
    }
}
