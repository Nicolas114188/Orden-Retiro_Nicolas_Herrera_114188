using OrdenRetiroApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Servicio.Interfaz
{
    public interface IServicioOrden
    {
        List<Material> TraerMaterial();
        int CrearOrdenRetiro(OrdenRetiro ordenRetiro);
    }
}
