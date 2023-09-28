using OrdenRetiroApp.Datos.Implementacion;
using OrdenRetiroApp.Datos.Interfaz;
using OrdenRetiroApp.Entidades;
using OrdenRetiroApp.Servicio.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Servicio.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDao dao;
        public Servicio() 
        {
            dao = new OrdenRetiroDao();
        }

        public int CrearOrdenRetiro(OrdenRetiro orden)
        {
            return dao.Crear(orden);
        }

        public List<Material> TraerMaterial()
        {
            return dao.ObtenerMateriales();
        }
    }
}
