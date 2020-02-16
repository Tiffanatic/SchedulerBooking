using System;
using System.Collections.Generic;

namespace CouncelingScheduler.Application.Model
{
    public class HoldModel
    {
        public Guid Id { get; set; }

        public CalendarModel CalendarModel { get; set; }

        public ICollection<StudentModel> StudentModel { get; set; }
    }
}