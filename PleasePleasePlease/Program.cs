using System;
using System.Windows.Forms;
using Mirai_Paradise_Hotel;

namespace Mirai_Paradise_Hotel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage()); // Ensure your main form is correctly specified here
        }
    }
}