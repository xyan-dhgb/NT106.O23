namespace Lab_3___Bài_6
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
            Application.Run(new Form1());
            var Sign_up = new Sign_up();
            var Client = new Client("default_username");
            var Server = new Server();
        }
    }
}