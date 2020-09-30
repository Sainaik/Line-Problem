using System;

namespace Line_Problem
{
    class Program
    {

        

        static void Main(string[] args)
        {
            //variables

            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;

            Console.WriteLine("Enter the Line coordinates");

            Console.WriteLine("Enter the coordinates");

            Console.WriteLine("x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of ");

            Console.WriteLine("x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            float length = (float)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.Out.WriteLine("Length is : " + length + "\n");

        }
    }
}
