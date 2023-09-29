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
            servicio= new ServicioOrden();
            ordenRetiro= new OrdenRetiro();

        }
        private void FrmOrdenRetiro_Load(object sender, EventArgs e)
        {
            textFecha.Text = DateTime.Today.ToShortDateString();


        }
    }
}