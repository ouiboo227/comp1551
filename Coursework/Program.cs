using System;
using System.Windows.Forms;

namespace Coursework
{
    static class Program
    {
        [STAThread]
// Main entry point for the Windows Forms application
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }
}