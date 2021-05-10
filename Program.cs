using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism!");

            Shapes[] shapes = new Shapes[4];
            shapes[0] = new Shapes();
            shapes[1] = new Circles();
            shapes[2] = new Lines();
            shapes[3] = new Triangle();

            foreach (var item in shapes)
            {
                item.Draw();
            }
        }
    }

    class Shapes
    {
        //Keyword virtual allows the void to be overwritten
        public virtual void Draw()
        {
            Console.WriteLine("I'm a simple shape");
        }
    }

    class Circles : Shapes
    {
        //Keyword override allows this draw to override the original
        public override void Draw()
        {
            Console.WriteLine("I'm a circle");
        }
    }

    class Lines : Shapes
    {
        //Did not override so this stays the same
        public void Draw()
        {
            Console.WriteLine("I'm a line");
        }
    }

    class Triangle : Shapes
    {
        //Keyword override allows this draw to override the original
        public override void Draw()
        {
            Console.WriteLine("I'm a triangle");
        }
    }

}
