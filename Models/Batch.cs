using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVCDemo.Models
{

    public class Batch
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Batch Code is must")]
        public string BatchCode { get; set; }
        
        
        [MinLength(6,ErrorMessage ="Min 6 characters are needed")]
        [StringLength(20, ErrorMessage ="Cannnot be more than 4")]
        [Required(ErrorMessage = "Course Name is must")]
        public string Course { get; set; }


        // Adding reference to dependent Entity
        public ICollection<Student> Students { get; set; }
    }
}
