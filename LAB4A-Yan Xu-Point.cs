#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;
        private static int objectCount = 0;

        public Point()
        {
            //Console.WriteLine("Default constructor called");
            this.x = -1;
            this.y = -1;
            objectCount++;

        }
        public Point(int x, int y)
        {
            //Console.WriteLine($"x:{x},y:{y}");rewrite this using this keyword.
            
            this.x = x;
            this.y = y;
            objectCount++;
            /*All parameter with the same name as a field hides the field for all statements in the method.
            *all this code actually does is assign the parameters to themselves,it does not modify the fields at all.
            *Use this keyword to qualify which variables are parameters and which are fields. 
            *Prefixing a variable with this means "the field in this object."
            *A field is a variable that exists inside of an object, while a parameter is a variable inside a method whose value is passed in from outside. 
            */

            //Other way to fix this problem, using different name. public Point(int xCoor,int yCoor){x=xCoor;y=yCoor;}
        }

        public double DistanceTo(Point other)
        {
            int xDiff = this.x - other.x;
            int yDiff = this.y = other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public void Deconstruct(out int x,out int y)
        {
            x = this.x;
            y = this.y;
        }//A deconstructor enables you to examine an object and extract the values of its fields.

        public static int Objectcount() => objectCount;
    }
}
