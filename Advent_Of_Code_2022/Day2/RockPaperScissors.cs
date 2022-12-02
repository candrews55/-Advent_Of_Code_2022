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

    public static bool operator <(RockPaperScissors left, RockPaperScissors right)
    {
        return (left._playersChoice == RockPaperScissorsEnum.Rock &&
                right._playersChoice == RockPaperScissorsEnum.Paper) ||
               (left._playersChoice == RockPaperScissorsEnum.Scissors &&
                right._playersChoice == RockPaperScissorsEnum.Rock) ||
               (left._playersChoice == RockPaperScissorsEnum.Paper &&
                right._playersChoice == RockPaperScissorsEnum.Scissors);
    }

    public static bool operator >(RockPaperScissors left, RockPaperScissors right)
    {
        return (left._playersChoice == RockPaperScissorsEnum.Rock &&
                right._playersChoice == RockPaperScissorsEnum.Scissors) ||
               (left._playersChoice == RockPaperScissorsEnum.Scissors &&
                right._playersChoice == RockPaperScissorsEnum.Paper) ||
               (left._playersChoice == RockPaperScissorsEnum.Paper &&
                right._playersChoice == RockPaperScissorsEnum.Rock);
    }
}