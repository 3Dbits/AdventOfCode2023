namespace AdventOfCode.Day3
{
    internal class Helpers
    {
        public static string[,] AddBorder(string[,] original)
        {
            int rows = original.GetLength(0);
            int cols = original.GetLength(1);

            // Create a new array with dimensions (rows + 2) x (cols + 2)
            string[,] newArray = new string[rows + 2, cols + 2];

            for (int i = 0; i < rows + 2; i++)
            {
                for (int j = 0; j < cols + 2; j++)
                {
                    // Add "." to the first and last row, and the first and last column
                    if (i == 0 || i == rows + 1 || j == 0 || j == cols + 1)
                    {
                        newArray[i, j] = ".";
                    }
                    else
                    {
                        // Copy the original values to the inner part of the new array
                        newArray[i, j] = original[i - 1, j - 1];
                    }
                }
            }

            return newArray;
        }

        public static string[,] ConvertToMultidimensionalArray(string[] originalArray)
        {
            int length = originalArray.Length;
            int maxLength = originalArray.Max(s => s.Length);

            string[,] newArray = new string[length, maxLength];

            for (int i = 0; i < length; i++)
            {
                // Convert each string to an array of characters
                for (int j = 0; j < originalArray[i].Length; j++)
                {
                    newArray[i, j] = originalArray[i][j].ToString();
                }
            }

            return newArray;
        }

        public static void DisplayMultidimensionalArray(string[,] multidimensionalArray)
        {
            int rows = multidimensionalArray.GetLength(0);
            int cols = multidimensionalArray.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(multidimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
