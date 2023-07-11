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
            else if(timerChar1.Enabled == true | timerChar2.Enabled == true)
            {
                MessageBox.Show("Game is currently Running!!!");
            }
            else
            {
                MessageBox.Show("Restart to Start Again!!!");
            }
          

        }

        private void timerChar2_Tick(object sender, EventArgs e)
        {
            //Retrieving the location for character labels
            int narutoXLabel = lblNaruto.Location.X;
            int narutoYLabel = lblNaruto.Location.Y;

            //Retrieving the location for characters
            int picXNaruto = picNaruto.Location.X;
            int picYNaruto = picNaruto.Location.Y;

            //Moving the x coordinate with random value
            Random random = new Random();
            int speed = random.Next(10, 70);
            picXNaruto += speed;
            narutoXLabel += speed;

            picNaruto.Location = new Point(picXNaruto, picYNaruto);
            lblNaruto.Location = new Point(narutoXLabel, narutoYLabel);

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
            //Retrieving the location for character labels
            int luffyXLabel = lblLuffy.Location.X;
            int luffyYLabel = lblLuffy.Location.Y;

            //Retrieving the location for characters
            int picXLuffy = picLuffy.Location.X;
            int picYLuffy = picLuffy.Location.Y;

            //Moving the x coordinate with random value
            Random random = new Random();
            int speed = random.Next(10, 70);
            picXLuffy += speed;
            luffyXLabel += speed;

            picLuffy.Location = new Point(picXLuffy, picYLuffy);
            lblLuffy.Location = new Point(luffyXLabel, luffyYLabel);

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
            lblLuffy.Location = new Point(117, 216);
            lblNaruto.Location = new Point(117, 382);
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
