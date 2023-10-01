namespace OrdenRetiroApp
{
    partial class FrmOrdenRetiro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textResponsable = new TextBox();
            dgvDetalleOrden = new DataGridView();
            ColCodigo = new DataGridViewTextBoxColumn();
            ColMaterial = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColAcciones = new DataGridViewButtonColumn();
            cboMaterial = new ComboBox();
            btnAgregar = new Button();
            btnAceptar = new Button();
            btnCancelar = new Button();
            textFecha = new TextBox();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOrden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 36);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 9;
            label2.Text = "Responsable:";
            // 
            // textResponsable
            // 
            textResponsable.Location = new Point(161, 91);
            textResponsable.Margin = new Padding(3, 4, 3, 4);
            textResponsable.Name = "textResponsable";
            textResponsable.Size = new Size(401, 27);
            textResponsable.TabIndex = 1;
            // 
            // dgvDetalleOrden
            // 
            dgvDetalleOrden.AllowUserToAddRows = false;
            dgvDetalleOrden.AllowUserToDeleteRows = false;
            dgvDetalleOrden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleOrden.Columns.AddRange(new DataGridViewColumn[] { ColCodigo, ColMaterial, ColStock, ColCantidad, ColAcciones });
            dgvDetalleOrden.Location = new Point(49, 235);
            dgvDetalleOrden.Margin = new Padding(3, 4, 3, 4);
            dgvDetalleOrden.Name = "dgvDetalleOrden";
            dgvDetalleOrden.ReadOnly = true;
            dgvDetalleOrden.RowHeadersWidth = 51;
            dgvDetalleOrden.RowTemplate.Height = 25;
            dgvDetalleOrden.Size = new Size(566, 200);
            dgvDetalleOrden.TabIndex = 5;
            dgvDetalleOrden.CellContentClick += dgvDetalleOrden_CellContentClick;
            // 
            // ColCodigo
            // 
            ColCodigo.HeaderText = "CODIGO";
            ColCodigo.MinimumWidth = 6;
            ColCodigo.Name = "ColCodigo";
            ColCodigo.ReadOnly = true;
            ColCodigo.Visible = false;
            ColCodigo.Width = 125;
            // 
            // ColMaterial
            // 
            ColMaterial.HeaderText = "MATERIAL";
            ColMaterial.MinimumWidth = 6;
            ColMaterial.Name = "ColMaterial";
            ColMaterial.ReadOnly = true;
            ColMaterial.Width = 150;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "STOCK";
            ColStock.MinimumWidth = 6;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            ColStock.Width = 125;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "CANTIDAD";
            ColCantidad.MinimumWidth = 6;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            ColCantidad.Width = 125;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "ACCIONES";
            ColAcciones.MinimumWidth = 6;
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            ColAcciones.Width = 125;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(49, 167);
            cboMaterial.Margin = new Padding(3, 4, 3, 4);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(250, 28);
            cboMaterial.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(502, 164);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(235, 553);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 553);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // textFecha
            // 
            textFecha.Enabled = false;
            textFecha.Location = new Point(161, 33);
            textFecha.Margin = new Padding(3, 4, 3, 4);
            textFecha.Name = "textFecha";
            textFecha.Size = new Size(108, 27);
            textFecha.TabIndex = 0;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(336, 167);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(137, 27);
            nudCantidad.TabIndex = 10;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FrmOrdenRetiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 585);
            Controls.Add(nudCantidad);
            Controls.Add(textFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(cboMaterial);
            Controls.Add(dgvDetalleOrden);
            Controls.Add(textResponsable);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(719, 632);
            MinimumSize = new Size(719, 632);
            Name = "FrmOrdenRetiro";
            Text = "Registrar Orden Retiro";
            Load += FrmOrdenRetiro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDetalleOrden).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textResponsable;
        private DataGridView dgvDetalleOrden;
        private ComboBox cboMaterial;
        private Button btnAgregar;
        private Button btnAceptar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ColCodigo;
        private DataGridViewTextBoxColumn ColMaterial;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewButtonColumn ColAcciones;
        private TextBox textFecha;
        private NumericUpDown nudCantidad;
    }
}