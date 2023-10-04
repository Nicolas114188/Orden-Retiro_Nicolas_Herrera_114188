using OrdenRetiroApp.Servicio.Implementacion;
using OrdenRetiroApp.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Servicio
{
    public class FabricaServicioImp : FabricaServicio
    {
        public override IServicioOrden CrearServicio()
        {
            return new ServicioOrden();
        }
    }
}
