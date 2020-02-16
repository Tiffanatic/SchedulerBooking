using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CouncelingScheduler.Application.Commands
{
    public interface ICreateCalender
    {
        Task<Guid> Execute(string name);
    }
}
