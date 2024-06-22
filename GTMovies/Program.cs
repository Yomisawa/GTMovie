using System;
using System.Windows.Forms;
using GTMovies; // Aseg�rate de incluir el namespace adecuado

namespace GTMovies
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            var sqliteHelper = new SQLiteHelper("GTMoviesDatabase.db");


           
            sqliteHelper.InitializeDatabase();

            

            Application.Run(new LoginForm(sqliteHelper));
        }
    }
}
