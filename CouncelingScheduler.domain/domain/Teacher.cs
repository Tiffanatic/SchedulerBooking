using System.Collections.Generic;

namespace CouncelingScheduler.domain.domain
{
    public class Teacher
    {
        public Name Name { get; set; }

        public ICollection<Hold> Holds { get; private set; }

        public Teacher(Name name)
        {
            this.Name = name;
        }

        public void AddHold(Hold hold)
        {
            this.Holds.Add(hold);
        }

        public void RemoveHold(Hold hold)
        {
            this.Holds.Remove(hold);
        }
    }
}