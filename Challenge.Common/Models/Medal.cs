namespace Challenge.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Medal
    {
        [Key]
        public int IdMedal { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime DateObtained { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
