namespace Advent_Of_Code_2022.Day4;

public static class Day4
{
    public static int Part1(List<string> values)
    {
        var pairsOfWork = values.Aggregate(new List<List<string>>(),
            (list, item) =>
            {
                var pairs = item.Split(',');
                list.Add(pairs.ToList());
                return list;
            });
        var pairsWithRanges = pairsOfWork.Select(p => p.Select(ConvertToInt).ToList()).ToList();
        var pairsWithCompleteOverlap = pairsWithRanges.Where(IsCompleteOverlap).ToList();
        return pairsWithCompleteOverlap.Count();
    }

    public static int Part2(List<string> values)
    {
        var pairsOfWork = values.Aggregate(new List<List<string>>(),
            (list, item) =>
            {
                var pairs = item.Split(',');
                list.Add(pairs.ToList());
                return list;
            });
        var pairsWithRanges = pairsOfWork.Select(p => p.Select(ConvertToInt).ToList()).ToList();
        var pairsWithCompleteOverlap = pairsWithRanges.Where(IsAnyOverlap).ToList();
        return pairsWithCompleteOverlap.Count();
    }

    private static List<int> ConvertToInt(string range)
    {
        var splitRange = range.Split('-').Select(int.Parse).ToList();
        return splitRange;
    }

    private static bool IsCompleteOverlap(List<List<int>> groupOfWork)
    {
        var firstElfArea = groupOfWork.First();
        var secondElfArea = groupOfWork.Last();
        var firstElfAreaCompleteOverlap = IsOverlapInRange(firstElfArea.First(), secondElfArea) &&
                                          IsOverlapInRange(firstElfArea.Last(), secondElfArea); 
        var secondElfAreaCompleteOverlap = IsOverlapInRange(secondElfArea.First(), firstElfArea) &&
                                          IsOverlapInRange(secondElfArea.Last(), firstElfArea); 
        return firstElfAreaCompleteOverlap || secondElfAreaCompleteOverlap;
    }

    private static bool IsAnyOverlap(List<List<int>> groupOfWork)
    {
        var firstElfArea = groupOfWork.First();
        var secondElfArea = groupOfWork.Last();
        var firstElfAreaCompleteOverlap = IsOverlapInRange(firstElfArea.First(), secondElfArea) ||
                                          IsOverlapInRange(firstElfArea.Last(), secondElfArea); 
        var secondElfAreaCompleteOverlap = IsOverlapInRange(secondElfArea.First(), firstElfArea) ||
                                          IsOverlapInRange(secondElfArea.Last(), firstElfArea); 
        return firstElfAreaCompleteOverlap || secondElfAreaCompleteOverlap;
    }

    private static bool IsOverlapInRange(int value, List<int> range)
    {
        var lowerBound = range.First();
        var upperBound = range.Last();
        return value >= lowerBound && value <= upperBound;
    }
}