using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipperFireGame
{
    public partial class Form1 : Form
    {
        //global variable for loading the progress bar for loading the task of another frame
        int progress = 0;
        public Form1()
        {
            InitializeComponent();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (progress < 100)
            {
                progress = progress + 10;
                Loading.Value = progress;
            }
            else {
                Spot instance = new Spot();
                instance.Show();
                this.Hide();
                timer1.Stop();
                MessageBox.Show("Welcome to Fire Game You wil be given two Chances to play the Game   In First Round you Click Six Time on " + "\n" +
               "Shoot away Button then you again have one chance to play");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
