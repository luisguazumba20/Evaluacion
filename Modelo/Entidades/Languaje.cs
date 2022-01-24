using System;
using System.Collections.Generic;

namespace Modelo.Entidades
{
    public class Languaje
    {
        public int languajeID { get; set; }
        public string name { get; set; }
        public DateTime last_update { get; set; }

        // Relación con Film
        public List<Film> Films { get; set; }
    }
}
