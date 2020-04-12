namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Family
    {
        private List<Person> people; //initialize here like private List<Person> people = new List<Person>(); or in the constructor below 

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GerOldestMember()
        {
            return this.people.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
