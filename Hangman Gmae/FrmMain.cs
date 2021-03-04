using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Gmae
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GameLevel = 0;
            Properties.Settings.Default.Save();
            FrmHangman frm = new FrmHangman();
            frm.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FrmHangman frm = new FrmHangman();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
