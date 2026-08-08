int manticoreHealth = 10;
int cityHealth = 15;
int roundCount = 1;
int cannonRange;
string damageType;
int damage;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int distance = Convert.ToInt32(Console.ReadLine());
while (distance < 0 || distance > 100) {
    Console.Write("Distance must be between 0 and 100. Enter a new distance: ");
    distance = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
Console.WriteLine("Player 2, it is your turn.");

while (manticoreHealth > 0 && cityHealth > 0)
{
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine($"STATUS: Round: {roundCount} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {CannonDamage(roundCount)} damage this round.");
    Console.Write("Enter desired cannon range: ");
    cannonRange = Convert.ToInt32(Console.ReadLine());
    while (cannonRange < 0 || cannonRange > 100)
    {
        Console.Write("Cannon range must be between 0 and 100. Enter a new range: ");
        cannonRange = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(DamageMessage(cannonRange));
    manticoreHealth = manticoreHealth - DamageAmount(cannonRange);
    cityHealth--;
    roundCount++;
}

if (manticoreHealth <= 0)
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
if (cityHealth <= 0 || (cityHealth <= 0 && manticoreHealth <= 0))
    Console.WriteLine("The Manticore has destroyed Consolas. GAME OVER");

int CannonDamage(int round)
{
    if (round % 3 == 0 && round % 5 == 0)
        return 10;
    else if (round % 3 == 0)
        return 3;
    else if (round % 5 == 0)
        return 3;
    else
        return 1;
}

int DamageAmount(int cannonRange)
{
    if (cannonRange == distance)
    {
        damage = CannonDamage(roundCount);
    }
    else
    {
        damage = 0;
    }
    return damage;
}

string DamageMessage(int cannonRange)
{
    if (cannonRange == distance)
    {
        damageType = "That round was a DIRECT HIT!";
    }
    else if (cannonRange > distance)
    {
        damageType = "That round OVERSHOT the target.";
    }
    else
    {
        damageType = "That round FELL SHORT of the target.";
    }
    return damageType;
}
