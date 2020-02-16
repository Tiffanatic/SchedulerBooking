using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouncelingScheduler.domain.domain
{
    public class Calendar
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public ICollection<Timeslot> Timeslots { get; private set; }

        public ICollection<Hold> Holds { get; private set; }

        public Calendar(string name)
        {
            this.Id = new Guid();
            this.Name = name;
        }

        public void AddTimeSlot (Timeslot timeslot)
        {
            this.Timeslots.Add(timeslot);
        }

        public void AddHold(Hold hold)
        {
            this.Holds.Add(hold);
        }
    }
}
