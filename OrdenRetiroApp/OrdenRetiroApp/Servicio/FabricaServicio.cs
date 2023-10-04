using OrdenRetiroApp.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Servicio
{
    public abstract class FabricaServicio
    {
        public abstract IServicioOrden CrearServicio();
    }
}
