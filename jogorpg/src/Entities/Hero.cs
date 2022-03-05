public abstract class Hero
{
    public Hero(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints )
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.HealthPoints = HealthPoints;
        this.MagicPoints = MagicPoints;        
    }

    public Hero()
    {        
    }
    
    public string Name {get; set; }
    public int Level {get; set; }
    public string HeroType {get; set; }
    public int HealthPoints {get; set; }
    public int MagicPoints {get; set;}


    public override string ToString()
    {
        return "\tName: " + this.Name + " | Level: " + this.Level 
            + "\n\tType: " + this.HeroType 
            + "\n\tHP: " + this.HealthPoints + " | MP: " + this.MagicPoints
            + "\n\t------------------------";
    }

   
    public virtual string Attack(int valueAttack, int MagicPoints)
    {
        if (valueAttack >= 60 && MagicPoints >= 500)
        {
            return "\tATTACK CRÍTICO!! " + this.Name + " atacou e causou " + (valueAttack*2) + " HP de dano no Boss.";
        }
        else
        {
            return "\t" + this.Name + " atacou e causou " + valueAttack + " HP de dano no Boss.";
        }        
    }
    
}