using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouncelingScheduler.Application.Repository;
using CouncelingScheduler.domain.domain;

namespace CouncelingScheduler.Application.Commands
{
    public sealed class CreateCalender:ICreateCalender
    {
        private readonly CouncelingSchedulerRepo councelingSchedulerRepo;

        public CreateCalender(CouncelingSchedulerRepo councelingSchedulerRepo)
        {
            this.councelingSchedulerRepo = councelingSchedulerRepo;
        }

        public async Task<Guid> Execute(string name)
        {
            Calendar calendar = new Calendar(name);
            councelingSchedulerRepo.AddCalender(calendar);
            return calendar.Id;
        }
        public async Task<Guid> Execute(string name, Hold hold)
        {
            Calendar calendar = new Calendar(name);

            if (hold != null)
            {
                calendar.AddHold(hold);
            }
            councelingSchedulerRepo.AddCalender(calendar);
            return calendar.Id;
        }

    }
}
