Console.WriteLine("Welcome to Tic-Tac-Toe!");

char[, ] gameBoard = new char[3, 3];

while (true)
{
    for (int i = 0; i < 9; i++)
    {
        Console.WriteLine($"It is {GetPlayerTurn(i)}'s turn.");

        PrintBoard(gameBoard);

        int choice = GetPlayerChoice();

        UpdateBoard(gameBoard, choice, GetPlayerTurn(i));
    }
}

char GetPlayerTurn(int round)
{
    char player;

    if (round % 2 == 0)
        player = 'X';
    else
        player = 'Y';
    return player;
}

int GetPlayerChoice()
{
    Console.Write("What square do you want to play in? ");
    int choice = Convert.ToInt32(Console.ReadLine());
    while (choice < 1 || choice > 9)
    {
        Console.Write("Invalid choice. Try Again. ");
        choice = Convert.ToInt32(Console.ReadLine());
    }
    return choice;
}

void PrintBoard(char[, ] currentBoard)
{
    Console.WriteLine($" {currentBoard[0, 0]}  | {currentBoard[0, 1]}  |  {currentBoard[0, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {currentBoard[1, 0]}  | {currentBoard[1, 1]}  |  {currentBoard[1, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {currentBoard[2, 0]}  | {currentBoard[2, 1]}  |  {currentBoard[2, 2]} ");
}

char[, ] UpdateBoard(char[, ] currentBoard, int playerChoice, char playerTurn)
{
    
    if (playerChoice == 1 || playerChoice == 2 || playerChoice == 3)
    {
        currentBoard[0, playerChoice] = playerTurn;
    }
    else if (playerChoice == 4 || playerChoice == 5 || playerChoice == 6)
    {
        currentBoard[1, playerChoice] = playerTurn;
    }
    else
        currentBoard[2, playerChoice] = playerTurn;
    return currentBoard;
}