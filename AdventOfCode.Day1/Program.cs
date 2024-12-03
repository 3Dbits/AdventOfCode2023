// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;

var lines = File.ReadAllLines("input.txt");
var lineWithOnlyNumbers = new List<string>();
var resolut = new List<int>();

// part 1
//foreach (var line in lines)
//{
//    int firstNumber = GetFirstNumber(line);
//    int lastNumber = GetLastNumber(line);

//    resolut.Add(int.Parse($"{firstNumber}{lastNumber}"));
//    //Console.WriteLine($"For line '{line}', result is {firstNumber}{lastNumber}");
//}

// part 2
long counter = 0;
foreach (var line in lines)
{
    var cleanLine = line
        .Replace("one", "o1e")
        .Replace("two", "t2o")
        .Replace("three", "t3e")
        .Replace("four", "f4r")
        .Replace("five", "f5e")
        .Replace("six", "s6x")
        .Replace("seven", "s7n")
        .Replace("eight", "e8t")
        .Replace("nine", "n9e");

    var firstNumber = cleanLine.First(Char.IsDigit);
    var lastNumber = cleanLine.Last(Char.IsDigit);

    var combinedNumber = firstNumber.ToString() + lastNumber.ToString();

    counter += int.Parse(combinedNumber);
}

Console.WriteLine(counter);

static int GetFirstNumber(string input)
{
    return input.FirstOrDefault(char.IsDigit) - '0';
}

static int GetLastNumber(string input)
{
    return input.LastOrDefault(char.IsDigit) - '0';
}