namespace HealthyHeaven
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Restaurant
    {
        private List<Salad> data;
        public string Name { get; private set; }

        public Restaurant(string name)
        {
            this.Name = name;
            this.data = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            this.data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (this.data.Any(s=>s.Name == name))
            {
                this.data.RemoveAll(s => s.Name == name);
                return true;
            }

            return false;
        }

        public Salad GetHealthiestSalad()
        {
            return this.data.OrderBy(s => s.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine($"{this.Name} have {data.Count} salads:)");
            menu.AppendLine($"{string.Join(Environment.NewLine, data)}");

            return menu.ToString().Trim();
        }
    }
}
