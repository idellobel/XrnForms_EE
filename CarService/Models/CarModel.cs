using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        [Required]
        public string ModelNaam { get; set; }
        public int Bouwjaar { get; set; }
        public decimal Prijs { get; set; }
        public string Brandstof { get; set; }
        public bool EersteEigenaar { get; set; }

        //Foreign Key
        public int MerkId { get; set; }
        //Navigation property
        public virtual Merk Merk { get; set; }
    }
}