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
    public interface start
    {
        String loadBullet();
        void fire();

    }
    //c# doesn't support the feature of multiple inheritance so we use the concept of interfaces that is used as a inheritance 
    public partial class Spot : Form ,start
    {
        int countFire = 0,y=0;
        Play obj = new Play();
        int firecont = 0, firegenerate = 0;
        public Spot()
        {
            InitializeComponent();
            images.ImageLocation = "";
   
        }
        //this method is used to fill the bullet in the pistol to fire 
        public String loadBullet() {
            return "images/two.jpg";     
        }
        /*this is the fire method that is used to generate the fire sound with the help of for loop
            and random no  random is used to provide a random click
        */
        public void fire() {
            Random Object = new Random();
            //generate the random
            int number = Object.Next(1,5);
            for (int i=1;i<=5;i++) {
                //compare the loop with the random no if both are equal then the sound willbe gernerated
                if (i == number) {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("images/triger.wav");
                    player.Play();
                    //after generatimg the sound the loop will be break;
                    break; 
                }
            }
        }
       

        private void btnStart_Click(object sender, EventArgs e)
        {
            //calling the method of the interface to load the 2nd one image by using the method of interface that is initlized in the bloack of main class
            images.ImageLocation = loadBullet();
        }

        public void ButtonFire_Click(object sender, EventArgs e)
        {   
            //this code show the 3rd once image
            images.ImageLocation = "images/triger.jpg";
            //this varaible is used to count the trigger and cal the fire method to generate the fire
            countFire++;
            if (countFire%2==0 && y<2) {
                fire();
                y++;
                if (y==1) {
                    MessageBox.Show("This is your last chance to play");
                }
            }
            //this condition will be true when 2 trigger will be generted
            if (y==2) {
                if (y == obj.genNo())
                {
                    blood.Visible = true;
                    MessageBox.Show("Hurry you are the Winner");
                }
                else {
                    MessageBox.Show("Your Game is Over ");
                }
                ButtonFire.Enabled = false;   
            }
        }
        //this method is usd to reload the game after completing the game 
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonFire.Enabled = true;
            y = 0;
            countFire= -1;
            images.ImageLocation = "images/empty.jpg";
            blood.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            images.ImageLocation = "images/empty.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this code show the 3rd once image
            images.ImageLocation = "images/triger.jpg";
            //this varaible is used to count the trigger and cal the fire method to generate the fire
            firecont++;
            if (firecont == obj.genNo())
            {
                fire();
                firegenerate++;

                if (firecont == obj.genNo())
                {
                    blood.Visible = true;
                    MessageBox.Show("Hurry you are the Winner");

                }

            }

            if (firecont == 6)
            {
                MessageBox.Show("Your first chance is over");
                firecont = 0;
            }

            if (firegenerate == 2)
            {
                MessageBox.Show("Your game is over please play again ");
            }

        }

        private void Spot_Load(object sender, EventArgs e)
        {

        }
    }
}
