using FrmLogin.GUIControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.SetCompatibleTextRenderingDefault(false);
            LoginGUIController.Instance.ShowFrmLogin();            
        }
    }
}
