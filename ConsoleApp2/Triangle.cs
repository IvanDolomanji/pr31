using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;
        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public override double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public static Triangle Enter()
        {
            Console.WriteLine("Название: ");
            string name = Console.ReadLine();
            Console.Write("а= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            return new Triangle(name, a, b, c);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: a={a} b={b} c={c}");
            Console.WriteLine($"Площадь: {Area()}");
            Console.WriteLine($"Периметр: {Perimeter()}");
        }
    }
}
