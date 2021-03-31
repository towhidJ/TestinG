using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestinG.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Roll { get; set; }

        public int? DepId { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}