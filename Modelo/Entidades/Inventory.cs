using System;
using System.Collections.Generic;


namespace Modelo.Entidades
{
    public class Inventory
    {
        public int inventoryID { get; set; }

        // Relación con Film
        public int filmID { get; set; }
        public Film film { get; set; }
        public int storeID { get; set; }
        public DateTime last_update { get; set; }
    }
}
