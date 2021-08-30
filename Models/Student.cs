using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVCDemo.Models
{
    [Table("tblStudent")]
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        [Column(name:"StudentName")]
        public string Name { get; set; }
        [Column(name:"StudentAddress")]
        public string Address { get; set; }


        // Add a Foreign Key
        public int BatchId { get; set; }
        [ForeignKey("BatchId")]
        public Batch Batch { get; set; }

    }
}
