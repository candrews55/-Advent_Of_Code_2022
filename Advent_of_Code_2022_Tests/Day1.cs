using System.IO;
using System.Linq;
using Advent_Of_Code_2022;
using Xunit;
using Xunit.Abstractions;

namespace Advent_of_Code_2022_Tests;

public class Day1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    #region Part 1
    
    [Fact]
    public void ShouldGetTheNumber24000()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day1ExampleData.txt"));
        
        // Act
        var results = Day1Helper.Day1Part1(testValues.ToList());
        
        // Assert
        Assert.Equal(24000, results);
    }

    [Fact]
    public void CalculateBiggestStoredFoodCache()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day1RealData.txt"));
        
        // Act
        var results = Day1Helper.Day1Part1(testValues.ToList());
        
        // Show Results
        _testOutputHelper.WriteLine(results.ToString());
    }
    #endregion

    #region Part 2

    [Fact]
    public void ShouldGetTotal45000FromTop3()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day1ExampleData.txt"));
        
        // Act
        var results = Day1Helper.Day1Part2(testValues.ToList());
        
        // Assert
        Assert.Equal(45000, results);
    }
    
    [Fact]
    public void GetTotalOfTop3CachesOfFood()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day1RealData.txt"));
        
        // Act
        var results = Day1Helper.Day1Part2(testValues.ToList());
        
        // Show Results
        _testOutputHelper.WriteLine(results.ToString());
    }
    
    #endregion
}