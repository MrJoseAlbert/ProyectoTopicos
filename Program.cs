namespace ProyectoU1P2
{
    internal static class Program
    {
        public static frmcvja f1 = null;
        public static frmcvjaCompras f2 = null;
        public static Carrocvja f3 = null;
        public static Acercade f4 = null;
        public static Ticket f5 = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmcvja());
        }
    }
}