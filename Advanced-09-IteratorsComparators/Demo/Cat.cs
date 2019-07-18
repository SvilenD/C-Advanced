namespace Demo
{
    public class Cat : IAnimal 
    {
        public Cat(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string SayHello()
        {
            return "Meow";
        }
    }
}
