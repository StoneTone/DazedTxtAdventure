using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Antonio Santos
namespace FinalProjectAS
{
    
    public partial class titleForm : Form
    {
        public titleForm()
        {
            InitializeComponent();
            
        }

        

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); //to stop all windows that are remaining open
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            descriptionForm wB = new descriptionForm();
            wB.Show();
            Hide();
        }
    }
}
