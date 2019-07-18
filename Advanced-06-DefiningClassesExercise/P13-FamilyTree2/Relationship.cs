namespace DefiningClasses
{
    public class Relationship
    {
        public Relationship(Person parent, Person child)
        {
            this.Parent = parent;
            this.Child = child;
        }

        public Person Parent { get; set; }
        public Person Child { get; set; }
    }
}