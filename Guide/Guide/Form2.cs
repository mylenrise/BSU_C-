using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guide
{
    public partial class Form2 : Form
    {
        int[] typeVal = { 201, 202, 203, 204, 205, 206 };
  

        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            Shoe shoe = new Shoe(tbName.Text, typeVal[tbType.SelectedIndex], 
                Convert.ToDouble(tbPrice.Text.Replace(',','.')), Convert.ToInt32(tbNum.Text));
            QueryStatements qs = new QueryStatements();
            qs.Insert(shoe);
            this.Close();
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            double num;
            if (!Double.TryParse(tbPrice.Text, out num)| num < 0)
            {
                MessageBox.Show("Некорректная стоимость", "Ошибка");
                btOk.Enabled = false;
            }
            else
                btOk.Enabled = true;
        }

        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }
    }
}
