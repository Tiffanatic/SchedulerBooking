using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouncelingScheduler.Application.Model
{
    public class CalendarModel
    {
        public Guid Id { get; set; }

        public ICollection<TimeslotModel> TimeslotModels { get; set; }

        public ICollection<HoldModel> HoldModels { get; set; }
    }
}
