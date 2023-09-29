using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrdenRetiroApp.Servicio.Interfaz;
using OrdenRetiroApp.Servicio.Implementacion;
using OrdenRetiroApp.Entidades;

namespace OrdenRetiroApp
{
    public partial class FrmOrdenRetiro : Form
    {
        private IServicioOrden servicio = null;
        OrdenRetiro ordenRetiro = null;

        public FrmOrdenRetiro()
        {
            InitializeComponent();
            servicio = new ServicioOrden();
            ordenRetiro = new OrdenRetiro();
        }
        private void FrmOrdenRetiro_Load(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Today.ToShortDateString();
            CargarCombo();

        }
        private void CargarCombo()
        {
            cboMaterial.DataSource = servicio.TraerMaterial();
            cboMaterial.ValueMember = "codigo";
            cboMaterial.DisplayMember = "nombre";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                /*foreach () 
                {

                }*/
                Material material=(Material)cboMaterial.SelectedItem;
                int cant = int.Parse(nudCantidad.Value.ToString());
                if (material.Stock < cant) 
                {
                    MessageBox.Show("No hay en Stock suficiente","Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                DetalleOrden detalle = new DetalleOrden(material,cant);
                ordenRetiro.AgregarDetalle(detalle);
            }
            else 
            {
                MessageBox.Show("Se a ingresado incorrecto los datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
        }

        private bool Validar()
        {
            bool val = true;
            if(cboMaterial.SelectedIndex==-1 || string.IsNullOrEmpty(textResponsable.Text))
                val = false;
            return val;
        }
    }
}