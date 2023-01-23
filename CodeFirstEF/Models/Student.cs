using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DOB { get; set; }
        public string Class { get; set; }
        public int RollNumber { get; set; }
        public Grade Grade { get; set; }
    }
}