using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.Name = name;
        }
        public string Name { get => name; set => name = value; }
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
    }
}
