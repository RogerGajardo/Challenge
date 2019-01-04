namespace Challenge.Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        [Key]
        public int IdUser { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FatherLastName { get; set; }

        [Required]
        public string MotherLastName { get; set; }

        [Required]
        public string CurrentWorkPosition { get; set; }

        public int AccumulatedPoints { get; set; }

        public string ProfileImage { get; set; }


    }
}
