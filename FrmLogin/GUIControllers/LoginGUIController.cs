using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
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
            try
            {
                Communication.Instance.Connect();
            }
            catch (SocketException)
            {

                return;
            }

            //Korisnik k = Communication.Instance.Login(frmLogin.txtUsername.Text, frmLogin.txtPassword.Text);
            Korisnik k = Communication.Instance.Login(frmLogin.txtUsername.Text, HashPassword(frmLogin.txtPassword.Text.Trim()));
            if (k != null)
            {
                //MessageBox.Show("Sifra: " + k.Password);
                frmLogin.Hide();
                MainCoordinator.Instance.ShowFrmMain(k);
                frmLogin.Close();
            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka nisu tačni", "GRESKA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach(byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
