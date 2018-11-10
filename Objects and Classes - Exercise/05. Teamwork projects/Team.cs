using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Teamwork_projects
{
    public class Team
    {
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new SortedSet<string>() { creator};
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public SortedSet<string> Members { get; set; }

        public override string ToString()
        {
            string members = string.Empty;
            foreach (var member in this.Members)
            {
                members += $"-- {member}{Environment.NewLine}";
            }

            string teamStr = $"{this.Name}{Environment.NewLine}" +
                $"- {this.Creator}{Environment.NewLine}" +
                $"{members}";

            return teamStr.Trim();
        }
    }
}
