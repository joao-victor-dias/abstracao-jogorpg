public class Wizard : Hero
{
    public Wizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;
    }

    public virtual string Attack(int valueAttack, int MagicPoints)
    {
        if (valueAttack >= 60 && MagicPoints >= 70)
        {
            return "\tATTACK CRÍTICO!! " + this.Name + " lançou sua magia e causou " + (valueAttack*3) + " HP de dano no Boss.";
        }
        else
        {
            return "\t" + this.Name + " lançou sua magia e causou " + valueAttack + " HP de dano no Boss.";
        }        
    }
}