namespace DefiningClasses
{
    using System.Linq;
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> ListOfPeople = new List<Person>();

        public void AddMember(Person member)
        {
            ListOfPeople.Add(member);
        }

        public List<Person> AgeFilter(int ageLimit)
        {
            return ListOfPeople.Where(p => p.Age > ageLimit).ToList();
        }
    }
}