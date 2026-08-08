while (true)
{
    Console.Write("Player 1, Enter your choice (Rock, Paper, or Scissors): ");
    string? playerOneChoice = Console.ReadLine();
    if (playerOneChoice == null) break;
    Choice player1Choice = GetChoice(playerOneChoice);
    Console.Clear();

    Console.Write("Player 2, Enter your choice (Rock, Paper, or Scissors): ");
    string? playerTwoChoice = Console.ReadLine();
    if (playerOneChoice == null) break;
    Choice player2Choice = GetChoice(playerTwoChoice);
    Console.Clear();

    Choice GetChoice(string choice)
    {
        return choice switch
        {
            "Rock" => Choice.Rock,
            "Paper" => Choice.Paper,
            "Scissors" => Choice.Scissors
        };
    }

    Game game = new Game(player1Choice, player2Choice);

    Console.WriteLine(game.MatchResult(player1Choice, player2Choice));
}

public class Game
{
    private Choice _playerOneChoice;
    private Choice _playerTwoChoice;

    public Game(Choice playerOneChoice, Choice playerTwoChoice)
    {
        _playerOneChoice = playerOneChoice;
        _playerTwoChoice = playerTwoChoice;
    }

    public string MatchResult(Choice playerOneChoice, Choice playerTwoChoice)
    {
        if ((playerOneChoice == Choice.Rock && playerTwoChoice == Choice.Scissors) ||
            (playerOneChoice == Choice.Paper && playerTwoChoice == Choice.Rock) ||
            (playerOneChoice == Choice.Scissors && playerTwoChoice == Choice.Paper))
            return "Player One Wins!";
        else if ((playerOneChoice == Choice.Rock && playerTwoChoice == Choice.Paper) ||
                (playerOneChoice == Choice.Paper && playerTwoChoice == Choice.Scissors) ||
                (playerOneChoice == Choice.Scissors && playerTwoChoice == Choice.Rock))
            return "Player Two Wins!";
        else
            return "Tie!";
    }
}

public enum Choice { Rock, Paper, Scissors }