using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Oldest_Family_Member
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            var ordered = this.Members.OrderByDescending(x => x.Age);
            return ordered.First();
        }
    }
}
