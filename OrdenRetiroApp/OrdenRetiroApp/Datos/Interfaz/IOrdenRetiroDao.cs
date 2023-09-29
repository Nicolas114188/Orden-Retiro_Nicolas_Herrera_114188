using OrdenRetiroApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Datos.Interfaz
{
    public interface IOrdenRetiroDao
    {
        List<Material> ObtenerMateriales();
        int Crear(OrdenRetiro orden);
    }
}
