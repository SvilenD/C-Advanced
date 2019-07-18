namespace Heroes
{
    using System.Text;

    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Item:");
            result.AppendLine($"  * Strength: {this.Strength} ");
            result.AppendLine($"  * Ability: {this.Ability}");
            result.AppendLine($"  * Intelligence: {this.Intelligence}");

            return result.ToString().TrimEnd();
        }
    }
}