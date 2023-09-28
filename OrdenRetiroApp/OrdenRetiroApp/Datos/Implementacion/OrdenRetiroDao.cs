using OrdenRetiroApp.Datos.Interfaz;
using OrdenRetiroApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Datos.Implementacion
{
    public class OrdenRetiroDao : IOrdenRetiroDao
    {
        public int Crear(OrdenRetiro oOrdenRetiro)
        {
            int nroOrden = 0;
            SqlConnection cnn = HelperDao.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_ORDEN";
                cmd.Parameters.AddWithValue("@responsable", oOrdenRetiro.Responsable);
                SqlParameter pararmetro = new SqlParameter();
                pararmetro.ParameterName = "@nro";
                pararmetro.SqlDbType = SqlDbType.Int;
                pararmetro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pararmetro);
                cmd.ExecuteNonQuery();
                nroOrden = (int)pararmetro.Value;
                int nroDetalle = 1;
                SqlCommand cmdDetalle;
                foreach (DetalleOrden detalle in oOrdenRetiro.Detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nroDetalle", nroDetalle);
                    cmdDetalle.Parameters.AddWithValue("@nroOrden", nroOrden);
                    cmdDetalle.Parameters.AddWithValue("@codigo", detalle.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    nroDetalle++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
            }
            finally 
            {
                if(cnn!=null&&cnn.State==ConnectionState.Open)
                    cnn.Close();
            }
            return nroOrden;
        }

        public List<Material> ObtenerMateriales()
        {
            List<Material> lMateriales = new List<Material>();
            DataTable data = HelperDao.ObtenerInstancia().Consultar("Consultar_Materiales");
            return lMateriales;
        }
    }
}
