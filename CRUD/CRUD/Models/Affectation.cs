using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Affectation
    {
        [Key]
        public int AffectationId { get; set; }
        public Project Project { get; set; }
        public Consultant Consultant { get; set; }
    }
}
