using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class SubjectModel : BaseModel
    {
        [Key]
        public string SubjId { get; set; }
        public string  SubjName { get; set; }
    }
}
