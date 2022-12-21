namespace CapaPresentacion
{
    using System;
    using System.Windows.Forms;
    using CapaSoporte.Cache;
    
    public partial class FRMPrincipal : Form
    {
        public FRMPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            CargaDatosUsuario();
        }

        private void CargaDatosUsuario()
        {
            LblNombre.Text = UsuarioCache.Nombre;
            LblApellidoPaterno.Text = UsuarioCache.ApellidoPaterno;
            LblApellidoMaterno.Text = UsuarioCache.ApellidoMaterno;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {//Estando en el menu principal se manda al menu de usuarios
            Ajustes.FrmUsuarios Form = new Ajustes.FrmUsuarios();
            Form.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.FRMVentas Form = new Ventas.FRMVentas();
            Form.ShowDialog();
        }
    }
}
