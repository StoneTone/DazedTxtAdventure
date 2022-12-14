using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectAS
{
    public partial class descriptionForm : Form
    {
        public descriptionForm()
        {
            InitializeComponent();

            welcomeLabel.MaximumSize = new Size(450, 250);
            welcomeLabel.AutoSize = true;
            welcomeLabel.Text = "Welcome to Dazed! A text adventure where you find yourself in a situation" +
                " where things aren't what you're used to.";
        }


        private void menuButton_Click(object sender, EventArgs e)
        {
            //unhiding title screen
            titleForm tF = new titleForm();
            tF.Show();
            
            Close(); //hiding description form
            
        }

        //setting variables and counters for textScroll
        int counter = 0;
        int len = 0;
        string text;
        
       
        private void descriptionForm_Load(object sender, EventArgs e)
        {

            //form loading for text scroll animation
            text = welcomeLabel.Text;
            len = text.Length;

            textScroll.Start(); //start of timer for animation
            nextForm.Hide();
            glLabel.Hide();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            welcomeLabel.Text = text.Substring(0,counter);
            
            ++counter;

            if(counter > len)
            {
                welcomeLabel.Show();
                textScroll.Stop(); //stop of timer
                glLabel.Show();
                nextForm.Show();
            }
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            worldBuild wB = new worldBuild();
            wB.Show();
            Close();
        }

        private void descriptionForm_Click(object sender, EventArgs e)
        {
            try 
            {
                textScroll.Interval -= 10;
            } 
            catch(ArgumentOutOfRangeException)
            {
                textScroll.Interval = 1;
            }
           
        }
    }
}
