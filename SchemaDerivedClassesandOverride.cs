using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Shapes
    {
        public string Color {  get; set; }
        public Shapes()
        {
        }

        public virtual void GetColor()
        {
            Console.WriteLine("What is the color of your shape?");
        }
    }

    public class Retangle : Shapes
    {
        public Retangle()
        { }

        public override void GetColor()
        {
            Console.WriteLine($"Is this still your color?{Color}");
        }

    }

    public class Triangle : Shapes 
    {
        public Triangle() { }

    }

    public class Circle : Shapes 
    { 
        public Circle() { }
    }

    public class Square : Retangle 
    {
        public  Square() { }    
    }

    public class Trapezoid : Retangle
    {
        public  Trapezoid() { }
    }

    public class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle() { }    
    }
}
