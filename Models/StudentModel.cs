using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class StudentModel : BaseModel
    {
        [Key]
        public string StudId { get; set; }
        public string StudName { get; set; }
    }
}
