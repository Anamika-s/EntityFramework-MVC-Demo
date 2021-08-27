using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork_MVCDemo.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public string BatchCode { get; set; }
        public string Course { get; set; }
    }
}
