namespace Advent_Of_Code_2022;

public static class Day1Helper
{
    public static int Day1Part1(List<string> calories)
    {
        var groupedCalories = calories.Aggregate(new List<List<int>> { new() },
            (list, value) =>
            {
                if (!string.IsNullOrWhiteSpace(value)) list.Last().Add(int.Parse(value));
                else list.Add(new List<int>());
                return list;
            });
        return groupedCalories.Select(g => g.Sum()).Max();
    }

    public static int Day1Part2(List<string> calories)
    {
        var groupedCalories = calories.Aggregate(new List<List<int>> { new() },
            (list, value) =>
            {
                if (!string.IsNullOrWhiteSpace(value)) list.Last().Add(int.Parse(value));
                else list.Add(new List<int>());
                return list;
            });
        var calculatedSums = groupedCalories.Select(g => g.Sum()).ToList();
        calculatedSums.Sort();
        calculatedSums.Reverse();
        return calculatedSums.GetRange(0, 3).Sum();
    }
}