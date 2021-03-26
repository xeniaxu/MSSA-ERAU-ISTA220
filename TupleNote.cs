using System;

//Note Date:2021-3-26
//Review Date:2021-3-26

//定义：A tuple is a data structure that contains a sequence of elements of different data types.(可以理解为一种简化class)
//It can be used where you want to have a data structure to hold an object with properties, but you don't want to create a separate type for it.

//语法：Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
//A tuple can only include a maximum of 8 elements. It gives a compiler error when you try to include more than 8 elements.
//If you want to include more than eight elements in a tuple, you can do that by nesting another tuple object as the eighth element.
//The last nested tuple can be accessed using the Rest property.
//To access the nested tuple's element, use the Rest.Item1.Item<elelementNumber> property.

//应用：A tuple elements can be accessed with Item<elementNumber> properties, e.g., Item1, Item2, Item3, and so on up to Item7 property.
//The Item1 property returns the first element, Item2 returns the second element, and so on.
//The last element (the 8th element) will be returned using the Rest property.
//Generally, the 8th position is for the nested tuple, which you can access using the Rest property.

//小结：Tuples can be used in the following scenarios:
//1. When you want to return multiple values from a method without using ref or out parameters.
//2. When you want to pass multiple values to a method through a single parameter.
//3. When you want to hold a database record or some values temporarily without creating a separate class.

//Limitations:
//The Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
//The Tuple is limited to include eight elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
//The Tuple elements can be accessed using properties with a name pattern Item<elementNumber>, which does not make sense.

namespace TupleNote
{
    class Program
    {
        public static void Main()
        {
            var person = Tuple.Create(1, "Steve", "Jobs");
            Console.WriteLine(person.Item1); // returns 1
			Console.WriteLine(person.Item2); // returns "Steve"
			Console.WriteLine(person.Item3); // returns "Jobs"


			var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
			Console.WriteLine(numbers.Item1); // returns "One"
			Console.WriteLine(numbers.Item2); // returns 2
			Console.WriteLine(numbers.Item3); // returns 3
			Console.WriteLine(numbers.Item4); // returns "Four"
			Console.WriteLine(numbers.Item5); // returns 5
			Console.WriteLine(numbers.Item6); // returns "Six"
			Console.WriteLine(numbers.Item7); // returns 7
			Console.WriteLine(numbers.Rest); // returns (8)
			Console.WriteLine(numbers.Rest.Item1); // returns 8

			var numbers2 = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
			Console.WriteLine(numbers2.Item1); // returns 1
			Console.WriteLine(numbers2.Item7); // returns 7
			Console.WriteLine(numbers2.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
			Console.WriteLine(numbers2.Rest.Item1.Item1); //returns 8
			Console.WriteLine(numbers2.Rest.Item1.Item2); //returns 9

			//实际上不一定嵌套第八位，You can include the nested tuple object anywhere in the sequence.
			//但是，However, it is recommended to place the nested tuple at the end of the sequence so that it can be accessed using the Rest property.

			//A method can have a tuple as a parameter.
			var classmates = Tuple.Create(1, "Steve", "Jobs");
			DisplayTuple(classmates);

			//A Tuple can be return from a method.
			var colleague = GetColleague();
			Console.WriteLine(colleague);//(1, Bill, Gates)
		}

		static void DisplayTuple(Tuple<int, string, string> classmates)
		{
			Console.WriteLine($"Id = { classmates.Item1}");//Id = 1
			Console.WriteLine($"First Name = { classmates.Item2}");//First Name = Steve
			Console.WriteLine($"Last Name = { classmates.Item3}");//Last Name = Jobs
		}

		static Tuple<int, string, string> GetColleague()
		{
			return Tuple.Create(1, "Bill", "Gates");
		}
	}
}
