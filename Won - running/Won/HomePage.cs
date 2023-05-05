using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Won
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {

            Page2bookings p1 = new Page2bookings();
            this.Hide();
            p1.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Page3customers p3 = new Page3customers();
            this.Hide();
            p3.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Page4rooms p4 = new Page4rooms();
            this.Hide();
            p4.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Page5users p5 = new Page5users();
            this.Hide();
            p5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page6Hotel p5 = new Page6Hotel();
            this.Hide();
            p5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Page1 pg = new Page1();  
           this.Hide();
           pg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HomePage pg = new HomePage();
            this.Hide();
            pg.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
