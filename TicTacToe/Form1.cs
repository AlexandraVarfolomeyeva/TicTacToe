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

        private void DrawField()
        {
            Graphics g = GameField.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Point p1 = new Point(0, GameField.Size.Height/3);
            Point p2 = new Point(GameField.Size.Width, GameField.Size.Height / 3);
            g.DrawLine(p, p1, p2);
            p1 = new Point(0, GameField.Size.Height / 3 * 2);
            p2 = new Point(GameField.Size.Width, GameField.Size.Height / 3 * 2);
            g.DrawLine(p, p1, p2);

            p1 = new Point(GameField.Size.Width / 3, 0);
            p2 = new Point(GameField.Size.Width / 3, GameField.Size.Height);
            g.DrawLine(p, p1, p2);
            p1 = new Point(GameField.Size.Width / 3 * 2, 0);
            p2 = new Point(GameField.Size.Width / 3 * 2, GameField.Size.Height);
            g.DrawLine(p, p1, p2);
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //check fot the coordinates
            OutputText.Text = e.Location.X + ", " + e.Location.Y;
        }

        private void GameField_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
