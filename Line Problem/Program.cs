using System;

namespace Line_Problem
{
    class Program
    {

        static float CalulateLength(int x1, int x2, int y1, int y2)
        {
            float length = (float)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return length;
        }

        static void Main(string[] args)
        {
            //variables
           
            float[] length = new float[2];

           
            // Taking user Inputs

            for (int i = 0; i <= 1; i++)
            {
                int x1 = 0, x2 = 0, y1 = 0, y2 = 0; 

                Console.WriteLine("Enter the Line" + (i+1) + " coordinates");

                Console.WriteLine("Enter the Line" + i++ + " coordinates");

                Console.WriteLine("x1: ");
                x1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y1: ");
                y1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of ");

                Console.WriteLine("x2: ");
                x2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("y2: ");
                y2 = Convert.ToInt32(Console.ReadLine());


            }

            if ( length[0].Equals(length[1]) )
            {
                Console.WriteLine("Equal lines");
            }
            else
            {
                Console.WriteLine("Different lines");
            }

        }
    }
}
