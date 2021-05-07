using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Phenov_test_program
{
    abstract class Figure
    {
        abstract public void Draw();
        
    }    

    class RectangleFigure : Figure
    {
        public override void Draw()
        {
            WriteLine("This is Rectangle.");
        }
    }

    class CircleFigure : Figure
    {
        public override void Draw()
        {
            WriteLine("This is Circle.");
        }
    }
}
