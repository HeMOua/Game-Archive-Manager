using System.Diagnostics;

namespace GameSave
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
        }

        //static void Main(string[] args)
        //{
        //    Debug.WriteLine(Utils.FolderContainsItems(@"E:\CodeMgr\VisualStudio\GameSave\bin\Debug\net6.0-windows\archive"));
        //}
    }
}