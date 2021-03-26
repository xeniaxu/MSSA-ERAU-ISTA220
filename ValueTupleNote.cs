using System;

//Note Date:2021-3-26
//Review Date:2021-3-26

//定义：C# 7.0 (.NET Framework 4.7) introduced the ValueTuple structure, which is a value type representation of the Tuple(Reference type).
//It is easy to create and initialize the ValueTuple. It can be created and initialized using parentheses () and specifying the values in it.

//安装：To install the ValueTuple package, right-click on the project in the solution explorer and select Manage NuGet Packages, this will open the NuGet Package Manager.
//Click the Browse tab, search for ValueTuple in the search box, and select the System.ValueTuple package.

namespace ValueTupleNote
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = (1, "Bill", "Gates");
            //equivalent Tuple
            //var person = Tuple.Create(1, "Bill", "Gates");
            Console.WriteLine(person);

            //The ValueTuple can also be initialized by specifying the type of each element.
            (int, string, string) classmates = (100, "yan", "xu");//Please notice that we have not used var in the above tuple initialization statement;
                                                                  //instead, we provided the type of each member values inside the brackets.
            Console.WriteLine(classmates.Item1);  //100
            Console.WriteLine(classmates.Item2);   //yan
            Console.WriteLine(classmates.Item3);   //xu

            //Tuple requires at least two values.
            var number = (1);  // int type, NOT a tuple
            var numbers = (1, 2); //valid tuple
            Console.WriteLine(Convert.ToString(number));//1
            Console.WriteLine(numbers);//(1, 2)

            //Unlike Tuple, a ValueTuple can include more than eight values.
            var numbers2 = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            Console.WriteLine(numbers2);

            //Assign names to the ValueTuple properties instead of having the default property names like Item1, Item2 and so on.
            (int Id, string FirstName, string LastName) famous = (1, "Bill", "Gates");
            Console.WriteLine(famous.Id);   // 1
            Console.WriteLine(famous.FirstName);  //Bill
            Console.WriteLine(famous.LastName); // Gates

            //Assign member names on the right side with values.
            var famous2 = (Id: 1, FirstName: "Bill", LastName: "Gates");
            Console.WriteLine(famous2);//(1, Bill, Gates)
            //Please note that we can provide member names either on the left or right sides but not on both sides.
            //The left side has precedence over the right side. 

            //We can also assign variables as member values.
            string firstName = "Bill", lastName = "Gates";
            var per = (FirstName: firstName, LastName: lastName);
            Console.WriteLine(per);//(Bill, Gates)

            //ValueTuple as Return Type.
            DisplayTuple(person);//Id = 1
                                 //First Name = Bill
                                 //Last Name = Gates

            //Specify different member names for a ValueTuple returned from a method.
            var person2 = GetPerson();
            Console.WriteLine(person2.Id);//1
            Console.WriteLine(person2.FirstName);//Bill
            Console.WriteLine(person2.LastName);//Gates

            //Individual members of a ValueTuple can be retrieved by deconstructing it.ValueTuple的单个成员可通过解构获得。
            //The general syntax for deconstructing a tuple is similar to the syntax for defining one:
            //You enclose the variables to which each element is to be assigned in parentheses in the left side of an assignment statement.
            //为什么解构？A tuple provides a lightweight way to retrieve multiple values from a method call.
            //But once you retrieve the tuple, you have to handle its individual elements.->很麻烦
            //A single deconstruct operation可以解决这个问题。

            //There are three ways to deconstruct a tuple:
            //1.  Explicitly declare the type of each field inside parentheses. 
            (string city, int population, double area) = QueryCityData("New York City");
            Console.WriteLine(city);//New York City
            Console.WriteLine(population);//8175133
            Console.WriteLine(area);//468.48

            //2. Use the var keyword to infer the type of each variable->Place the var keyword outside of the parentheses.
            var (city2, population2, area2) = QueryCityData("New York City");
            Console.WriteLine(city2);//New York City
            Console.WriteLine(population2);//8175133
            Console.WriteLine(area2);//468.48

            //累赘笨重不推荐，3. Use the var keyword individually with any or all of the variable declarations inside the parentheses.
            (string city3, var population3, var area3) = QueryCityData("New York City");
            Console.WriteLine(city3);//New York City
            Console.WriteLine(population3);//8175133
            Console.WriteLine(area3);//468.48

            //Lastly, we may deconstruct the tuple into variables that have already been declared.
            string city4 = "Raleigh";
            int population4 = 458880;
            double area4 = 144.8;

            (city4, population4, area4) = QueryCityData("New York City");
            Console.WriteLine(city4);//New York City
            Console.WriteLine(population4);//8175133
            Console.WriteLine(area4);//468.48

            //Deconstructing tuple elements with discards.
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("New York City", 1960, 2010);
            Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");//只选取两个人口数量作进一步操作。Population change, 1960 to 2010: 393,149

        }

        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        static (int Id, string FirstName, string LastName) GetPerson()
        {
            return (1, "Bill", "Gates");
        }

        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }

        private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }
    }
}
