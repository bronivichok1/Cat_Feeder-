using System;
using WindowsFormsApp1.Data;
using static System.Windows.Forms.Application;

namespace WindowsFormsApp1
{
    internal static class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {

            var user = Repository.GetUser("admin","admin");
            
            EnableVisualStyles();
            SetCompatibleTextRenderingDefault(false);
            Run(new Form1());
        }
    }
}