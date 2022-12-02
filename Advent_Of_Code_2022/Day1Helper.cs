namespace Advent_Of_Code_2022;

public static class Day1Helper
{
    public static List<List<int>> GroupCalories(List<string> calories)
    {

        var results = new List<List<int>>();
        var group = new List<int>();
        foreach (var caloric in calories)
        {
            if (string.IsNullOrWhiteSpace(caloric))
            {
               results.Add(group);
               group = new List<int>();
               continue;
            }
            group.Add(int.Parse(caloric));
        }
        if(group.Any()) results.Add(group);

        return results;
    }

    public static int GetMaximumCalories(List<List<int>> foodGrouping)
    {
        return foodGrouping.Select(g => g.Sum()).Max();
    }

    public static int GetTop3MaximumCaloriesCaches(List<List<int>> foodGrouping)
    {
        var calculatedSums = foodGrouping.Select(g => g.Sum()).ToList();
        calculatedSums.Sort();
        calculatedSums.Reverse();
        return calculatedSums.GetRange(0, 3).Sum();
    }
}