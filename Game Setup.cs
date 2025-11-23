using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scizzors
{
    public partial class frmGameSetup : Form
    {
        public frmGameSetup()
        {
            InitializeComponent();
        }

      public enum enGameMode { BestOf3 =3,BestOf5 =5, Unlimited = 0 };

        private void frmGameSetup_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            enGameMode selectedMode = enGameMode.Unlimited;
            
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                string PlayerName = txtName.Text;
                if (rdBestOf3.Checked)
                {
                    selectedMode = enGameMode.BestOf3;
                }
                else if (rdBestOf5.Checked)
                {
                    selectedMode = enGameMode.BestOf5;
                }
                this.Hide();
                frmGameArena frm3 = new frmGameArena(PlayerName,selectedMode);
                frm3.ShowDialog();
                this.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
