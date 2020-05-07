using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

       
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source = 10.135.85.184; User ID = group3; Password = Grp3s2117");
            conn.Open();
            string userID = userTextBox.Text;
            string password = passTextBox.Text;

            SqlCommand check = new SqlCommand("SELECT * FROM Users WHERE UserID = '" + userID + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(check);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Invalid login credentials. Please check your login information to see if it is correct.");
            }
            else
            {
                int fails = Int32.Parse(dt.Rows[0][3].ToString());

                if (dt.Rows[0][2].ToString() != password)
                {
                    MessageBox.Show("Invalid login credentials. Please check your login information to see if it is correct.");

                    fails++;
                    SqlCommand updateFails = new SqlCommand(" UPDATE Users SET Fails = '" + fails + "' WHERE UserID = '" + userID + "'", conn);
                    updateFails.ExecuteNonQuery();
                }
                else if (Int32.Parse(dt.Rows[0][3].ToString()) >= 3)
                {
                    MessageBox.Show("Your account is currently locked. Please contact an administrator to reset it.");
                }
                else
                {
                    InventoryView inventory = new InventoryView();
                    inventory.Show();
                    this.Close();
                }
            }
           
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            userTextBox.Text = "";
            passTextBox.Text = "";
            

         
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            conn = new SqlConnection(@"Data Source = 10.135.85.184; User ID = group3; Password = Grp3s2117");
            conn.Open();
            string userID = userTextBox.Text;

            SqlCommand makeItSpicy = new SqlCommand("UPDATE Users SET Fails = 0 WHERE UserID = '" + userID + "'", conn);
            makeItSpicy.ExecuteNonQuery();



        }
    }
}
