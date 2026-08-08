while (true)
{
    Console.Write("Enter password: ");
    string enteredPassword = Console.ReadLine();
    PasswordValidator passwordValidator = new PasswordValidator(enteredPassword);
    Console.WriteLine(passwordValidator.AnalysePassword(enteredPassword));
}

public class PasswordValidator
{
    private string _password;

    public PasswordValidator(string password)
    {
        _password = password;
    }

    public string AnalysePassword(string password)
    {
        if (password.Length < 6 || password.Length > 13)
            return ("Invalid password.");

        else if (password.Count(char.IsUpper) < 1 || password.Count(char.IsLower) < 1)
            return ("Invalid password.");

        else if (password.Count(char.IsNumber) < 1)
            return ("Invalid password.");
        else if (password.Contains('T'))
            return ("Invalid password.");
        else if (password.Contains('&'))
            return ("Invalid password.");
        else
            return ("Valid password.");      
    }
}