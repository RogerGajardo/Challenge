namespace Challenge.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Events
    {
        [Key]
        public int IdEvento { get; set; }

        [Required]
        public string Name { get; set; }


        public int TotalPoints { get; set; }
    }
}
