namespace CapaDominio
{
    using CapaAccesoDatos; //De dominio se leen los datos accesados.
    public class UsuarioModelo
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        persistencia persistencia = new persistencia();
        
        public bool LoginUser(string user, string password)
        {
            return usuarioDAO.Login(user, password); 
        }

        public void InsertarUsuario(int IDTipoUsuario, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario, string Contraseña)
        {
            int ID = persistencia.SiguienteID("Usuarios", "IDUsuario");
            usuarioDAO.InsertarUsuario(ID, IDTipoUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Contraseña);
        }
        
        public void BorrarUsuario(int IDUsuario)
        {
            usuarioDAO.BorrarUsuario(IDUsuario);
        }

        public void EditarUsuario(int IDUsuario, int IDTipoUsuario, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario, string Contraseña)
        {
            bool Activo = true;
            usuarioDAO.EditarUsuario(IDUsuario, IDTipoUsuario, Nombre, ApellidoPaterno, ApellidoMaterno, Usuario, Contraseña, Activo);
        }

        public bool VerificarUsuario(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Usuario)
        {
            return usuarioDAO.VerificarUsuario(Nombre, ApellidoPaterno, ApellidoMaterno, Usuario);
        }
    }
}
