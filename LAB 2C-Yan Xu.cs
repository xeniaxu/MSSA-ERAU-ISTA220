/*LAB 2C - C# - Monte-Carlo Method-Yan Xu
 * C# provides the System.Random class which generates random numbers. 
 * By generating many random values, you can estimate the result of complicated mathematical equations via a technique known as the Monte Carlo method. 
 * All valid points are between { x = 0, y = 0 } and { x = 1, y = 1 }.
 * By randomly generating many x, y pairs, calculating the length of the hypotenuse of a triangle with sides of length x, y using the Pythagorean theorem.使用勾股定理计算三角形斜边长度。
 * Step 1:Create a function which, given an instance of a System.Random object as a parameter, 
        * returns a tuple of two uniformly distributed random floating point numbers between 0 and 1.
 */

using System;

namespace MonteCarloMethod
{
    class Program
    {

        static (double,double)GetNextPoint(Random rand)
        {
            double x = rand.NextDouble();
            double y = rand.NextDouble();
            return (x, y);
        }

        /*Step 2:Create a function which takes two doubles called x and y.
         * Returns a double corresponding to the hypotenuse of a triangle with sides of lengths x, y.
         */

        static double DistanceFromOrigin(double x, double y) => Math.Sqrt(x * x + y * y);

        static int GetNumberofPoints()
        {
            Console.WriteLine("How many times should we iterate?");

           /* string response = Console.ReadLine();
            *int howManyTimes = Int32.Parse(response);
           */

            return Int32.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Random RandomNumber = new Random();
            
            int iterations = GetNumberofPoints();//Calling the method return the interger, user give the number.
            //Step 3:Build a Main method which takes one int parameter (which we'll call "iterations") from the command line.
            int insiderCircleCount = 0;

            Console.WriteLine("Monte-Carlo!");

             for(int i=0;i<iterations;i++)
            {
                //Console.WriteLine($"Next number is {RandomNumber.NextDouble()}");

                Tuple<double, double> point = GetNextPoint(RandomNumber).ToTuple<double, double>();
                //A tuple is a data structure that contains a sequence of elements of different data types. 
                //A tuple can be used where a data structure to hold an object with properties but no need to create a separate type for it.

                double length = DistanceFromOrigin(point.Item1, point.Item2);
                if(length<=1.0)
                {
                    insiderCircleCount++;
                }
                double estimate = (double)insiderCircleCount / (double)iterations * 4.0;
                Console.WriteLine($"Value={estimate}");

                /* Step 4: Iterate iterations times. 
                 * For each iteration, you should:generate a new x, y pair,
                 * take the hypotenuse of the pair, 
                 * and increment a counter for each coordinate which overlaps the unit circle
                 * 
                 * Step 5: Divide the number of coordinate pairs overlapping the unit circle by the total number of iterations. 
                 * Multiply the resulting value by 4.
                 * 基本思想： 利用圆与其外接正方形面积之比为pi/4的关系，通过产生大量均匀分布的二维点，计算落在单位圆和单位正方形的数量之比再乘以4便得到pi的近似值。
                 * 样本点越多，计算出的数据将会越接近真识的pi（前提时样本是“真正的”随机分布）。
                 * 
                 * Step 6: Print the value from step #5 along with the absolute value of the difference between your estimate of and the library-provided value of PI/Math.PI.
                 * 
                 * Step 7: Run your program, passing 10, 100, 1000, and 10000 as the command line parameter. 
                 * Record the output of your program as comments in your source file.
                 */


                /* Questions
                 * Why do we multiply the value from step 5 above by 4?
                 * The ratio of the area of a circle to its circumscribed square is pi/4.
                 * 
                 * What do you observe in the output when running your program with parameters of increasing size?
                 * The more sample points, the closer the calculated data will be to the true pi.
                 * 
                 * If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
                 * The output remain the same because of the same parameter instead of random parameters.
                 * 
                 * Find a parameter that requires multiple seconds of run time. What is that parameter?
                 * It depends on how fast your computer is.
                                 *  
                 * How accurate is the estimated value of pi?
                 * Depend on how many samples caculated and is that paremeter real random. 
                 * 
                 * Research one other use of Monte-Carlo methods. Record it in your exercise submission and be prepared to discuss it in class.
                 * Monte Carlo method can be used not only for calculation, but also for simulating random movement inside the system. We can use it to simulate a traffic jam in a single lane.
                 */
            }

        }
    }
}

