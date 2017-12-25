using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarService.Models
{
    public class Merk
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CarModel> CarModellen { get; set; }
    }
}