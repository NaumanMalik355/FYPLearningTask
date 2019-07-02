using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This Field is Required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName ="varchar(10)")]
        [DisplayName("Emp. Code")]
        public int EmpCode { get; set; }
        [Column(TypeName ="varchar(100)")]
        [DisplayName("Position")]
        public string Position { get; set; }
        [Column(TypeName ="varchar(100)")]
        [DisplayName("Office Location")]
        public string officeLocation { get; set; }
    }
}
