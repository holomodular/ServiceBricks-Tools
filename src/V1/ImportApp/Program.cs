using ImportApp.Forms;

namespace ImportApp
{
    internal static class Program
    {
        public static ApplicationContext AppContext;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Program.AppContext = new ApplicationContext(new frmMain());
            Application.Run(AppContext);
        }

        public static void SetMainForm(Form newForm)
        {
            var oldForm = Program.AppContext.MainForm;
            Program.AppContext.MainForm = newForm;
            oldForm?.Close();
            newForm.Show();
        }
    }
}