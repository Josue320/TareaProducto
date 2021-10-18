using Domain.Entities.Invetory;
using Domain.Enums;
using Infraestructure.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios
{
    public partial class FrmAñadirInventario : Form
    {
        private ModelInven inven = new ModelInven();
        public FrmAñadirInventario()
        {
            InitializeComponent();
        }

        private void cmbNaturaleza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbNaturaleza.SelectedIndex)
            {
                case 0:
                    pnlPrecio.Visible = true;
                    break;
                case 1:
                    pnlPrecio.Visible = false;
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Verificacion();
            Registros R = new Registros()
            {
                Existencia = (int)nudCantidad.Value,
                FechaRegistro = dtpFecha.Value,
                Especie = (EsCuen)cmbNaturaleza.SelectedIndex,
                ValorUnidad = nudPrecio.Value,
                ValorTotal = (int)nudCantidad.Value * nudPrecio.Value
            };
            inven.Create(R);
            this.Close();
        }
        private void Verificacion()
        {
            if(nudCantidad.Value == 0 )
            {
                MessageBox.Show("Debe rellenar todos los campos.",
                               "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
