using System;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a User object
            User currentUser = new User();

            // Pass the User object to the LoginPage constructor
            Application.Run(new Welcome(currentUser));
        }
    }
}
