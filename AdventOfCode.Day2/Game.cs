using System.Text.RegularExpressions;

namespace AdventOfCode.Day2
{
    internal class Game
    {
        static int increment = 1;

        public int GameID {  get; set; }
        public List<Set>? Sets { get; set; }

        public Game() 
        { 
            GameID = increment;
            increment++;
        }

        public void ParseInput(string input)
        {
            Sets = new List<Set>();

            // Split input by semicolon and iterate through sets
            var setStrings = input.Split(';');
            foreach (var setString in setStrings)
            {
                var set = new Set();
                // Extract numbers and colors using regular expression
                var matches = Regex.Matches(setString, @"(\d+)\s*([a-zA-Z]+)");

                foreach (Match match in matches)
                {
                    var count = int.Parse(match.Groups[1].Value);
                    var color = match.Groups[2].Value.ToLower(); // Convert to lowercase for case-insensitivity

                    // Assign count to corresponding color property
                    switch (color)
                    {
                        case "red":
                            set.NumOfRedDices = count;
                            break;
                        case "blue":
                            set.NumOfBlueDices = count;
                            break;
                        case "green":
                            set.NumOfGreenDices = count;
                            break;
                            // Handle other colors if needed
                    }
                }

                Sets.Add(set);
            }
        }
    }

    internal class Set
    {
        public int NumOfRedDices { get; set; }
        public int NumOfBlueDices { get; set; }
        public int NumOfGreenDices { get; set; }
    }
    
}
