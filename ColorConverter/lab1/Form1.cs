using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
           
            colorDialog1.FullOpen = true;    
            colorDialog1.Color = pb1.BackColor;
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void Button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            pb1.BackColor = colorDialog1.Color;
            trbRed.Value = colorDialog1.Color.R;
            trbGreen.Value = colorDialog1.Color.G;
            trbBlue.Value = colorDialog1.Color.B;

            SetRgbToCmyk();
        }

        private void SetRgbToCmyk()
        {
            pb1.BackColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);

            Converter cnv = new Converter();
            CmykColor cm = cnv.rgbToCmyk(trbRed.Value, trbGreen.Value, trbBlue.Value);
            trbCyan.Value = cm.c;
            trbMagenta.Value = cm.m;
            trbYellow.Value = cm.y;
            trbKey.Value = cm.k;
        }
  
        private void Rgb_Scrolling(object sender, EventArgs e)
        {
            SetRgbToCmyk();
        }

        private float CheckRgb(float val)
        {
           
            return val>255?255:val;
        }

        private float CheckCmyk(float val)
        {
            return val > 100 ? 100 : val;
        }
            private void Rgb_Leave(object sender, EventArgs e)
        {
            try
            {

                trbRed.Value = (int)CheckRgb(Int32.Parse(tbRed.Text));
                tbRed.Text = trbRed.Value.ToString();
                trbGreen.Value = (int)CheckRgb(Int32.Parse(tbGreen.Text));
                tbGreen.Text = trbGreen.Value.ToString();
                trbBlue.Value = (int)CheckRgb(Int32.Parse(tbBlue.Text));
                tbBlue.Text = trbBlue.Value.ToString();

                SetRgbToCmyk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty input", "Warning!");
            }
        }

        private void SetCmykToRgb()
        {
            
            Converter cnv = new Converter();
            RgbColor rc = cnv.cmykToRgb(trbCyan.Value, trbMagenta.Value, trbYellow.Value, trbKey.Value);
            pb1.BackColor = Color.FromArgb(rc.r, rc.g, rc.b);
            trbRed.Value = rc.r;
            trbGreen.Value = rc.g;
            trbBlue.Value = rc.b;
        }

        private void Cmyk_Scrolling(object sender, EventArgs e)
        {
            SetCmykToRgb();
        }

        private void Cmyk_Leave(object sender, EventArgs e)
        {

            try
            {
                trbCyan.Value = (int)CheckCmyk(Int32.Parse(tbCyan.Text));
                tbCyan.Text = trbCyan.Value.ToString();
                trbMagenta.Value = (int)CheckCmyk(Int32.Parse(tbMagenta.Text));
                tbMagenta.Text = trbMagenta.Value.ToString();
                trbYellow.Value = (int)CheckCmyk(Int32.Parse(tbYellow.Text));
                tbYellow.Text = trbYellow.Value.ToString();
                trbKey.Value = (int)CheckCmyk(Int32.Parse(tbKey.Text));
                tbKey.Text = trbKey.Value.ToString();

                SetCmykToRgb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty input","Warning!");
            }
        }

        private void TrbCyan_ValueChanged(object sender, EventArgs e)
        {
            tbCyan.Text = trbCyan.Value.ToString();
        }

        private void TrbMagenta_ValueChanged(object sender, EventArgs e)
        {
            tbMagenta.Text = trbMagenta.Value.ToString();
        }

        private void TrbYellow_ValueChanged(object sender, EventArgs e)
        {
            tbYellow.Text = trbYellow.Value.ToString();
        }

        private void TrbKey_ValueChanged(object sender, EventArgs e)
        {
            tbKey.Text = trbKey.Value.ToString();
        }

        private void TrbRed_ValueChanged(object sender, EventArgs e)
        {
            tbRed.Text = trbRed.Value.ToString();
        }

        private void TrbGreen_ValueChanged(object sender, EventArgs e)
        {
            tbGreen.Text = trbGreen.Value.ToString();
        }

        private void TrbBlue_ValueChanged(object sender, EventArgs e)
        {
            tbBlue.Text = trbBlue.Value.ToString();
        }


        private void pb1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void tbCyan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location
            };

            newForm.Show();
            Hide();
        }
    }
}
