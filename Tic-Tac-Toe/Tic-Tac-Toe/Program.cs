Console.WriteLine("Welcome to Tic-Tac-Toe!");

char[, ] gameBoard = new char[3, 3]
{
    { '7', '8', '9' },
    { '4', '5', '6' },
    { '1', '2', '3' }
};

for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"It is {GetPlayerTurn(i)}'s turn.");

    PrintBoard(gameBoard);

    int choice = GetPlayerChoice(gameBoard);

    UpdateBoard(gameBoard, choice, GetPlayerTurn(i));

    if (CheckForWin(gameBoard) == true && i < 9)
    {
        Console.Clear();
        Console.WriteLine($"{GetPlayerTurn(i)}'s win!!!");
        PrintBoard(gameBoard);
        break;
    }
    else if (i == 8)
    {
        Console.Clear();
        Console.WriteLine("It's a tie :(");
        PrintBoard(gameBoard);
    }
    else
        Console.Clear();
}

char GetPlayerTurn(int round)
{
    char player;

    if (round % 2 == 0)
        player = 'X';
    else
        player = 'O';
    return player;
}

int GetPlayerChoice(char[, ] currentBoard)
{
    int choice;
    bool isValidchoice = false;
    
    do 
    {
        Console.Write("What square do you want to play in? ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice < 1 || choice > 9)
        {
            Console.Write("Invalid choice. Try Again. ");
            continue;
        }

        int row = 2 - (choice - 1) / 3;
        int col = (choice - 1) % 3;

        if (currentBoard[row, col] == 'X' || currentBoard[row, col] == 'O')
        {
            Console.WriteLine("Invalid choice. Try Again. ");
        }
        else
        {
            isValidchoice = true;
        }
    }
    while (!isValidchoice);

    return choice;
}

void PrintBoard(char[, ] currentBoard)
{
    Console.WriteLine($" {currentBoard[0, 0]} | {currentBoard[0, 1]} | {currentBoard[0, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {currentBoard[1, 0]} | {currentBoard[1, 1]} | {currentBoard[1, 2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {currentBoard[2, 0]} | {currentBoard[2, 1]} | {currentBoard[2, 2]} ");
}

char[, ] UpdateBoard(char[, ] currentBoard, int playerChoice, char playerTurn)
{
    if (playerChoice == 1 || playerChoice == 2 || playerChoice == 3)
    {
        playerChoice = playerChoice - 1;
        currentBoard[2, playerChoice] = playerTurn;
    }
    else if (playerChoice == 4 || playerChoice == 5 || playerChoice == 6)
    {
        playerChoice = playerChoice - 4;
        currentBoard[1, playerChoice] = playerTurn;
    }
    else
    {
        playerChoice = playerChoice - 7;
        currentBoard[0, playerChoice] = playerTurn;
    }        
    return currentBoard;
}

bool CheckForWin(char[, ] currentBoard)
{
    if (currentBoard[0, 0] == currentBoard[0, 1] && currentBoard[0, 1] == currentBoard[0, 2])
    {
        return true;
    }
    else if (currentBoard[1, 0] == currentBoard[1, 1] && currentBoard[1, 1] == currentBoard[1, 2])
    {
        return true;
    }
    else if (currentBoard[2, 0] == currentBoard[2, 1] && currentBoard[2, 1] == currentBoard[2, 2])
    {
        return true;
    }
    else if (currentBoard[0, 0] == currentBoard[1, 0] && currentBoard[1, 0] == currentBoard[2, 0])
    {
        return true;
    }
    else if (currentBoard[0, 1] == currentBoard[1, 1] && currentBoard[1, 1] == currentBoard[2, 1])
    {
        return true;
    }
    else if (currentBoard[0, 2] == currentBoard[1, 2] && currentBoard[1, 2] == currentBoard[2, 2])
    {
        return true;
    }
    else if (currentBoard[0, 0] == currentBoard[1, 1] && currentBoard[1, 1] == currentBoard[2, 2])
    {
        return true;
    }
    else if (currentBoard[2, 0] == currentBoard[1, 1] && currentBoard[1, 1] == currentBoard[0, 2])
    {
        return true;
    }
    else
        return false;
}