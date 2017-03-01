using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteADL.Models
{
    public class CarsIndexVM
    {
        [Display(Name = "Car brand")]
        public string Brand { get; set; }


        public bool ShowAsFast { get; set; }
    }
}
