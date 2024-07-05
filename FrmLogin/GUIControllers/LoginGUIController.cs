using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.GUIControllers
{
    internal class LoginGUIController
    {
        private static LoginGUIController instance;
        public static LoginGUIController Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginGUIController();

                return instance;
            }
        }

        public LoginGUIController()
        {

        }

        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FrmLogin();
            frmLogin.btnLogin.Click += (s, e) => Login();
            frmLogin.AutoSize = true;
            Application.Run(frmLogin);
        }

        private void Login()
        {
            Communication.Instance.Connect();
            Korisnik k = Communication.Instance.Login(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text);
            if(k != null)
            {
                frmLogin.Hide();
                MainCoordinator.Instance.ShowFrmMain(k);
                frmLogin.Close();
            }
            else
            {
                MessageBox.Show("Neuspesna prijava", "GRESKA");
            }
        }
    }
}
