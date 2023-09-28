using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenRetiroApp.Datos
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private SqlConnection conexion;
        private HelperDao() 
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-B2KQT83\SQLEXPRESS;Initial Catalog=Ordenes_retiro_materiales_114188;Integrated Security=True");
        }
        public static HelperDao ObtenerInstancia() 
        {
            if (instancia == null) 
            {
                instancia=new HelperDao();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion() 
        {
            return this.conexion;
        }
        public DataTable Consultar(string sp) 
        {
            DataTable dato = new DataTable();
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            dato.Load(cmd.ExecuteReader());
            conexion.Close();
            return dato;
        }
    }
}
