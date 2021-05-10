using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Abstraction
    {
        static void Main()
        {
            // Cannot access abstract class directly
            //Shapes_abs shapes = new Shapes_abs;

            Lines_abs line = new Lines_abs();
            line.SayHi();
        }
        
        
    }

    abstract class Shapes_abs
    {
        public void SayHi()
        {
            Console.WriteLine("Hi From The Dark Abstract Side");
        }
    }

    class Lines_abs : Shapes_abs
    {

    }
}
