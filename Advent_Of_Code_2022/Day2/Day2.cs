namespace Advent_Of_Code_2022.Day2;

public static class Day2
{
    public static int Day2Part1(List<string> values)
    {
        var plays = values.Select(p =>
        {
            var moves = p.Split(' ');
            return (new RockPaperScissors(moves.First()), new RockPaperScissors(moves.Last()));
        });
        return plays.Select(p =>
        {
            if (p.Item1 > p.Item2) return 0 + p.Item2.PlayValue;
            return p.Item1 < p.Item2 ? 6 + p.Item2.PlayValue : 3 + p.Item2.PlayValue;
        }).Sum();
    }

    public static int Part2(List<string> values)
    {
        var plays = values.Select(p =>
        {
            var moves = p.Split(' ');
            return (new RockPaperScissors(moves.First()), moves.Last());
        });
        return plays.Select(p =>
        {
            return p.Item2.ToUpper() switch
            {
                // Need to lose
                "X" => (int)p.Item1.Beats(),
                // Need to draw
                "Y" => p.Item1.PlayValue + 3,
                // Need to win
                "Z" => (int)p.Item1.LosesTo() + 6,
                _ => throw new ArgumentOutOfRangeException()
            };
        }).Sum();
    }
}