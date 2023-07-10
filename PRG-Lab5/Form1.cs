using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(picLuffy.Location.X == 12 | picNaruto.Location.X == 12)
            {
                timerChar1.Enabled = true;
                timerChar2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Restart to Start Again!!!");
            }
          

        }

        private void timerChar2_Tick(object sender, EventArgs e)
        {
            int x = picNaruto.Location.X;
            int y = picNaruto.Location.Y;
            Random random = new Random();
            int speed = random.Next(10, 70);
            x += speed;

            picNaruto.Location = new Point(x, y);

            if (btnRestart.Text == "Restart")
            {
                btnRestart.Text = "Stop";
            }

            if(picNaruto.Location.X > 700)
            {
                timerChar1.Enabled=false;
                timerChar2.Enabled = false;
                MessageBox.Show("Naruto Won!!!");
                btnRestart.Text = "Restart";
            }
        }

        private void timerChar1_Tick(object sender, EventArgs e)
        {
            int x = picLuffy.Location.X;
            int y = picLuffy.Location.Y;
            Random random = new Random();
            int speed = random.Next(10, 70);
            x += speed;
            picLuffy.Location = new Point(x, y);

            if (picLuffy.Location.X > 700)
            {
                timerChar1.Enabled = false;
                timerChar2.Enabled = false;
                MessageBox.Show("Luffy Won!!!");
                btnRestart.Text = "Restart";
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            picLuffy.Location = new Point(12, 219);
            picNaruto.Location = new Point(12, 346);
            timerChar1.Enabled = false;
            timerChar2.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Closing the application!!!");
            this.Close();
        }
    }
}
