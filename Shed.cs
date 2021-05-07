using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using int32 = System.Int32;

namespace Phenov_test_program
{
    class Shed
    {
        private int32 width;
        private int32 height;
        static int ObjectNumber = 0;

        public int GetObjectNumber()
        {
            return ObjectNumber;
        }

        static Shed()
        {
            ObjectNumber++;
        }

        public Shed()
        {
            Width = 1;
            Height = 1;
            Lengthwise = 1;
        }

        public Shed(int w) : this()
        {            
            Width = w;            
        }

        public Shed(int w, int h) : this()
        {            
            Width = w;            
            Height = h;            
        }

        public Shed(int w, int height, int l) : this()
        {             
            Width = w;
            Lengthwise = l;
            Height = height;
        }

        public int Width
        {
            get { return width; }

            set
            {
                if (value > 0 && value < 100)
                    width = value;
                else
                    Console.WriteLine("Width is not in acceptable range.");
            }
        }

        public int Height
        { 
            get { return height; }

            set
                {
                    if (value > 0 && value< 100)
                        height = value;
                    else
                        Console.WriteLine("Height is not in acceptable range.");
                    //return ("This is unacceptable...Aohhhhhhhhh.(Lemon prince.)");
                }
        }

        public int Lengthwise { get; set; }

        public int GetSize()
        {
            return Width * Height * Lengthwise;
        }

        public void ExpandSize(int x, int y, int z)
        {
            Width += x;
            Height += y;
            Lengthwise += z;
        }

        public void ExpandSize(int x, int y)
        {
            Width += x;
            Height += y;            
        }

        public void ExpandAndGetSize(ref int x, ref int y, ref int z)
        {
            ExpandSize(x, y, z);
            x = Width;
            y = Height;
            z = Lengthwise;
        }

        public void ExpandAndGetSize(int inc, out int x, out int y, out int z)
        {
            ExpandSize(inc, inc, inc);
            x = Width;
            y = Height;
            z = Lengthwise;
        }
    }
}
