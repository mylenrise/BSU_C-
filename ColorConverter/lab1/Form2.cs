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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Click += Button1_Click;

            colorDialog1.FullOpen = true;
            colorDialog1.Color = pb1.BackColor;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            Converter preCnv = new Converter();
            CmykColor cm = preCnv.rgbToCmyk(colorDialog1.Color.R, colorDialog1.Color.G, colorDialog1.Color.B);
            pb1.BackColor = colorDialog1.Color;
            trbCyan.Value = cm.c;
            trbMagenta.Value = cm.m;
            trbYellow.Value = cm.y;
            trbKey.Value = cm.k;

            SetCmykToHls();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void SetCmykToHls()
        {
            Converter preCnv = new Converter();
            RgbColor rc = preCnv.cmykToRgb(trbCyan.Value, trbMagenta.Value, trbYellow.Value, trbKey.Value);
            pb1.BackColor = Color.FromArgb(rc.r, rc.g, rc.b);
            HlsColor hc = Converter.RgbToHls(rc.r, rc.g, rc.b);
            trbHue.Value = hc.h;
            trbLight.Value = hc.l;
            trbSaturation.Value = hc.s;
        }

        private void SetHlsToCmyk()
        {
            
            Converter preCnv = new Converter();
            RgbColor rc = Converter.HlsToRgb(trbHue.Value, trbLight.Value, trbSaturation.Value);
            pb1.BackColor = Color.FromArgb(rc.r, rc.g, rc.b);
            Converter cnv = new Converter();
            CmykColor cm = cnv.rgbToCmyk(rc.r, rc.g, rc.b);
            trbCyan.Value = cm.c;
            trbMagenta.Value = cm.m;
            trbYellow.Value = cm.y;
            trbKey.Value = cm.k;


        }

        private int CheckCmyk(int val)
        {
            return val > 100 ? 100 : val;
        }
        private int CheckHue(int val)
        {
            return val > 360 ? 360 : val;
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
                SetCmykToHls();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Empty input", "Warning!");
            }
           
        }

        private void Hls_Leave(object sender, EventArgs e)
        {
            try
            {
                trbHue.Value = CheckHue(Int32.Parse(tbHue.Text));
                tbHue.Text = trbHue.Value.ToString();
                trbLight.Value = CheckCmyk(Int32.Parse(tbLight.Text));
                tbLight.Text = trbLight.Value.ToString();
                trbSaturation.Value = CheckCmyk(Int32.Parse(tbSaturation.Text));
                tbSaturation.Text = trbSaturation.Value.ToString();
                SetHlsToCmyk();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty input", "Warning!");
            }
            
        }

        private void Hls_scrolling(object sender, EventArgs e)
        {
            SetHlsToCmyk();
        }

        private void Cmyk_scrolling(object sender, EventArgs e)
        {
            SetCmykToHls();
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

        private void TrbHue_ValueChanged(object sender, EventArgs e)
        {
            tbHue.Text = trbHue.Value.ToString();
        }
        private void TrbLight_ValueChanged(object sender, EventArgs e)
        {
            tbLight.Text = trbLight.Value.ToString();
        }
        private void TrbSaturation_ValueChanged(object sender, EventArgs e)
        {
            tbSaturation.Text = trbSaturation.Value.ToString();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | e.KeyChar == '\b') return;
            else e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location
            };

            newForm.Show();
            Hide();
        }
    }
}
