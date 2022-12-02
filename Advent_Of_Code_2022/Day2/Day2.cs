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
}