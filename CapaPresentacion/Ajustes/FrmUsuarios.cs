namespace CapaPresentacion.Ajustes
{
    using CapaDominio;
    using System;
    using System.Windows.Forms;

    public partial class FrmUsuarios : Form
    {
        string PageAction; //Indica al programa si se agrega un nuevo campo.
        CapaDominio.UsuarioModelo UsuarioModelo = new UsuarioModelo();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsProyecto.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dsProyecto.Usuarios);
            //Para limpiar los campos de busqueda.
            EstadoEditable(false);
        }

        private void EstadoEditable(bool v)
        {
            toolStripAgregar.Enabled = !v;
            toolStripModificar.Enabled = !v;
            toolStripBorrar.Enabled = !v;
            toolStripGuardar.Enabled = v;
            toolStripRegresar.Enabled = !v;
            toolStripCancelar.Enabled = v;

            dgUsuarios.Enabled = !v;
            gbBusquedas.Enabled = !v;
            gbDatos.Enabled = v;

        }

        private void txtBNombre_TextChanged(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.FillByNombre(this.dsProyecto.Usuarios, "%" + txtBNombre.Text + "%"); //Para concatenar los datos de busqueda.
        }

        private void txtBPaterno_TextChanged(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.FillByApellidoPaterno(this.dsProyecto.Usuarios, "%" + txtBPaterno.Text + "%");
        }

        private void txtBMaterno_TextChanged(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.FillByApellidoMaterno(this.dsProyecto.Usuarios, "%" + txtBMaterno.Text + "%");
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            PageAction = "ADD";
            LimpiarCampos();
            EstadoEditable(true);
            txtDNombre.Focus();
        }

        private void LimpiarCampos()
        {
            txtDNombre.Text = string.Empty;
            txtDPaterno.Text = string.Empty;
            txtDMaterno.Text = string.Empty;
            txtDUsuario.Text = string.Empty;
            txtDContraseña.Text = string.Empty;
            txtDConfirmarContraseña.Text = string.Empty;
        }

        private void toolStripModificar_Click(object sender, EventArgs e)
        {
            PageAction = "EDIT";
            CargarDatos();
            EstadoEditable(true);
            txtDNombre.Focus();
        }

        private void CargarDatos()
        {
            if(dgUsuarios.CurrentCell == null) //Si no cargo nada
            {
                MessageBox.Show("No hay usuarios en el sistema.");
                EstadoEditable(false);

                return; 
            }
            txtDNombre.Text = dgUsuarios[2, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtDPaterno.Text = dgUsuarios[3, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtDMaterno.Text = dgUsuarios[4, dgUsuarios.CurrentRow.Index].Value.ToString();
            txtDUsuario.Text = dgUsuarios[5, dgUsuarios.CurrentRow.Index].Value.ToString();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            EstadoEditable(false);
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if(txtDNombre.Text == string.Empty)
            {
                MessageBox.Show("No has escrito el nombre.");
                txtDNombre.Focus();
                return;
            }

            if(txtDPaterno.Text == string.Empty)
            {
                MessageBox.Show("No has escrito el apellido paterno.");
                txtDPaterno.Focus();
                return;
            }

            if (txtDMaterno.Text == string.Empty)
            {
                MessageBox.Show("No has escrito el apellido materno.");
                txtDMaterno.Focus();
                return;
            }

            if (txtDUsuario.Text == string.Empty)
            {
                MessageBox.Show("No has escrito el usuario.");
                txtDUsuario.Focus();
                return;
            }

            if (txtDContraseña.Text == string.Empty)
            {
                MessageBox.Show("No has escrito la contraseña.");
                txtDContraseña.Focus();
                return;
            }

            if (txtDContraseña.Text != txtDConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtDContraseña.Text = string.Empty;
                txtDConfirmarContraseña.Text = string.Empty;
                txtDContraseña.Focus();
                return;
            }

            //Verificar si el usario no existe no existe en la base de datos.
            bool alta = UsuarioModelo.VerificarUsuario(txtDNombre.Text, txtDPaterno.Text, txtDMaterno.Text, txtDUsuario.Text);
            if(alta == true)
            {
                MessageBox.Show("El usuario ya esta registrado.");
                LimpiarCampos();
                EstadoEditable(false);
                return;
            }

            if(PageAction == "ADD")
            {
                UsuarioModelo.InsertarUsuario(2, txtDNombre.Text.ToUpper(), txtDPaterno.Text.ToUpper(), txtDMaterno.Text.ToUpper(), txtDUsuario.Text, txtDConfirmarContraseña.Text);
                this.usuariosTableAdapter.Fill(this.dsProyecto.Usuarios);
                EstadoEditable(false); //Ya se agrego informacion.
                return;
            }

            if(PageAction == "EDIT")
            {
                int ID;
                ID = Convert.ToInt32(dgUsuarios[0, dgUsuarios.CurrentRow.Index].Value.ToString());
                UsuarioModelo.EditarUsuario(ID, 2, txtDNombre.Text.ToUpper(), txtDPaterno.Text.ToUpper(), txtDMaterno.Text.ToUpper(), txtDUsuario.Text, txtDConfirmarContraseña.Text);
                this.usuariosTableAdapter.Fill(this.dsProyecto.Usuarios);
                EstadoEditable(false); //Ya se agrego informacion.
                return;
            }
        }

        private void toolStripBorrar_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(dgUsuarios[0, dgUsuarios.CurrentRow.Index].Value.ToString());
            UsuarioModelo.BorrarUsuario(ID);
            this.usuariosTableAdapter.Fill(this.dsProyecto.Usuarios);
            EstadoEditable(false); //Ya se agrego informacion.
            return;
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
