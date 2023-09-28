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
            dataGridView1 = new DataGridView();
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
            textCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 71);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 9;
            label2.Text = "Responsable:";
            // 
            // textResponsable
            // 
            textResponsable.Location = new Point(141, 68);
            textResponsable.Name = "textResponsable";
            textResponsable.Size = new Size(351, 23);
            textResponsable.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColCodigo, ColMaterial, ColStock, ColCantidad, ColAcciones });
            dataGridView1.Location = new Point(43, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(495, 150);
            dataGridView1.TabIndex = 5;
            // 
            // ColCodigo
            // 
            ColCodigo.HeaderText = "CODIGO";
            ColCodigo.Name = "ColCodigo";
            ColCodigo.ReadOnly = true;
            ColCodigo.Visible = false;
            // 
            // ColMaterial
            // 
            ColMaterial.HeaderText = "MATERIAL";
            ColMaterial.Name = "ColMaterial";
            ColMaterial.ReadOnly = true;
            ColMaterial.Width = 150;
            // 
            // ColStock
            // 
            ColStock.HeaderText = "STOCK";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "CANTIDAD";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColAcciones
            // 
            ColAcciones.HeaderText = "ACCIONES";
            ColAcciones.Name = "ColAcciones";
            ColAcciones.ReadOnly = true;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(43, 125);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(219, 23);
            cboMaterial.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(439, 123);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(206, 415);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(325, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textFecha
            // 
            textFecha.Enabled = false;
            textFecha.Location = new Point(141, 25);
            textFecha.Name = "textFecha";
            textFecha.Size = new Size(95, 23);
            textFecha.TabIndex = 0;
            // 
            // textCantidad
            // 
            textCantidad.Location = new Point(310, 123);
            textCantidad.Name = "textCantidad";
            textCantidad.Size = new Size(100, 23);
            textCantidad.TabIndex = 3;
            // 
            // FrmOrdenRetiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 447);
            Controls.Add(textCantidad);
            Controls.Add(textFecha);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregar);
            Controls.Add(cboMaterial);
            Controls.Add(dataGridView1);
            Controls.Add(textResponsable);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(631, 486);
            MinimumSize = new Size(631, 486);
            Name = "FrmOrdenRetiro";
            Text = "Registrar Orden Retiro";
            Load += FrmOrdenRetiro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textResponsable;
        private DataGridView dataGridView1;
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
        private TextBox textCantidad;
    }
}