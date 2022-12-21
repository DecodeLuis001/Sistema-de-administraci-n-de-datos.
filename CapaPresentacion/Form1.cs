namespace CapaPresentacion
{
    using System;
    using System.Windows.Forms;
    using CapaDominio;
    using System.Data.SqlClient;

    public partial class FRMLogin : Form
    {
        public FRMLogin()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text!=string.Empty && txtPassword.Text!=string.Empty)
            {
                if(txtUsuario.Text == string.Empty)
                {
                    MessageBox.Show("El campo de usuario esta vacio.", "Proyecto Arquitectura de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }
                if(txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("El campo de contraseña esta vacio.", "Proyecto Arquitectura de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                    return;
                }

                UsuarioModelo usuarioModelo = new UsuarioModelo();
                var LoginValido = usuarioModelo.LoginUser(txtUsuario.Text, txtPassword.Text);
                if(LoginValido == true)
                {
                    FRMPrincipal form = new FRMPrincipal();
                    form.ShowDialog();
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos.", "Proyecto Arquitectura de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    return;
                }
            }
            else
            {
                MessageBox.Show("No se han introducido los datos, verifique usario y contraseña", "Proyecto Arquitectura de Software", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }
        }
    }
}
