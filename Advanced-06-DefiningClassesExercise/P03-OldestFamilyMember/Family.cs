namespace DefiningClasses
{
    using System.Linq;
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> listOfPeople = new List<Person>();

        public void AddMember(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            var person = listOfPeople.FirstOrDefault(p => p.Age == listOfPeople.Max(x => x.Age));
            //listOfPeople.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }
    }
}
