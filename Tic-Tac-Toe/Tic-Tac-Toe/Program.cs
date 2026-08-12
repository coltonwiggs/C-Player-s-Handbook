TicTacToe game = new TicTacToe()

class TicTacToe
{
    private char _playerChoice;

    public TicTacToe(char playerChoice)
    {
        _playerChoice = playerChoice;
    }

    public char[,] gameBoard = new char[3, 3];
    
    public static void DrawGameBoard(char[] gameBoard)
    {
        Console.WriteLine($" {gameBoard[0]} | {gameBoard[1]} | {gameBoard[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {gameBoard[3]} | {gameBoard[4]} | {gameBoard[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {gameBoard[6]} | {gameBoard[7]} | {gameBoard[8]} ");
    }
}