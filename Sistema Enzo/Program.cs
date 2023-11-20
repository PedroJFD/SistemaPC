using Sistema_Enzo.Telas;

namespace Sistema_Enzo
{
    internal static class Program
    {
        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Computador> totalComputador = new List<Computador>();
        public static string[] componentes = new string[8];
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            usuarios = Usuario.JsonDesserealizarLista("D:\\jsontrabalho\\Usuarios.json");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogar());
        }
    }
}