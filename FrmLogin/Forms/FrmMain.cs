using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.Forms
{
    public partial class FrmMain : Form
    {
        private Uloga uloga;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Uloga uloga)
        {
            this.uloga = uloga;
        }
    }
}
