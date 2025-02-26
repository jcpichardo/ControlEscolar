using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolar.View
{
    public partial class MDI_Control_escolar : Form
    {
        public MDI_Control_escolar()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiantes forma_estudiantes = new frmEstudiantes(this);
            forma_estudiantes.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles forma_roles = new frmRoles(this);
            forma_roles.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios forma_usuarios = new frmUsuarios(this);
            forma_usuarios.Show();
        }


        private void reporte111ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte111 forma_reporte111 = new frmReporte111(this);
            forma_reporte111.Show();
        }

        private void reporte12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte12 forma_reporte12 = new frmReporte12(this);
            forma_reporte12.Show();
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mosaicoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
