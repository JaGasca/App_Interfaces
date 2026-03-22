using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces
{ 
    public class AgregarAlPedido
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public AgregarAlPedido(string producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
    }
    
}
