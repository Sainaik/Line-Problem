using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Problem
{
    class Line
    {
        //coordinarte variables
        int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
        float length = 0;


        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public float CalulateLength()
        {
            this.length = (float)Math.Sqrt(((this.x2 - this.x1) * (this.x2 - this.x1)) + ((this.y2 - this.y1) * (this.y2 - this.y1)));
            
            Console.Out.WriteLine("Length is : " + this.length+"\n");
            return this.length;
        }

        public bool IsEqual( Line line)
        {
            String s1 = "x1" + this.x1 + "y1" + this.y1 + " x2 " + this.x2 + " y2 " + this.y2;

            String s2 = "x1" + line.x1 + "y1" + line.y1 + " x2 " + line.x2 + " y2 " + line.y2;

            return s1.Equals(s2);
        }

        public int CompareLines(Line line)
        {
            
            return this.length.CompareTo(line.length);
        }



    }
}
