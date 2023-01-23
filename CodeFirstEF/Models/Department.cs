using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }
        public string DeptSubName { get; set; }
       public Teacher Teacher { get; set; }
    }
}