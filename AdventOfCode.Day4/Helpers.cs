using System.Text.RegularExpressions;

namespace AdventOfCode.Day4
{
    internal class Helpers
    {
        public static (Loto, Scratchcards) ParseCard(string card)
        {
            var parts = card.Split('|');
            var moreParts = parts[0].Split(':');
            var lotoGame = ExtractNumbers(moreParts[0]);
            var winningNumbers = ExtractNumbers(moreParts[1]);
            var numbersYouHave = ExtractNumbers(parts[1]);

            var loto = new Loto(winningNumbers, lotoGame.First());
            var scratchcards = new Scratchcards(numbersYouHave);
            Console.WriteLine(winningNumbers.Count + " " + numbersYouHave.Count);

            return (loto, scratchcards);
        }

        static List<int> ExtractNumbers(string input)
        {
            var numberMatches = Regex.Matches(input, @"\d+");
            return numberMatches.Select(match => int.Parse(match.Value)).ToList();
        }

        public static int CalculateLength(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return 1;
            }
            else
            {
                return (int)Math.Pow(2, array.Length - 1);
            }
        }
    }
}
