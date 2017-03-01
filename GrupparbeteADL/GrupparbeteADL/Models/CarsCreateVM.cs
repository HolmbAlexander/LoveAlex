using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteADL.Models
{
    public class CarsCreateVM
    {
        [Display(Name = "Make")]
        [Required(ErrorMessage = "Enter valid brand.")]
        public string Brand { get; set; }

        [Display(Name = "Number of doors")]
        [Required(ErrorMessage = "Enter number of doors.")]
        [Range(3, 5, ErrorMessage = "Enter number between 3-5.")]
        public int Doors { get; set; }

        [Display(Name = "Top-speed")]
        [Required(ErrorMessage = "Enter valid top-speed.")]
        [Range(0, 300, ErrorMessage = "Enter valid top-speed between 0-300 km/h.")]
        public int TopSpeed { get; set; }
    }
}
