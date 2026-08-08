using System;

(Type type, MainIngrediant ingrediant, Seasoning seasoning)[] soups = new (Type, MainIngrediant, Seasoning)[3];
for (int i = 0; i < soups.Length; i++)
    soups[i] = GetSoup();

foreach (var soup in soups)
    Console.WriteLine($"{soup.seasoning} {soup.ingrediant} {soup.type}");

(Type, MainIngrediant, Seasoning) GetSoup()
{
    Type type = GetSoupType();
    MainIngrediant ingrediant = GetMainIngrediant();
    Seasoning seasoning = GetSeasoning();
    return (type, ingrediant, seasoning);
}

Type GetSoupType()
{
    Console.Write("Soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => Type.Soup,
        "stew" => Type.Stew,
        "gumbo" => Type.Gumbo
    };
}

MainIngrediant GetMainIngrediant()
{
    Console.Write("Main Ingrediant type (mushrooms, chicken, carrots, potatoes): ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushrooms" => MainIngrediant.Mushrooms,
        "chicken" => MainIngrediant.Chicken,
        "carrots" => MainIngrediant.Carrots,
        "potatoes" => MainIngrediant.Potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Seasoning type (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

enum Type { Soup , Stew , Gumbo }
enum MainIngrediant { Mushrooms , Chicken , Carrots , Potatoes }
enum Seasoning { Spicy , Salty , Sweet }