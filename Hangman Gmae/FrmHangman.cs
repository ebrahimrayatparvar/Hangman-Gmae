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
    public partial class FrmHangman : Form
    {
        public FrmHangman()
        {
            InitializeComponent();
        }
        List<string> _charList = new List<string>
        {
            "canal",
            "August",
            "chose",
            "facing",
            "official",
            "Norway",
            "deeply",
            "grabbed",
            "grandmother",
            "Philadelphia"
        };
        string _charLevel = string.Empty;
        int _picError = 0;
        private void SetLevel()
        {
            lblAnswer.Text = string.Empty;
            _charLevel = _charList[Properties.Settings.Default.GameLevel];
            for (int i = 0; i < _charLevel.Length; i++)
            {
                lblAnswer.Text += "-";
            }
            lblLevel.Text = $"Leve : {Properties.Settings.Default.GameLevel + 1}";
        }
        private void FrmHangman_Load(object sender, EventArgs e)
        {
            SetLevel();
        }

        private void CheckChar()
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("char is null");
                return;
            }

            bool flag = false;
            for (int i = 0; i < _charLevel.Length; i++)
            {
                if(txtInput.Text.ToLower() == _charLevel[i].ToString().ToLower())
                {
                    lblAnswer.Text = lblAnswer.Text.Remove(i, 1);
                    lblAnswer.Text = lblAnswer.Text.Insert(i, _charLevel[i].ToString());
                    flag = true;
                }
            }

            if(lblAnswer.Text.ToLower() == _charLevel.ToLower())
            {
                var frm = new FrmYouWin();
                frm.ShowDialog();
                Properties.Settings.Default.GameLevel++;
                Properties.Settings.Default.Save();
                SetLevel();
                _picError = 0;
                picHangman.Image = Properties.Resources.Hangman_0;
            }

            if (!flag)
            {
                ErrorPictureChange();
            }
            txtInput.Text = string.Empty;
            txtInput.Focus();
        }

        private void ErrorPictureChange()
        {
            _picError++;
            switch (_picError)
            {
                case 1:
                    picHangman.Image = Properties.Resources.Hangman_1;
                    break;
                case 2:
                    picHangman.Image = Properties.Resources.Hangman_2;
                    break;
                case 3:
                    picHangman.Image = Properties.Resources.Hangman_3;
                    break;
                case 4:
                    picHangman.Image = Properties.Resources.Hangman_4;
                    break;
                case 5:
                    picHangman.Image = Properties.Resources.Hangman_5;
                    break;
                case 6:
                    picHangman.Image = Properties.Resources.Hangman_6;
                    break;
            }
            if (_picError == 6)
            {
                var frm = new FrmGameOver();
                frm.ShowDialog();
                Properties.Settings.Default.GameLevel = 0;
                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckChar();
        }
    }
}
