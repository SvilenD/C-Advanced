namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Person> familyTree = new List<Person>();
        private static List<string> familyRelations = new List<string>();

        public static void Main()
        {
            var input = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();
                if (line?.ToLower() == "end")
                {
                    break;
                }
                else if (line.Contains('-') == false)
                {
                    var personInfo = line.Split();
                    var name = personInfo[0] + " " + personInfo[1];
                    var birthday = personInfo[2];
                    familyTree.Add(new Person(name, birthday));
                }
                else
                {
                    familyRelations.Add(line);
                }
            }

            foreach (var relation in familyRelations)
            {
                var personInfo = relation.Split('-').Select(x => x.Trim()).ToArray();
                var parentParam = personInfo[0];
                var childParam = personInfo[1];

                var parent = new Person();
                var child = new Person();

                parent = AddParentAndChildInfo(parentParam, parent);
                child = AddParentAndChildInfo(childParam, child);

                child.Parents.Add(parent);
                parent.Children.Add(child);
            }

            PrintQueryPerson(input);
        }

        public static Person AddParentAndChildInfo(string personInfo, Person person)
        {
            if (personInfo.Contains('/'))
            {
                person = familyTree.FirstOrDefault(p => p.Birthday == personInfo);
            }
            else
            {
                person = familyTree.FirstOrDefault(p => p.Name == personInfo);
            }
            return person;
        }

        private static void PrintQueryPerson(string data)
        {
            Person queryPerson;
            if (data.Contains('/'))
            {
                queryPerson = familyTree.FirstOrDefault(p => p.Birthday == data);
            }
            else
            {
                queryPerson = familyTree.FirstOrDefault(p => p.Name == data);
            }
            Console.WriteLine(queryPerson);
        }
    }
}