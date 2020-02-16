using System;
using System.Collections.Generic;

namespace CouncelingScheduler.Application.Model
{
    public class TimeslotModel
    {
        public Guid Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public ICollection<BookingModel> BookingModels { get; set; }

    }
}