using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Entidades
{
    public class DetalleOrden
    {
        public Material Material { get; set; }
        public int Cantidad { get; set; }
        public DetalleOrden(Material m,int cant)
        {
            Material = m;
            Cantidad = cant;
        }
    }
}
