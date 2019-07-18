namespace Demo
{
    public class Dog : IAnimal
    {
        public Dog (string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public string SayHello()
        {
            return "Bark!";
        }
    }
}
