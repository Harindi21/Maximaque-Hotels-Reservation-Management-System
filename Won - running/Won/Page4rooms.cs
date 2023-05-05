using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Won
{
    public partial class Page4rooms : Form
    {
        public Page4rooms()
        {
            InitializeComponent();
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

        private void textBoxRID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "INSERT INTO rooms(RoomID,CustomerId,RoomName,Type,Description,Status,Cost)VALUES('" + this.textBoxRID.Text + "','" + this.textBoxCID.Text + "','" + this.textBoxRNAME.Text + "','" + this.textBoxTy.Text + "','" + this.textBoxDN.Text + "','" + this.textBoxStts.Text + "','" + this.textBoxCt.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "UPDATE rooms SET RoomID = '" + this.textBoxRID.Text + "', CustomerId='" + this.textBoxCID.Text + "', RoomName='" + this.textBoxRNAME.Text + "', Type='" + this.textBoxTy.Text + "', Description='" + this.textBoxDN.Text + "', Status='" + this.textBoxStts.Text + "', Cost='" + this.textBoxCt.Text + "' WHERE RoomID='" + this.textBoxRID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully updated");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "DELETE FROM rooms WHERE RoomID='" + this.textBoxRID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully deleted");
            conn.Close();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "SELECT * FROM rooms";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewRooms.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void Page4rooms_Load(object sender, EventArgs e)
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
    }
}
