// See https://aka.ms/new-console-template for more information
using AdventOfCode.Day4;

var lines = File.ReadAllLines("input.txt");

var cardList = new List<(Loto, Scratchcards)>();
foreach (var line in lines)
{
    cardList.Add(Helpers.ParseCard(line));
}

var winningNumbers = new List<int[]>();
Dictionary<int, long> numberOfScratchcards = [];

foreach (var card in cardList)
{
    var commonElements = card.Item1.WinningNumbers.Intersect(card.Item2.NumbersYouHave);
    //winningNumbers.Add(commonElements.ToArray()); // Part1
    Collector(commonElements.Count(), card.Item1.LotoId); // Part2
    // Console.WriteLine($"Wins GameID:{card.Item1.LotoId} count:{commonElements.Count()}");
}

long sumValues = 0;
foreach (var items in numberOfScratchcards)
{
    Console.WriteLine($"GameID:{items.Key} count:{items.Value}");
    sumValues += items.Value;
}

Console.WriteLine(sumValues);

// Part2
void Collector(int count, int gameId)
{
    var isGameCounted = numberOfScratchcards.TryGetValue(gameId, out long multiplier);
    if (!isGameCounted)
    {
        numberOfScratchcards.Add(gameId, 1);
    }
    else
    {
        numberOfScratchcards[gameId] += 1;
    }

    for (int j = 1; j <= multiplier + 1; j++)
    {
        for (int i = 1; i < count + 1; i++)
        {
            if (numberOfScratchcards.ContainsKey(gameId + i))
            {
                numberOfScratchcards[gameId + i] += 1;
            }
            else
            {
                numberOfScratchcards.Add(gameId + i, 1);
            }
        }
    }
    
}

// Part1
//int sum = 0;
//foreach (var item in winningNumbers)
//{
//    Console.WriteLine($"[{string.Join(", ", item)}] sum id {Helpers.CalculateLength(item)}");
//    sum += Helpers.CalculateLength(item);
//}
//Console.WriteLine(sum);
