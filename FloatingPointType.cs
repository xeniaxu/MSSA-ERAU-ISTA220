using System;
//A floating point is a simple value type that represents fractional numbers.

namespace FloatingPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float:{float.MinValue} to {float.MaxValue} (with~6-9 digits of precision)");
            Console.WriteLine($"double:{double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        }
    }
}

//Output:
//Floating point types:
//float:-3.4028235E+38 to 3.4028235E+38(with~6 - 9 digits of precision)
//double:-1.7976931348623157E+308 to 1.7976931348623157E+308(with ~15 - 17 digits of precision)
//decimal: -79228162514264337593543950335 to 79228162514264337593543950335(with 28 - 29 digits of precision)

//Since floating-point types can hold large numbers with a lot of precision, their values can be represented using "E notation",
//which is a form of scientific notation that means"times ten raised to the power of".

//Choose the right floating-point type: 1. max and min value.2. How many and how the numbers are stored/affects the outcome.

//There is a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double, 
//especially when determinig how much accuracy is necessary from math operations.

