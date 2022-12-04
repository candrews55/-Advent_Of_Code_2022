using System.IO;
using System.Linq;
using Advent_Of_Code_2022;
using Advent_Of_Code_2022.Day4;
using Xunit;
using Xunit.Abstractions;

namespace Advent_of_Code_2022_Tests;

public class Day4Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day4Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    #region Part 1
    
    [Fact]
    public void ShouldGet2()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day4ExampleData.txt"));
        
        // Act
        var results = Day4.Part1(testValues.ToList());
        
        // Assert
        Assert.Equal(2, results);
    }

    [Fact]
    public void Day3Part1()
    {
        // Arrange
        var path = UsefulConstants.DataFilesPath;
        var testValues = File.ReadAllLines(Path.Combine(path, "Day4RealData.txt"));
        
        // Act
        var results = Day4.Part1(testValues.ToList());
        
        // Show Results
        _testOutputHelper.WriteLine(results.ToString());
    }
    #endregion

     #region Part 2

     [Fact]
     public void ShouldGet4()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day4ExampleData.txt"));
         
         // Act
         var results = Day4.Part2(testValues.ToList());
         
         // Assert
         Assert.Equal(4, results);
     }
     
     [Fact]
     public void Day3Part2()
     {
         // Arrange
         var path = UsefulConstants.DataFilesPath;
         var testValues = File.ReadAllLines(Path.Combine(path, "Day4RealData.txt"));
         
         // Act
         var results = Day4.Part2(testValues.ToList());
         
         // Show Results
         _testOutputHelper.WriteLine(results.ToString());
     }
     
     #endregion
}