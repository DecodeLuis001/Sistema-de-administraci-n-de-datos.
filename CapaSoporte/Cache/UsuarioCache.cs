namespace CapaSoporte.Cache
{
    //Se incertan los datos de tu tabla en SQL.
    public static class UsuarioCache
    {
        public static int IDUsuario { get; set; }
        public static int IDTipoUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string ApellidoPaterno { get; set; }
        public static string ApellidoMaterno { get; set; }
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static bool Activo { get; set; }
    }
}
