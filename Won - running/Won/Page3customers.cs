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
    public partial class Page3customers : Form
    {
        public Page3customers()
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Page3customers_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        try{
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "INSERT INTO customers(CustomerID,CustomerName,Category,Gender,Phone,Mail,NIC)VALUES('" + this.textBoxCID.Text + "','" + this.textBoxCNM.Text + "','" + this.textBoxCT.Text + "','" + this.textBoxgend.Text + "','" + this.textBox4n.Text + "','" + this.textBoxEM.Text + "','" + this.textBoxNIC.Text + "')";
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
            string query = "UPDATE customers SET CustomerID = '" + this.textBoxCID.Text + "', CustomerName='" + this.textBoxCNM.Text + "', Category='" + this.textBoxCT.Text + "', Gender='" + this.textBoxgend.Text + "', Phone='" + this.textBox4n.Text + "', Mail='" + this.textBoxEM + "', NIC='" + this.textBoxNIC + "' WHERE CustomerID='" + this.textBoxCID.Text + "'";
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
        try
        {
            string connection = "server=localhost;user id=root;password=;database=mnagementsystem";
            string query = "DELETE FROM customers WHERE CustomerID='" + this.textBoxCID.Text + "'";
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
            string query = "SELECT * FROM customers";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page6Hotel p5 = new Page6Hotel();
            this.Hide();
            p5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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
