//Mudrak Patel; 300878960; Lab03

using System;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
