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

namespace Guide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initShoeTable();
        }
        private void initShoeTable()
        {
           
            MySqlConnection conn = Connector.GetDBConnection();
            string query = " SELECT shoe.name, type.name, price, amount FROM shoe INNER JOIN type ON shoe.type_id=type.id;";


            conn.Open();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var bindingSource = new BindingSource();
                bindingSource.DataSource = ds.Tables[0];
                dgvTable.DataSource = bindingSource;
                dgvTable.Columns[0].HeaderText = "Название";
                dgvTable.Columns[1].HeaderText = "Тип";
                dgvTable.Columns[2].HeaderText = "Стоимость";
                dgvTable.Columns[3].HeaderText = "Количество";

            }
            // }
            conn.Close();
        }
        private void initTypeTable()
        {

            MySqlConnection conn = Connector.GetDBConnection();
            string query = " SELECT id, name FROM type";


            conn.Open();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                var bindingSource = new BindingSource();
                bindingSource.DataSource = ds.Tables[0];
                dgvTable.DataSource = bindingSource;
                dgvTable.Columns[0].HeaderText = "Код";
                dgvTable.Columns[1].HeaderText = "Название";
                

            }
            // }
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            this.Text = "fdvsd";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            initShoeTable();
        }

      
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                initShoeTable();
                btUpdate.Visible = true;
                btAdd.Visible = true;
                btDelete.Visible = true;
                label3.Visible = true;
            }
            else
            {
                initTypeTable();
                btUpdate.Visible = false;
                btAdd.Visible = false;
                btDelete.Visible = false;
                label3.Visible = false;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            QueryStatements qs = new QueryStatements();
            qs.Delete(dgvTable.SelectedRows[0].Index);
            initShoeTable();
        }
    }
}
