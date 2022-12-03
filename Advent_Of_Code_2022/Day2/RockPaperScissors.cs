namespace Advent_Of_Code_2022.Day2;

public class RockPaperScissors
{
    private readonly RockPaperScissorsEnum _playersChoice;

    public int PlayValue => (int)_playersChoice;

    public RockPaperScissors(string encodedPlay)
    {
        switch (encodedPlay.ToUpper())
        {
            case "A":
            case "X":
                _playersChoice = RockPaperScissorsEnum.Rock;
                break;
            case "B":
            case "Y":
                _playersChoice = RockPaperScissorsEnum.Paper;
                break;
            case "C":
            case "Z":
                _playersChoice = RockPaperScissorsEnum.Scissors;
                break;
        }
    }

    public RockPaperScissorsEnum Beats()
    {
        return _playersChoice switch
        {
            RockPaperScissorsEnum.Rock => RockPaperScissorsEnum.Scissors,
            RockPaperScissorsEnum.Paper => RockPaperScissorsEnum.Rock,
            RockPaperScissorsEnum.Scissors => RockPaperScissorsEnum.Paper,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public RockPaperScissorsEnum LosesTo()
    {
        return _playersChoice switch
        {
            RockPaperScissorsEnum.Rock => RockPaperScissorsEnum.Paper,
            RockPaperScissorsEnum.Paper => RockPaperScissorsEnum.Scissors,
            RockPaperScissorsEnum.Scissors => RockPaperScissorsEnum.Rock,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}