using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onePlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (onePlayer.Checked == true)
            {
                CrossCB.Visible = true;
            }
            else
            {
                CrossCB.Visible = false;
            }
        }

        private void BeginAgainBtn_Click(object sender, EventArgs e)
        {
            //ask if sure
            //clean the matrix
        }
    }
}
