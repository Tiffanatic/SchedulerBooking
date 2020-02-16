using System;
using System.Collections.Generic;

namespace CouncelingScheduler.domain.domain
{
    public class Hold
    {
        public Guid Id { get; private set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Student { get; private set; }

        public Calendar Calendar { get; set; }

        public Hold(Guid id)
        {
            this.Id = Id;
        }

        public void AddStudent(Student student)
        {
            this.Student.Add(student);
        }
    }
}