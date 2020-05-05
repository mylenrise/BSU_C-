namespace lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.trbKey = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMagenta = new System.Windows.Forms.TextBox();
            this.tbYellow = new System.Windows.Forms.TextBox();
            this.tbCyan = new System.Windows.Forms.TextBox();
            this.trbYellow = new System.Windows.Forms.TrackBar();
            this.trbCyan = new System.Windows.Forms.TrackBar();
            this.trbMagenta = new System.Windows.Forms.TrackBar();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLight = new System.Windows.Forms.TextBox();
            this.tbSaturation = new System.Windows.Forms.TextBox();
            this.tbHue = new System.Windows.Forms.TextBox();
            this.trbSaturation = new System.Windows.Forms.TrackBar();
            this.trbHue = new System.Windows.Forms.TrackBar();
            this.trbLight = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLight)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1058, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1058, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1058, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1058, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "K:";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(952, 266);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 22);
            this.tbKey.TabIndex = 50;
            this.tbKey.Text = "0";
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbKey.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // trbKey
            // 
            this.trbKey.Location = new System.Drawing.Point(1121, 257);
            this.trbKey.Maximum = 100;
            this.trbKey.Name = "trbKey";
            this.trbKey.Size = new System.Drawing.Size(287, 56);
            this.trbKey.TabIndex = 49;
            this.trbKey.Scroll += new System.EventHandler(this.Cmyk_scrolling);
            this.trbKey.ValueChanged += new System.EventHandler(this.TrbKey_ValueChanged);
            this.trbKey.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "M:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "C";
            // 
            // tbMagenta
            // 
            this.tbMagenta.Location = new System.Drawing.Point(952, 180);
            this.tbMagenta.Name = "tbMagenta";
            this.tbMagenta.Size = new System.Drawing.Size(100, 22);
            this.tbMagenta.TabIndex = 45;
            this.tbMagenta.Text = "0";
            this.tbMagenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbMagenta.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // tbYellow
            // 
            this.tbYellow.Location = new System.Drawing.Point(952, 220);
            this.tbYellow.Name = "tbYellow";
            this.tbYellow.Size = new System.Drawing.Size(100, 22);
            this.tbYellow.TabIndex = 44;
            this.tbYellow.Text = "0";
            this.tbYellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbYellow.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // tbCyan
            // 
            this.tbCyan.Location = new System.Drawing.Point(952, 133);
            this.tbCyan.Name = "tbCyan";
            this.tbCyan.Size = new System.Drawing.Size(100, 22);
            this.tbCyan.TabIndex = 43;
            this.tbCyan.Text = "0";
            this.tbCyan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbCyan.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // trbYellow
            // 
            this.trbYellow.Location = new System.Drawing.Point(1121, 211);
            this.trbYellow.Maximum = 100;
            this.trbYellow.Name = "trbYellow";
            this.trbYellow.Size = new System.Drawing.Size(287, 56);
            this.trbYellow.TabIndex = 42;
            this.trbYellow.Scroll += new System.EventHandler(this.Cmyk_scrolling);
            this.trbYellow.ValueChanged += new System.EventHandler(this.TrbYellow_ValueChanged);
            this.trbYellow.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // trbCyan
            // 
            this.trbCyan.Location = new System.Drawing.Point(1121, 115);
            this.trbCyan.Maximum = 100;
            this.trbCyan.Name = "trbCyan";
            this.trbCyan.Size = new System.Drawing.Size(287, 56);
            this.trbCyan.TabIndex = 41;
            this.trbCyan.Scroll += new System.EventHandler(this.Cmyk_scrolling);
            this.trbCyan.ValueChanged += new System.EventHandler(this.TrbCyan_ValueChanged);
            this.trbCyan.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // trbMagenta
            // 
            this.trbMagenta.Location = new System.Drawing.Point(1121, 166);
            this.trbMagenta.Maximum = 100;
            this.trbMagenta.Name = "trbMagenta";
            this.trbMagenta.Size = new System.Drawing.Size(287, 56);
            this.trbMagenta.TabIndex = 40;
            this.trbMagenta.Scroll += new System.EventHandler(this.Cmyk_scrolling);
            this.trbMagenta.ValueChanged += new System.EventHandler(this.TrbMagenta_ValueChanged);
            this.trbMagenta.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(622, 113);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(217, 200);
            this.pb1.TabIndex = 39;
            this.pb1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "L:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "S:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "H:";
            // 
            // tbLight
            // 
            this.tbLight.Location = new System.Drawing.Point(96, 200);
            this.tbLight.Name = "tbLight";
            this.tbLight.Size = new System.Drawing.Size(100, 22);
            this.tbLight.TabIndex = 35;
            this.tbLight.Text = "100";
            this.tbLight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbLight.Leave += new System.EventHandler(this.Hls_Leave);
            // 
            // tbSaturation
            // 
            this.tbSaturation.Location = new System.Drawing.Point(96, 266);
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(100, 22);
            this.tbSaturation.TabIndex = 34;
            this.tbSaturation.Text = "100";
            this.tbSaturation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbSaturation.Leave += new System.EventHandler(this.Hls_Leave);
            // 
            // tbHue
            // 
            this.tbHue.Location = new System.Drawing.Point(96, 133);
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(100, 22);
            this.tbHue.TabIndex = 33;
            this.tbHue.Text = "360";
            this.tbHue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbHue.Leave += new System.EventHandler(this.Hls_Leave);
            // 
            // trbSaturation
            // 
            this.trbSaturation.Location = new System.Drawing.Point(265, 257);
            this.trbSaturation.Maximum = 100;
            this.trbSaturation.Name = "trbSaturation";
            this.trbSaturation.Size = new System.Drawing.Size(287, 56);
            this.trbSaturation.TabIndex = 32;
            this.trbSaturation.Value = 100;
            this.trbSaturation.Scroll += new System.EventHandler(this.Hls_scrolling);
            this.trbSaturation.ValueChanged += new System.EventHandler(this.TrbSaturation_ValueChanged);
            // 
            // trbHue
            // 
            this.trbHue.Location = new System.Drawing.Point(265, 115);
            this.trbHue.Maximum = 360;
            this.trbHue.Name = "trbHue";
            this.trbHue.Size = new System.Drawing.Size(287, 56);
            this.trbHue.TabIndex = 31;
            this.trbHue.Value = 350;
            this.trbHue.Scroll += new System.EventHandler(this.Hls_scrolling);
            this.trbHue.ValueChanged += new System.EventHandler(this.TrbHue_ValueChanged);
            // 
            // trbLight
            // 
            this.trbLight.Location = new System.Drawing.Point(265, 186);
            this.trbLight.Maximum = 100;
            this.trbLight.Name = "trbLight";
            this.trbLight.Size = new System.Drawing.Size(287, 56);
            this.trbLight.TabIndex = 30;
            this.trbLight.Value = 100;
            this.trbLight.Scroll += new System.EventHandler(this.Hls_scrolling);
            this.trbLight.ValueChanged += new System.EventHandler(this.TrbLight_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Color pallete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(606, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(252, 35);
            this.label14.TabIndex = 58;
            this.label14.Text = "HLS <=> CMYK";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 59;
            this.label13.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(202, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "%";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(1021, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 49);
            this.button2.TabIndex = 63;
            this.button2.Text = "RGB - CMYK";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.trbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMagenta);
            this.Controls.Add(this.tbYellow);
            this.Controls.Add(this.tbCyan);
            this.Controls.Add(this.trbYellow);
            this.Controls.Add(this.trbCyan);
            this.Controls.Add(this.trbMagenta);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLight);
            this.Controls.Add(this.tbSaturation);
            this.Controls.Add(this.tbHue);
            this.Controls.Add(this.trbSaturation);
            this.Controls.Add(this.trbHue);
            this.Controls.Add(this.trbLight);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TrackBar trbKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMagenta;
        private System.Windows.Forms.TextBox tbYellow;
        private System.Windows.Forms.TextBox tbCyan;
        private System.Windows.Forms.TrackBar trbYellow;
        private System.Windows.Forms.TrackBar trbCyan;
        private System.Windows.Forms.TrackBar trbMagenta;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLight;
        private System.Windows.Forms.TextBox tbSaturation;
        private System.Windows.Forms.TextBox tbHue;
        private System.Windows.Forms.TrackBar trbSaturation;
        private System.Windows.Forms.TrackBar trbHue;
        private System.Windows.Forms.TrackBar trbLight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
    }
}