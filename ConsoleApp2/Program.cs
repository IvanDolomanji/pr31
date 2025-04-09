using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();

            bool flag = true;
            do
            {
                Console.Write("Введите фигуру: ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "треугольник":
                    case "Треугольник":
                        Triangle triangle = Triangle.Enter();
                        break;
                    case "круг":
                    case "Круг":
                        Circle circle = Circle.Enter();
                        break;
                    case "квадрат":
                    case "Квадрат":
                        Square square = Square.Enter();
                        break;
                    case "прямоугольник":
                    case "Прямоугольник":
                        Rectangle rectangle = Rectangle.Enter();
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                    break;
                }
                Console.WriteLine();
            } while (flag);
        
        }
    }
}
