// See https://aka.ms/new-console-template for more information
using AdventOfCode.Day3;

Console.WriteLine("Hello, World!");

var lines = File.ReadAllLines("test1.txt");
var convertedLines = Helpers.ConvertToMultidimensionalArray(lines);
var matrixTableWithBorder = Helpers.AddBorder(convertedLines);
Helpers.DisplayMultidimensionalArray(matrixTableWithBorder);

(int corX, int corY)[] directionsWithDiagonals = [
    (0, 1),
    (1, 0),
    (0, -1),
    (-1, 0),
    (1, 1),
    (-1, 1),
    (1, -1),
    (-1, -1)];

for (int i = 1; i <= lines.Length; i++)
{
    for (int j = 1; j <= lines[0].Length; j++)
    {

    }
}
