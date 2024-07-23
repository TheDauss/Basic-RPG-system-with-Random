Random roll = new Random();
int dice = roll.Next(1, 10);

int heroHP = 10;
int heroCurrentHP = 10;
int creatureHP = 10;
int creatureCurrentHP = 10;


do
{
    dice = roll.Next(1, 11);
    Console.WriteLine("----------------------");
    Console.WriteLine($"The hero has attacked the creature, dealing {dice} points of damage.");
    creatureCurrentHP = creatureCurrentHP - dice;
    Console.WriteLine($"The creature has {creatureCurrentHP}/{creatureHP}.");

    if (creatureCurrentHP <= 0)
        continue;

    dice = roll.Next(1, 11);
    Console.WriteLine("----------------------");
    Console.WriteLine($"The creature has attacked the hero, dealing {dice} points of damage.");
    heroCurrentHP = heroCurrentHP - dice;
    Console.WriteLine($"The hero has {heroCurrentHP}/{heroHP}.");

} while ((heroCurrentHP > 0) && (creatureCurrentHP > 0));

Console.WriteLine("--------------------WINNER--------------------");
Console.WriteLine(heroCurrentHP > creatureCurrentHP ? "Hero!" : "Monster!");