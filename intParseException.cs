using System;
//Write a snippet of code which:
//calls int.parse("17")
//handles the appropriate exception if thrown
//outputs “Done!” to the screen regardless of whether an exception is thrown


namespace intParseException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int numVal = Int32.Parse("17");//Convert a string representation of number to an integer.
                Console.WriteLine(numVal);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done!");
            }
        }
    }
}
