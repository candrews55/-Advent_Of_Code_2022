using System.IO;
using System.Linq;
using Advent_Of_Code_2022;
using Advent_Of_Code_2022.Day3;
using Xunit;
using Xunit.Abstractions;

namespace Advent_of_Code_2022_Tests;

public class Day3Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day3Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    #region Part 1
    
    [Fact]
    public void ShouldGet157()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day3ExampleData.txt"));
        
        // Act
        var results = Day3.Part1(testValues.ToList());
        
        // Assert
        Assert.Equal(157, results);
    }

    [Fact]
    public void Day3Part1()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day3RealData.txt"));
        
        // Act
        var results = Day3.Part1(testValues.ToList());
        
        // Show Results
        _testOutputHelper.WriteLine(results.ToString());
    }
    #endregion

     #region Part 2

     [Fact]
     public void ShouldGet70()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day3ExampleData.txt"));
         
         // Act
         var results = Day3.Part2(testValues.ToList());
         
         // Assert
         Assert.Equal(70, results);
     }
     
     [Fact]
     public void Day3Part2()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day3RealData.txt"));
         
         // Act
         var results = Day3.Part2(testValues.ToList());
         
         // Show Results
         _testOutputHelper.WriteLine(results.ToString());
     }
     
     #endregion
}