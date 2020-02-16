using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CouncelingScheduler.domain.domain;

namespace CouncelingScheduler.Application.Repository
{
    interface ICouncelingSchedulerRepo
    {
        public void AddCalender(Calendar calendar);
    }
}
