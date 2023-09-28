﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Entidades
{
    public class Material
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public Material(int cod, string nom, int stock)
        {
            Codigo = cod;
            Nombre = nom;
            Stock = stock;
        }
    }
}
