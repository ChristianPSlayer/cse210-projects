using System;
using Shapes;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();

       shapes.Add(new Square("green", 6));
       shapes.Add(new Rectangle("blue", 6, 6));
       shapes.Add(new Circle("red", 9));

       foreach (Shape shape in shapes)
        {
         
           Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetType().Name} is {shape.GetArea():F2}");
        }
    }
}