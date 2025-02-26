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

namespace ControlEscolar.View
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes(Form parent)
        {
            InitializeComponent();
            //Inicializaforma(parent);

            #region Codigo Mejorado
            Formas.InicializaForma(this, parent);
            #endregion
        }

        private void Inicializaforma(Form parent)
        {
            //Inicializamos la forma

            //Propiedades basicas. 
            this.MdiParent = parent;  // Asignar el padre MDI
            this.FormBorderStyle = FormBorderStyle.Sizable;  // Permitir redimensionar
            this.MaximizeBox = true;  // Permitir maximizar
            this.MinimizeBox = true;  // Permitir minimizar
            this.WindowState = FormWindowState.Normal;  // Estado inicial de la ventana

            //Priopiedades de control 
            this.ControlBox = true;  // Mostrar botones de control (minimizar, maximizar, cerrar)
            this.ShowIcon = true;  // Mostrar icono en la barra de título
            this.ShowInTaskbar = false;  // No mostrar en la barra de tareas (ya que es una ventana hija)

            //Propiedades de tamaño
            this.AutoScaleMode = AutoScaleMode.Font;  // Modo de escalado
            this.ClientSize = new Size(800, 600);  // Tamaño inicial
            this.MinimumSize = new Size(400, 300);  // Tamaño mínimo permitido
            this.MaximumSize = new Size(3440, 1440);  // Tamaño máximo permitido

            //Propiedades de inicio 
            this.StartPosition = FormStartPosition.CenterScreen;  // Posición inicial

            //Propiedades de comportamuento
            this.AutoScroll = true;  // Permitir scroll si el contenido es mayor que la ventana
            this.KeyPreview = true;  // Permitir que el formulario reciba eventos de teclado
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }
    }
}
