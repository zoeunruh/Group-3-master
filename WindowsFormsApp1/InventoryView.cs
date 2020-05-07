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
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class InventoryView : Form
    {
       
        public InventoryView()
        {
            InitializeComponent();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string useItem = itemsGridView.CurrentCell.Value.ToString();
            //string useItem = itemsGridView.CurrentRow.Cells[0].ToString();
            textBox3.Text = useItem;
            decimal itemQuantD =   numericUpDown1.Value;
            int itemQuant = Decimal.ToInt32(itemQuantD);
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP3DataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.gROUP3DataSet1.Orders);
            // TODO: This line of code loads data into the 'gROUP3DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.gROUP3DataSet.Items);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP3DataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.gROUP3DataSet1.Orders);
            // TODO: This line of code loads data into the 'gROUP3DataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.gROUP3DataSet.Items);
        }

        private int _ticks;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            progressBar1.Maximum = 10;
            progressBar1.Step = 1;
            label2.BringToFront();
            int CD = 10 - _ticks;
            label2.Text = CD.ToString();
            progressBar1.PerformStep();
            if (_ticks >= 10)
            {
                _ticks = 0;
                progressBar1.Value = 0;
                // TODO: This line of code loads data into the 'gROUP3DataSet1.Orders' table. You can move, or remove it, as needed.
                this.ordersTableAdapter.Fill(this.gROUP3DataSet1.Orders);
                // TODO: This line of code loads data into the 'gROUP3DataSet.Items' table. You can move, or remove it, as needed.
                this.itemsTableAdapter.Fill(this.gROUP3DataSet.Items);
            }
            
          
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
           
        }

        private void createOrderBttn_Click(object sender, EventArgs e)
        {
            decimal orderItemQuantD = numericUpDown1.Value;
            int orderItemQuant = Decimal.ToInt32(orderItemQuantD);

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            (itemsGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", textBox3.Text);
        

        }
    }
}
