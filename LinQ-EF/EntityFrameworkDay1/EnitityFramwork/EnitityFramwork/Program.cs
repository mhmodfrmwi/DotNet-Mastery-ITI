namespace EnitityFramwork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CoursesForm());
            //Scaffold-DbContext "Server=LAPTOP-N5TCAKUS\SQLEXPRESS;Database=ITI;Trusted_Connection=True;Trust Server Certificate=True;"Microsoft.EntityFrameworkCore.SqlServer-OutputDir Models
        }
    }
}