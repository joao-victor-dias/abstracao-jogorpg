public class Knight : Hero
{
    public Knight(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;
    }

    public virtual string Attack(int valueAttack, int MagicPoints)
    {
        if (valueAttack >= 60 && MagicPoints >= 50)
        {
            return "\tATTACK CRÍTICO!! " + this.Name + " atacou e causou " + (valueAttack*1.5) + " HP de dano no Boss.";
        }
        else
        {
            return "\t" + this.Name + " atacou e causou " + valueAttack + " HP de dano no Boss.";
        }        
    }
}