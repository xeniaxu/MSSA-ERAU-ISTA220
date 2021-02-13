using System;

//How do you “flatten” a multidimensional array? 
//A squared matrix like
/*
1 2 3
4 5 6
7 8 9
*/

//Flatten into [1 2 3 4 5 6 7 8 9]

namespace FlattenArray
{

    class Program
    {

        static void Main()
        {
            int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                       
            var rows = array2D.GetLength(0);
            var cols = array2D.GetLength(1);
            var array1D = new int[rows * cols];
            var current = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1D[current++] = array2D[i, j];
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ",array1D));
        }
    }
}


//Output:[1, 2, 3, 4, 5, 6, 7, 8, 9]