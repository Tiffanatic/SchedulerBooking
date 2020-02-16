using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CouncelingScheduler.Application.Commands;
using CouncelingScheduler.Application.Repository;
using CouncelingScheduler.domain.domain;

namespace CouncelingScheduler.WebApi.UseCases
{
    [Route("api/[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ICreateCalender createCalender;
        

        public CalendarController(ICreateCalender createCalender)
        {
            this.createCalender = createCalender;
            
        }

        public Task<Guid> Create(string name)
        {
            try
            {
                var id = createCalender.Execute(name);

                return id;
            }
            catch
            {
                throw new Exception();
            }
            
        }
    }
}