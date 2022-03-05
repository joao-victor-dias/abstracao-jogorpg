public class Boss : Hero
{
    public Boss (string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;
    }

    public virtual string Attack(int valueAttack, int MagicPoints)
    {
        if (valueAttack >= 40 && MagicPoints >= 80)
        {
            return "\tATTACK CRÍTICO!! " + this.Name + " atacou e causou " + (valueAttack*1.3) + " HP de dano nos Heróis.";
        }
        else
        {
            return "\t" + this.Name + " atacou e causou " + valueAttack + " HP de dano nos Heróis.";
        }        
    }
}