using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Schedule.Models
{
    public class Event
    {

        [Key, ScaffoldColumn(false), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventID { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        [StringLength(10)]
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
        //[ForeignKey("Person")]
        //public int PersonId { get; set; }
        //public virtual Person Person { get; set; }
    }
}