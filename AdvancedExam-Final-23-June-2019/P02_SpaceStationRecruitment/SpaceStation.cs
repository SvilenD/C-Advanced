namespace SpaceStationRecruitment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpaceStation
    {
        private Dictionary<string, Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new Dictionary<string, Astronaut>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count
        {
            get
            {
                return this.data.Count();
            }
        }

        public void Add(Astronaut astronaut)
        {
            var name = astronaut.Name;
            this.data.Add(name, astronaut);
        }

        public bool Remove(string name)
        {
            if (this.data.ContainsKey(name))
            {
                data.Remove(name);
                return true;
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            var astronaut = this.data
                .OrderByDescending(a => a.Value.Age)
                .FirstOrDefault().Value;

            return astronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            var astronaut = this.data
                .FirstOrDefault(a => a.Key == name).Value;

            return astronaut;
        }

        public string Report()
        {
            var report = new StringBuilder();
            report.AppendLine($"Astronauts working at Space Station { this.Name}:");
            report.AppendLine($"{string.Join(Environment.NewLine, this.data.Values)}");

            return report.ToString().TrimEnd();
        }
    }
}