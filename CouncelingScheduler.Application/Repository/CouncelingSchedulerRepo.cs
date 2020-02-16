using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouncelingScheduler.Application.DbContext;
using CouncelingScheduler.domain.domain;

namespace CouncelingScheduler.Application.Repository
{
    public class CouncelingSchedulerRepo : ICouncelingSchedulerRepo
    {
        private CouncelingSchedulerContext _context;

        public CouncelingSchedulerRepo(CouncelingSchedulerContext context)
        {
            this._context = context;
        }

        public void AddCalender(Calendar calendar)
        {

            if (calendar == null )
            {
                throw new NullReferenceException();
            }

            _context.Calendars.Add(calendar);
            _context.SaveChanges();
        }


    }
}
