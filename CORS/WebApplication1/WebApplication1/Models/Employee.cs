using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        //[ForeignKey("ApplicationUser")]
        //public string UserId { get; set; }
        ////  public  ApplicationUser ApplicationUser { get; set; }
        //public  ApplicationUser ApplicationUser { get; set; }

          public string UserId { get; set; }
          [ForeignKey("UserId")]
        //  public  ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int EmployeeId { get; set; }
        public string OfficeLocation { get; set; }

    }
}
