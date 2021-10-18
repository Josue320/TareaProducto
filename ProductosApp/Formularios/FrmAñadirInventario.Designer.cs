
namespace ProductosApp.Formularios
{
    partial class FrmAñadirInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbNaturaleza = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantida = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnlPrecio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlPrecio.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNaturaleza
            // 
            this.cmbNaturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturaleza.FormattingEnabled = true;
            this.cmbNaturaleza.Items.AddRange(new object[] {
            "Entrada",
            "Salida"});
            this.cmbNaturaleza.Location = new System.Drawing.Point(72, 13);
            this.cmbNaturaleza.Name = "cmbNaturaleza";
            this.cmbNaturaleza.Size = new System.Drawing.Size(121, 21);
            this.cmbNaturaleza.TabIndex = 0;
            this.cmbNaturaleza.SelectedIndexChanged += new System.EventHandler(this.cmbNaturaleza_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 2);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCantida
            // 
            this.lblCantida.AutoSize = true;
            this.lblCantida.Location = new System.Drawing.Point(6, 68);
            this.lblCantida.Name = "lblCantida";
            this.lblCantida.Size = new System.Drawing.Size(49, 13);
            this.lblCantida.TabIndex = 4;
            this.lblCantida.Text = "Cantidad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(72, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(72, 66);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 6;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(72, 0);
            this.nudPrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 7;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.pnlPrecio);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(this.cmbNaturaleza);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.lblCantida);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 248);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(118, 154);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(9, 154);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlPrecio
            // 
            this.pnlPrecio.Controls.Add(this.lblPrecio);
            this.pnlPrecio.Controls.Add(this.nudPrecio);
            this.pnlPrecio.Location = new System.Drawing.Point(0, 92);
            this.pnlPrecio.Name = "pnlPrecio";
            this.pnlPrecio.Size = new System.Drawing.Size(200, 36);
            this.pnlPrecio.TabIndex = 9;
            this.pnlPrecio.Visible = false;
            // 
            // FrmAñadirInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAñadirInventario";
            this.Text = "FrmAñadirInventario";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPrecio.ResumeLayout(false);
            this.pnlPrecio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaturaleza;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPrecio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}