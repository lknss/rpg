namespace MyNamespace;
internal class Unit
{
    private int currentHp;
    private int maxHp;
    private int attackPower;
    private int healPower;
    private string unitName;
    private Random random;

public int Hp {get {return currentHp;} }
public string UnitName {get {return unitName;}}

public Boolean isDead {get {return currentHp <= 0;}}


    public Unit(int maxHp, int attackPower, int healPower, string unitName)
    {
        this.maxHp = maxHp;
        this.currentHp = maxHp;
        this.attackPower = attackPower;
        this.healPower = healPower;
        this.unitName = unitName;
        this.random = new Random();
    }

    public void Attack(Unit unitToAttack)
    {
        double rng = random.NextDouble();
        rng = rng / 2 + 0.75f;
        int randDmg = (int)(attackPower * rng);
        unitToAttack.takeDamage(randDmg);
        Console.WriteLine(unitName + " attacks " + unitToAttack.unitName + " and deals " + randDmg + " damage.");
    }

    public void takeDamage(int damage)
    {
        currentHp -= damage;
        
        if(isDead)
            Console.WriteLine(unitName + " has been defeated.");
    }

    public void Heal()
    {
        double rng = random.NextDouble();
        rng = rng / 2 + 0.75f;
        int heal = (int)(healPower * rng);
        currentHp = heal + currentHp > maxHp ? maxHp : currentHp + heal;
        Console.WriteLine(UnitName + " heals " + heal );
        
    }
}
