using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectAS
{
    public partial class Inventory : Form
    {
        bool flash, skey, brkey;
        bool equipedF, equipedBK, equipedSK;
        
        public Inventory(bool flash, bool skey, bool brkey)
        {
            InitializeComponent();

            this.flash = flash;
            this.skey = skey;
            this.brkey = brkey;
            
         
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDataSet.items' table. You can move, or remove it, as needed.
            //this.itemsTableAdapter.Fill(this.itemsDataSet.items);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\items.mdf;Integrated Security=True;Connect Timeout=30");

            //SqlCommand cmd = new SqlCommand("SELECT * FROM items", con);
            con.Open();
            DataTable dt = new DataTable();
           
            SqlDataAdapter sda = new SqlDataAdapter();
            
            if(flash == true && equipedF == false)
            {
                SqlCommand light = new SqlCommand("SELECT * FROM items WHERE Items = 'FlashLight'", con);
                sda.SelectCommand = light;
                sda.Fill(dt);
                equipedF = true;
            }
            if (brkey == true && equipedBK == false)
            {
                SqlCommand bedroom = new SqlCommand("SELECT * FROM items WHERE Items = 'Bedroom Key'", con);
                sda.SelectCommand = bedroom;
                sda.Fill(dt);
                equipedBK = true;
            }

            if (skey == true && equipedSK == false)
            {
                SqlCommand secret = new SqlCommand("SELECT * FROM items WHERE Items = 'Strange Key'", con);
                sda.SelectCommand = secret;
                sda.Fill(dt);
                equipedSK = true;
            }
            
            dataGridView1.DataSource = dt;
            
            con.Close();





        }
    }
}
