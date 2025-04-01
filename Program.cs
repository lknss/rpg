using MyNamespace;

Unit player = new Unit(100, 20, 11, "Player");
Unit enemy = new Unit(75, 10, 7, "Skelton");
Random random = new Random();
while (!player.isDead && !enemy.isDead)
{
    Console.WriteLine(player.UnitName + " HP equals " + player.Hp + ". " + enemy.UnitName + " HP equals " + enemy.Hp +
                      ".");
    Console.WriteLine("Player's Turn What would you like to do?");
    string choice = Console.ReadLine();

    if (choice == "a")
        player.Attack(enemy);
    else
        player.Heal();

    if (player.isDead || enemy.isDead) break;

    Console.WriteLine(player.UnitName + " HP equals " + player.Hp + ". " + enemy.UnitName + " HP equals " + enemy.Hp +
                      ".");

    Console.WriteLine("Enemy's Turn");

    int rand = random.Next(0, 2);

    if (rand == 0)
        enemy.Attack(player);
    else
        enemy.Heal();

}
        