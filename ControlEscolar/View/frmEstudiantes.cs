using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlEscolar.Utilities;
using ControlEscolar.Bussines;

namespace ControlEscolar.View
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes(Form parent)
        {
            InitializeComponent();
            Formas.InicializaForma(this, parent);
        }
        private void Estudiantes_Load(object sender, EventArgs e)
        {
            InicializaVentanaEstudiantes();
        }

        private void InicializaVentanaEstudiantes()
        {
            scEstudiantes.Panel1Collapsed = true;
            lblFechaBaja.Visible = false;
            dtpFechaBaja.Visible = false;
            PoblaComboEstatus();
            PoblaComboTipoFecha();
        }
        private void gbxHerramientas_Enter(object sender, EventArgs e)
        {

        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (scEstudiantes.Panel1Collapsed)
            {
                scEstudiantes.Panel1Collapsed = false;
                btnSplit.Text = "Ocultar captura rápida";
            }
            else
            {
                scEstudiantes.Panel1Collapsed = true;
                btnSplit.Text = "Mostrar captura rápida";
            }
        }

        private void btnCargamasiva_Click(object sender, EventArgs e)
        {
            ofdArchivo.Title = "Seleccionar archivo de Excel";
            ofdArchivo.Filter = "Archivos de Excel (*.xlsx;*.xls)|*.xlsx;*.xls";
            ofdArchivo.InitialDirectory = "C:\\"; // Carpeta inicial
            ofdArchivo.FilterIndex = 1; // Selecciona el primer filtro por defecto
            ofdArchivo.RestoreDirectory = true; // Mantiene la última ruta utilizada

            if (ofdArchivo.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofdArchivo.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".xlsx" || extension == ".xls")
                {
                    MessageBox.Show("Archivo válido: " + filePath, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo de Excel válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void lbArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (GuardarEstuiante())
            {
                MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool GuardarEstuiante()
        {
            if (DatosVacios())
            {
                MessageBox.Show("Por favor, llene todos los campos.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!DatosValidos())
            {
                return false;
            }
            return true;
        }

        private bool DatosVacios()
        {
            if (txtNombre.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == ""
                || txtCurp.Text == "" || upSemestre.Text == "" || txtNoControl.Text == ""
                || upSemestre.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool DatosValidos()
        {
            if (!EstudiantesNegocio.EsCorreoValido(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("Correo inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!EstudiantesNegocio.EsCURPValido(txtCurp.Text.Trim()))
            {
                MessageBox.Show("CURP inválida.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!EstudiantesNegocio.EsNoControlValido(txtNoControl.Text.Trim()))
            {
                MessageBox.Show("Número de control inválido.", "Información del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void PoblaComboEstatus()
        {
            // Crear un diccionario con los valores
            Dictionary<int, string> list_estatus = new Dictionary<int, string>
{
    { 1, "Activo" },
    { 0, "Baja" },
    { 2, "Baja Temporal" }
};

            // Asignar el diccionario al ComboBox
            cbxEstatus.DataSource = new BindingSource(list_estatus, null);
            cbxEstatus.DisplayMember = "Value";  // Lo que se muestra
            cbxEstatus.ValueMember = "Key";      // Lo que se guarda como SelectedValue

            cbxEstatus.SelectedValue = 1;

        }
        private void PoblaComboTipoFecha()
        {
            // Crear un diccionario con los valores
            Dictionary<int, string> list_tipofechas = new Dictionary<int, string>
{
    { 1, "Nacimiento" },
    { 2, "Alta" },
    { 3, "Baja" }
};

            // Asignar el diccionario al ComboBox
            cbxTipoFecha.DataSource = new BindingSource(list_tipofechas, null);
            cbxTipoFecha.DisplayMember = "Value";  // Lo que se muestra
            cbxTipoFecha.ValueMember = "Key";      // Lo que se guarda como SelectedValue

            cbxTipoFecha.SelectedValue = 1;

        }

        private void upSemestre_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstatus.SelectedValue != null && int.TryParse(cbxEstatus.SelectedValue.ToString(), out int selectedValue))
            {
                if (selectedValue == 2 || selectedValue == 0)
                {
                    dtpFechaBaja.Visible = true;
                    lblFechaBaja.Visible = true;
                }
                else
                {
                    dtpFechaBaja.Visible = false;
                    lblFechaBaja.Visible = false;
                }    
            }
        }
    }
}
