using System.IO;
using Advent_Of_Code_2022;
using Xunit;
using Xunit.Abstractions;

namespace Advent_of_Code_2022_Tests;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void TestFileLoad()
    {
        var path = UsefulConstants.DataFilesPath;
        var lines = File.ReadAllLines(Path.Combine(path, "Day_0_Hello_World.txt"));
        
        Assert.Equal(3, lines.Length);
        _testOutputHelper.WriteLine($"{lines[0]} {lines[1]}{lines[2]}");
    }
}