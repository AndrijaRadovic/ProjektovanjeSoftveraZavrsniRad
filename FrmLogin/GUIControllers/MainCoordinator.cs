using Common.Domain;
using FrmLogin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmLogin.GUIControllers
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainCoordinator();
                }
                return instance;
            }
        }

        public MainCoordinator()
        {
            //instancirati sve GUI kontrolere osim logina
        }

        private FrmMain frmMain;

        internal void ShowFrmMain(Uloga uloga)
        {
            frmMain = new FrmMain(uloga);
            frmMain.AutoSize = true;
            //ShowDefault();
            frmMain.ShowDialog();
        }
    }
}
