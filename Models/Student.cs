using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gitIgnoreEx.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public int SRollNo { get; set; }
    }
}

