using MySql.Data.MySqlClient;

namespace Won
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
          
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string mysqlCon = "server=127.0.0.1; user=root; database=mnagementsystem; password=";
            //try
            //{
            //    MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            //    string uname = textBox1.Text.ToString();
            //    string password = textBox2.Text.ToString();
            //    if (uname.Length == 0 || password.Length == 0)
            //    {
            //        MessageBox.Show("No empty feilds allowed");
            //    }
            //    else
            //    {

            //        mySqlConnection.Open();


            //        MySqlCommand mySqlCommand = new MySqlCommand("select * from user_profile", mySqlConnection);

            //        MySqlDataReader reader = mySqlCommand.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            if (uname.Equals(reader.GetString("UName")) && password.Equals(reader.GetString("Password")))
            //            {
            //                PreHome p = new PreHome();
            //                this.Hide();
            //                p.Show();

            //            }
            //            else
            //            {
            //                //MessageBox.Show("Invalid login");
            //            }
            //        }
            //        mySqlConnection.Close();
            //    }



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string aun = textBox1.Text;
            string apw = textBox2.Text;
            if (aun == "Admin" && apw == "999")
            {
                HomePage hp = new HomePage();
                this.Hide();
                hp.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials Provided");
            }
        }
    }
}