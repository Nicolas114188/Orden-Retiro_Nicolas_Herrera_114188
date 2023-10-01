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
                foreach (DataGridViewRow row in dgvDetalleOrden.Rows)
                {
                    if (row.Cells["ColMaterial"].Value.ToString().Equals(cboMaterial.Text))
                    {
                        MessageBox.Show("Este material ya está detallado...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                Material material = (Material)cboMaterial.SelectedItem;
                int cant = int.Parse(nudCantidad.Value.ToString());
                if (material.Stock < cant)
                {
                    MessageBox.Show("No hay en Stock suficiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DetalleOrden detalle = new DetalleOrden(material, cant);
                ordenRetiro.AgregarDetalle(detalle);
                dgvDetalleOrden.Rows.Add(new object[] { material.Codigo, material.Nombre, material.Stock, cant, "Quitar" });
            }
            else
            {
                MessageBox.Show("Se a ingresado incorrecto los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private bool Validar()
        {
            bool val = true;
            if (cboMaterial.SelectedIndex == -1 || string.IsNullOrEmpty(textResponsable.Text))
                val = false;
            return val;
        }

        private void dgvDetalleOrden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleOrden.CurrentCell.ColumnIndex == 4)
            {
                ordenRetiro.QuitarDetalle(dgvDetalleOrden.CurrentRow.Index);
                dgvDetalleOrden.Rows.RemoveAt(dgvDetalleOrden.CurrentRow.Index);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDetalleOrden.Rows.Count != 0)
            {
                ordenRetiro.Fecha = Convert.ToDateTime(textFecha.Text);
                ordenRetiro.Responsable = textResponsable.Text;
                ordenRetiro.NroOrden = servicio.CrearOrdenRetiro(ordenRetiro);
                if (ordenRetiro.NroOrden != 0)
                {
                    MessageBox.Show("Se registró con éxito la Orden de Retiro: "+ordenRetiro.NroOrden.ToString(), "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("ERROR NO se pudo registrar...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Invalido no ingreso correctamente Materiales...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}