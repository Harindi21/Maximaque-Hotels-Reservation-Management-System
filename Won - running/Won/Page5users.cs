using MySql.Data.MySqlClient;
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
    public partial class Page5users : Form
    {
        public Page5users()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
        try{
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "INSERT INTO user_profile(AssignedRole,Name,UserID,UName,Password,Phone)VALUES('" + this.textBoxRl.Text + "','" + this.textBoxNM.Text + "','" + this.textBoxUID.Text + "','" + this.textBoxUNAME.Text + "','" + this.textBoxPs.Text + "','" + this.textBox4n.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation error code
                {
                    MessageBox.Show("A record with the same unique value already exists.");
                }
                else if (ex.Number == 547) // Foreign key constraint violation error code
                {
                    MessageBox.Show("The referenced record in the parent table does not exist.");
                }
                else if (ex.Number == 515) // Null value constraint violation error code
                {
                    MessageBox.Show("A required field is null.");
                }
                else
                {
                    // Handle other generic SQL exceptions
                    MessageBox.Show("An error occurred while executing the SQL operation.");
                }
            }
            catch (Exception ex)
            {
                // Handle other generic exceptions
                MessageBox.Show("An unexpected error occurred.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        try{
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "UPDATE user_profile SET AssignedRole = '" + this.textBoxRl.Text + "', Name='" + this.textBoxNM.Text + "', UserID='" + this.textBoxUID.Text + "', UName='" + this.textBoxUNAME.Text + "', Password='" + this.textBoxPs.Text + "', Phone='" + this.textBox4n + "' WHERE UserID='" + this.textBoxUID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully updated");
            conn.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation error code
                {
                    MessageBox.Show("A record with the same unique value already exists.");
                }
                else if (ex.Number == 547) // Foreign key constraint violation error code
                {
                    MessageBox.Show("The referenced record in the parent table does not exist.");
                }
                else if (ex.Number == 515) // Null value constraint violation error code
                {
                    MessageBox.Show("A required field is null.");
                }
                else
                {
                    // Handle other generic SQL exceptions
                    MessageBox.Show("An error occurred while executing the SQL operation.");
                }
            }
            catch (Exception ex)
            {
                // Handle other generic exceptions
                MessageBox.Show("An unexpected error occurred.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        try{
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "DELETE FROM user_profile WHERE UserID='" + this.textBoxUID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully deleted");
            conn.Close();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation error code
                {
                    MessageBox.Show("A record with the same unique value already exists.");
                }
                else if (ex.Number == 547) // Foreign key constraint violation error code
                {
                    MessageBox.Show("The referenced record in the parent table does not exist.");
                }
                else if (ex.Number == 515) // Null value constraint violation error code
                {
                    MessageBox.Show("A required field is null.");
                }
                else
                {
                    // Handle other generic SQL exceptions
                    MessageBox.Show("An error occurred while executing the SQL operation.");
                }
            }
            catch (Exception ex)
            {
                // Handle other generic exceptions
                MessageBox.Show("An unexpected error occurred.");
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "SELECT * FROM user_profile";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBoxDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Page5users_Load(object sender, EventArgs e)
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
