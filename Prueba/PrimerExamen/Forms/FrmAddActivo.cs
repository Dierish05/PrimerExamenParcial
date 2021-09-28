using Domain.Enum;
using Domain.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerExamen.Forms
{
    public partial class FrmAddActivo : Form
    {
        public FrmAddActivo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int count = 0;
            count++;

            ActivoFijo act = new ActivoFijo
            {
                Id = count,
                CodigoActivo = txtCodigo.Text,
                NombreActivo = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                ValorActivo = nudValor.Value,
                FechaAdquisicion = dtpAdquisicion.Value,
                tipoActivoFijo = (TipoActivoFijo)cmbTipoActivo.SelectedIndex,
                metodoDepreciacion = (MetodoDepreciacion)cmbTipoActivo.SelectedIndex
            };

            
        }
    }
}
