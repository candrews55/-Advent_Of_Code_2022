namespace Advent_Of_Code_2022.Day3;

public static class Day3
{
    private const int UpperCaseSubtractBy = 38;
    private const int LowerCaseSubtract = 96;
    private const int LowerBoundForUpperCaseChar = 65;
    private const int UpperBoundForUpperCaseChar = 90;

    public static int Part1(List<string> values)
    {
        var duplicateItems = values.Select(i =>
        {
            var firstCompartment = i[..(i.Length / 2)].ToList();
            var secondCompartment = i[(i.Length / 2)..].ToList();
            var results = firstCompartment.Intersect(secondCompartment);
            return results.First();
        }).ToList();
        return duplicateItems.Select(c =>
            c >= LowerBoundForUpperCaseChar && c <= UpperBoundForUpperCaseChar
                ? c - UpperCaseSubtractBy
                : c - LowerCaseSubtract).Sum();
    }

    public static int Part2(List<string> values)
    {
        var elvesGroupings = values.Aggregate(new List<List<string>> { new() }, (list, v) =>
        {
            if (list.Last().Count == 3) list.Add(new List<string>());
            list.Last().Add(v);
            return list;
        });

        var badges = elvesGroupings.Select(e =>
        {
            var sameItems = e[0].Intersect(e[1]);
            var allSameItems = e[2].Intersect(sameItems);
            return allSameItems.First();
        }).ToList();

        return badges.Select(b =>
            b >= LowerBoundForUpperCaseChar && b <= UpperBoundForUpperCaseChar
                ? b - UpperCaseSubtractBy
                : b - LowerCaseSubtract).Sum();
    }
}