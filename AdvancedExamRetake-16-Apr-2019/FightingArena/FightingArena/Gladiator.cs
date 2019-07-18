namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetWeaponPower()
        {
            return this.Weapon.Sharpness + this.Weapon.Solidity + this.Weapon.Size;
        }

        public int GetStatPower()
        {
            return this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence + this.Stat.Skills + this.Stat.Strength;
        }

        public int GetTotalPower()
        {
            return this.GetWeaponPower() + this.GetStatPower();
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.GetTotalPower()}]" +
                   $"  Weapon Power: [{this.GetWeaponPower()}]" +
                   $"  Stat Power: [{GetStatPower()}]";
        }
    }
}