using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class CarModelDTO
    {
        public int Id { get; set; }
        public string ModelNaam { get; set; }
        public string MerkName { get; set; }
    }

    public class CarModelDetailDTO
    {
        public int Id { get; set; }
        public string ModelNaam { get; set; }
        public int Bouwjaar { get; set; }
        public decimal Prijs { get; set; }
        public int MerkId { get; set; }
        public string MerkName { get; set; }
        public string Brandstof { get; set; }
        public bool EersteEigenaar { get; set; }
    }

    public class MerkDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}