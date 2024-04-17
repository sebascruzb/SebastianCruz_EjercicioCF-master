﻿using System.ComponentModel.DataAnnotations;

namespace SebastianCruz_EjercicioCF.Models
{
    public class Burguer
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
    }
}
