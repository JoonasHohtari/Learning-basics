Random attack = new Random();
int damage = 0;
int monsterHealth = 10;
int heroHealth = 10;

do
{
    Console.Write($"Hero attacks monster and deals {damage = attack.Next(1, 11)} damage. ");
    monsterHealth -= damage;
    Console.WriteLine($"Monster has {monsterHealth} health left.");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("You have defeated the monster!");
        break;
    }

    Console.Write($"Monster attacks hero and deals {damage = attack.Next(1, 11)} damage. ");
    heroHealth -= damage;
    Console.WriteLine($"Hero has {heroHealth} health left.");

    if (heroHealth <= 0)
    {
        Console.WriteLine("You have been defeated!");
        break;
    }

} while (monsterHealth > 0 && heroHealth > 0);