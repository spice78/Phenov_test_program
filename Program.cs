using System;
using System.Globalization;

namespace Phenov_test_program
{
    class Program
    {
        //static int[] array = { 10, 98, 78, 4, 54, 25, 84, 41, 30, 87, 6};//массив для qsort

        static void Main()
        {
            Person p = new Person("Anus", "Jopy");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.FirstName, p.LastName);

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
            int vx = 1;
            int vy = 2;
            int vz = 3;
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
            
            Console.Write("Press any key to exit....");
            Console.ReadLine();

        }

        static void Sum()
        {            
            int sum = 1;
            Console.Write("Enter max = ");
            int max = Convert.ToInt32(Console.ReadLine(), NumberFormatInfo.CurrentInfo);
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

        /*static void sort(int l, int r) //qsort
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
        }*/
    }    
}
