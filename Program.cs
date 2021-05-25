using System;
using System.Globalization;
using System.Threading;
using static System.Console;


namespace Phenov_test_program
{
    class Program
    {
        static int[] array = { 10, 98, 78, 4, 54, 25, 84, 41, 30, 87, 6};//массив для qsort

        static void Main()
        {
            /*Figure rest;
            
            rest = new RectangleFigure();
            rest.Draw();
            rest = new CircleFigure();
            rest.Draw();*/

            /*Person p1 = new Person("Anus", "Jopy");
            Person p2 = new Person("Anus", "Jopy");
            Person p3 = p1;
            Person p4 = new Person("Jopy", "Anus");

            WriteLine(Person.ComparePersons(p1, p2)); // одинаковые параметры
            WriteLine(Person.ComparePersons(p1, p3)); // одинаковые 
            WriteLine(Person.ComparePersons(p2, p3)); // одинаковые параметры
            WriteLine(Person.ComparePersons(p1, p4)); // не одинаковые 

            Write('\n');

            WriteLine(p1.ComparePersons(p2));
            WriteLine(p1.ComparePersons(p3));
            WriteLine(p2.ComparePersons(p3));
            WriteLine(p1.ComparePersons(p4));*/

            //Console.WriteLine(p1.ToString());

            //Sum();

            /*sort(0, array.Length - 1);
            foreach (int i in array)
                Console.WriteLine(i);*/ //qsort реализация

            //Shed myFirstShed = new Shed(); //иницилизация класса Shed

            /*Console.Write("pls, enter height: ");                 //Начло блока для ручного ввода
            int h = Convert.ToInt32(Console.ReadLine(), NumberFormatInfo.CurrentInfo);
            Console.Write("pls, enter width: ");
            int w = Convert.ToInt32(Console.ReadLine(), NumberFormatInfo.CurrentInfo);
            Console.WriteLine('\n');

            myFirstShed.Width = w;
            myFirstShed.Height = h;
            myFirstShed.Lengthwise = myFirstShed.Height + 3;*/ //Конец блока для ручного ввода

            /*myFirstShed.Width = 20;
            myFirstShed.Height = 10;                        
            myFirstShed.Lengthwise = myFirstShed.Height;*/
            //int vx = 1;
            //int vy = 2;
            //int vz = 3;
            //myFirstShed.ExpandAndGetSize(ref vx, ref vy, ref vz);
            //myFirstShed.ExpandAndGetSize(7, out vx, out vy, out vz);

            /*Console.WriteLine("Height is: " + myFirstShed.Height);
            Console.WriteLine("Width is: " + myFirstShed.Width);
            Console.WriteLine("Depth is: " + myFirstShed.Lengthwise);
            Console.WriteLine("Size is: " + myFirstShed.GetSize());*/
            //Console.WriteLine("Expand for: " + vx + " " + vy + " " + vz);

            /*string[] args = Environment.GetCommandLineArgs();
            foreach (string i in args)
                Console.WriteLine(i);*/ //вызов аргументов

         ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };
            //foreach (ConsoleColor color in colors)
            
            //while (true)
            //{
                foreach (ConsoleColor color in colors)
                {
                    CursorLeft = (BufferWidth - color.ToString().Length) / 2;
                    CursorTop = 10;
                    ForegroundColor = color;
                    WriteLine(color);
                    Thread.Sleep(1000);
                    Clear();                   
                }
            //}
            ForegroundColor = ConsoleColor.White;
            WriteLine("Press any key to exit....");
            ReadLine();

        }

        static void Sum()
        {            
            int sum = 1;
            Write("Enter max = ");
            int max = Convert.ToInt32(ReadLine(), NumberFormatInfo.CurrentInfo);
            int i = 2;
            do
            {
                sum *= i;
                i++;
            } while (i <= max);
            Console.WriteLine("sum = " + sum);
            //Console.Write("Press any key to exit....");
            //Console.ReadLine();
        }

        static void sort(int l, int r) //qsort
        {
            int i = l;
            int j = r;
            int x = array[(l + r) / 2];
            do
            {
                while (array[i] < x) i++;
                while (array[j] > x) j--;
                if (i <= j)
                {
                    int y = array[i];
                    array[i] = array[j];
                    array[j] = y;
                    i++;
                    j--;
                }
            } while (i < j);

            if (l < j)
                sort(l, j);
            if (i < r)
                sort(i, r);
        }
    }
}
