namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private List<Hero> data = new List<Hero>();

        public int Count => this.data.Count;

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            data.RemoveAll(h => h.Name == name);
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.OrderByDescending(h => h.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.OrderByDescending(h => h.Item.Ability).FirstOrDefault();
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.OrderByDescending(h => h.Item.Intelligence).FirstOrDefault();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var Hero in data)
            {
                result.AppendLine(Hero.ToString());
            }
            return result.ToString().Trim();
        }
    }
}