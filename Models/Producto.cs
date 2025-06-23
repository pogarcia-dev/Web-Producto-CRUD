using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyProductoCRUD.Models {
    public class Producto {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        
        public Producto() {
            Id = 0;
            Descripcion = string.Empty;
            CategoriaId = 0;
            Precio = 0.0m;
            Stock = 0;
        }

        public Producto(int id, string descripcion, int categoriaId, decimal precio, int stock) {
            Id = id;
            Descripcion = descripcion;
            CategoriaId = categoriaId;
            Precio = precio;
            Stock = stock;
        }

        public override string ToString() {
            return "Producto " + Id + " - " + Descripcion +
                   " (IdCategoria: " + CategoriaId + ", Precio: " + Precio.ToString("C") +
                   ", Stock: " + Stock + ")";
        }
    }
}