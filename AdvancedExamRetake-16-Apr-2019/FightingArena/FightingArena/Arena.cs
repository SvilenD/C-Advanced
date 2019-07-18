namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count => this.gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            this.gladiators.RemoveAll(g => g.Name == name);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            return gladiators.OrderByDescending(g => g.GetStatPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            return gladiators.OrderByDescending(g => g.GetWeaponPower()).FirstOrDefault();
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            return gladiators.OrderByDescending(g => g.GetTotalPower()).FirstOrDefault();
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }
    }
}