using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace CRUD.Models
{
    public class Consultant
    {
        [Key]
        public int consultantId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public String consultantName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public String tel { get; set; }


    }
}