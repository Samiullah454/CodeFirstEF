using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int TeacherCnic { get; set; }
        public string TeacherSub { get; set; }
        public ICollection<Department> Deapartments { get; set; }

    }
}