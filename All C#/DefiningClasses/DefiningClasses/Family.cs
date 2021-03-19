using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> currfamily;//could just be = new List<Person>()

        public Family()
        {
            this.CurrFamily = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.CurrFamily.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person(int.MinValue);
            foreach (Person person in CurrFamily)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            return oldest;
        }


        public List<Person> CurrFamily
        {
            get { return currfamily; }
            set { currfamily = value; }
        }
    }
}
