namespace AdventOfCode.Day4
{
    internal class Scratchcards
    {
        public List<int> NumbersYouHave {  get; set; }

        public Scratchcards(List<int> numbers) 
        { 
            NumbersYouHave = numbers;
        }
    }

    internal class Loto
    {
        public int LotoId { get; set; }
        public List<int> WinningNumbers { get; set; }

        public Loto(List<int> numbers, int lotoId)
        {
            WinningNumbers = numbers;
            LotoId = lotoId;
        }
    }
}
