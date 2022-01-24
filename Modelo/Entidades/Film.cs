using System;
using System.Collections.Generic;

namespace Modelo.Entidades
{
    public class Film
    {
        public int filmID { get; set; }

        // Relación con Languaje
        public int languajeID { get; set; }
        public Languaje languaje { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public DateTime release_year { get; set; }
        public string rental_duration { get; set; }
        public string length { get; set; }
        public double replacement_cost { get; set; }
        public string rating { get; set; }
        public DateTime last_update { get; set; }
        public string special_features { get; set; }
        public string full_text { get; set; }

        // Relación con Inventory
        public List<Inventory> Inventories { get; set; }
    }
}
