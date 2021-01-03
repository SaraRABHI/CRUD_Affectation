using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Project
    {
        [Key]
        public int projectId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public String projectName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(1000)")]
        public String description { get; set; }


    }
}
