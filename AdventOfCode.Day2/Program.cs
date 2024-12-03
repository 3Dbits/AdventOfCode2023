// See https://aka.ms/new-console-template for more information
using AdventOfCode.Day2;

var lines = File.ReadAllLines("input.txt");
var listOfGames = new List<Game>();

foreach (var line in lines)
{
    Game game = ParseInput(line);
    listOfGames.Add(game);
}

// check object logic and parse of data
//foreach (var games in listOfGames)
//{
//    Console.WriteLine(games.GameID);
//    foreach (var set in games.Sets)
//    {
//        Console.WriteLine($"red:{set.NumOfRedDices} blue:{set.NumOfBlueDices} green:{set.NumOfGreenDices}");
//    }
//}

// part 1
//int sum = 0;
//int maxRedDice = 12;
//int maxBlueDice = 14;
//int maxGreenDice = 13;

//foreach (var game in listOfGames)
//{
//    var isPosible = !game.Sets.Any(set => set.NumOfRedDices > maxRedDice || set.NumOfBlueDices > maxBlueDice || set.NumOfGreenDices > maxGreenDice);
//    if (isPosible)
//    {
//        sum += game.GameID;
//        // Console.WriteLine(game.GameID);
//    }
//}

//Console.WriteLine("Sum of games ID that is posible to play: " + sum);

// part 2
int sum = 0;

foreach (var game in listOfGames)
{
    (int blue, int red, int green) = (0, 0, 0);
    game.Sets.ForEach(set => {
        blue = set.NumOfBlueDices > blue ? set.NumOfBlueDices : blue;
        red = set.NumOfRedDices > red ? set.NumOfRedDices : red;
        green = set.NumOfGreenDices > green ? set.NumOfGreenDices : green;
    });

    sum += blue * red * green;
}

Console.WriteLine(sum);

static Game ParseInput(string input)
{
    Game game = new();
    game.ParseInput(input);
    return game;
}