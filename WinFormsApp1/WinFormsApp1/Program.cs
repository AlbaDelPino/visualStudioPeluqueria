using WindowsFormsApp1;
namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar login como diálogo modal
            using (Login loginForm = new Login())
            {
                loginForm.ShowDialog();
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    // Si el login fue correcto, abrir Principal con el token
                    Application.Run(new Principal(loginForm.UsuarioActual,loginForm.Token));
                }
            }
        }
    }
}