﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Entidades
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public String Responsable { get; set; }
        public List<DetalleOrden> Detalles { get; set; }
        public OrdenRetiro()
        {
                Detalles = new List<DetalleOrden>();
        }
        public void AgregarDetalle(DetalleOrden detalle) 
        {
            Detalles.Add(detalle);
        }
        public void QuitarDetalle(int indice) 
        {
            Detalles.RemoveAt(indice);
        }
    }
}
