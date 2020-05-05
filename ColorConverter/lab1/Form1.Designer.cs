namespace lab1
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.tbRed = new System.Windows.Forms.TextBox();
            this.tbBlue = new System.Windows.Forms.TextBox();
            this.tbGreen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMagenta = new System.Windows.Forms.TextBox();
            this.tbYellow = new System.Windows.Forms.TextBox();
            this.tbCyan = new System.Windows.Forms.TextBox();
            this.trbYellow = new System.Windows.Forms.TrackBar();
            this.trbCyan = new System.Windows.Forms.TrackBar();
            this.trbMagenta = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.trbKey = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCyan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbKey)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Color pallete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(265, 186);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(287, 56);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.Value = 255;
            this.trbGreen.Scroll += new System.EventHandler(this.Rgb_Scrolling);
            this.trbGreen.ValueChanged += new System.EventHandler(this.TrbGreen_ValueChanged);
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(265, 115);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(287, 56);
            this.trbRed.TabIndex = 2;
            this.trbRed.Value = 255;
            this.trbRed.Scroll += new System.EventHandler(this.Rgb_Scrolling);
            this.trbRed.ValueChanged += new System.EventHandler(this.TrbRed_ValueChanged);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(265, 257);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(287, 56);
            this.trbBlue.TabIndex = 3;
            this.trbBlue.Value = 255;
            this.trbBlue.Scroll += new System.EventHandler(this.Rgb_Scrolling);
            this.trbBlue.ValueChanged += new System.EventHandler(this.TrbBlue_ValueChanged);
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(96, 133);
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(100, 22);
            this.tbRed.TabIndex = 4;
            this.tbRed.Text = "255";
            this.tbRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbRed.Leave += new System.EventHandler(this.Rgb_Leave);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(96, 266);
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(100, 22);
            this.tbBlue.TabIndex = 5;
            this.tbBlue.Text = "255";
            this.tbBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbBlue.Leave += new System.EventHandler(this.Rgb_Leave);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(96, 200);
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(100, 22);
            this.tbGreen.TabIndex = 6;
            this.tbGreen.Text = "255";
            this.tbGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbGreen.Leave += new System.EventHandler(this.Rgb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "R:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "G:";
            // 
            // pb1
            // 
            this.pb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb1.Location = new System.Drawing.Point(622, 113);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(217, 200);
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "M:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "C";
            // 
            // tbMagenta
            // 
            this.tbMagenta.Location = new System.Drawing.Point(952, 180);
            this.tbMagenta.Name = "tbMagenta";
            this.tbMagenta.Size = new System.Drawing.Size(100, 22);
            this.tbMagenta.TabIndex = 17;
            this.tbMagenta.Text = "0";
            this.tbMagenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbMagenta.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // tbYellow
            // 
            this.tbYellow.Location = new System.Drawing.Point(952, 220);
            this.tbYellow.Name = "tbYellow";
            this.tbYellow.Size = new System.Drawing.Size(100, 22);
            this.tbYellow.TabIndex = 16;
            this.tbYellow.Text = "0";
            this.tbYellow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbYellow.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // tbCyan
            // 
            this.tbCyan.Location = new System.Drawing.Point(952, 133);
            this.tbCyan.Name = "tbCyan";
            this.tbCyan.Size = new System.Drawing.Size(100, 22);
            this.tbCyan.TabIndex = 15;
            this.tbCyan.Text = "0";
            this.tbCyan.TextChanged += new System.EventHandler(this.tbCyan_TextChanged);
            this.tbCyan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.tbCyan.Leave += new System.EventHandler(this.Cmyk_Leave);
            // 
            // trbYellow
            // 
            this.trbYellow.Location = new System.Drawing.Point(1121, 211);
            this.trbYellow.Maximum = 100;
            this.trbYellow.Name = "trbYellow";
            this.trbYellow.Size = new System.Drawing.Size(287, 56);
            this.trbYellow.TabIndex = 14;
            this.trbYellow.Scroll += new System.EventHandler(this.Cmyk_Scrolling);
            this.trbYellow.ValueChanged += new System.EventHandler(this.TrbYellow_ValueChanged);
            // 
            // trbCyan
            // 
            this.trbCyan.Location = new System.Drawing.Point(1121, 115);
            this.trbCyan.Maximum = 100;
            this.trbCyan.Name = "trbCyan";
            this.trbCyan.Size = new System.Drawing.Size(287, 56);
            this.trbCyan.TabIndex = 13;
            this.trbCyan.Scroll += new System.EventHandler(this.Cmyk_Scrolling);
            this.trbCyan.ValueChanged += new System.EventHandler(this.TrbCyan_ValueChanged);
            // 
            // trbMagenta
            // 
            this.trbMagenta.Location = new System.Drawing.Point(1121, 166);
            this.trbMagenta.Maximum = 100;
            this.trbMagenta.Name = "trbMagenta";
            this.trbMagenta.Size = new System.Drawing.Size(287, 56);
            this.trbMagenta.TabIndex = 12;
            this.trbMagenta.Scroll += new System.EventHandler(this.Cmyk_Scrolling);
            this.trbMagenta.ValueChanged += new System.EventHandler(this.TrbMagenta_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "K:";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(952, 266);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(100, 22);
            this.tbKey.TabIndex = 22;
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
            this.trbKey.TabIndex = 21;
            this.trbKey.Scroll += new System.EventHandler(this.Cmyk_Scrolling);
            this.trbKey.ValueChanged += new System.EventHandler(this.TrbKey_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1058, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1058, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1058, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1058, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(606, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(256, 35);
            this.label15.TabIndex = 59;
            this.label15.Text = "RGB <=> CMYK";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(1021, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 49);
            this.button2.TabIndex = 62;
            this.button2.Text = "CMYK - HLS";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
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
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbRed);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbCyan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TextBox tbRed;
        private System.Windows.Forms.TextBox tbBlue;
        private System.Windows.Forms.TextBox tbGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMagenta;
        private System.Windows.Forms.TextBox tbYellow;
        private System.Windows.Forms.TextBox tbCyan;
        private System.Windows.Forms.TrackBar trbYellow;
        private System.Windows.Forms.TrackBar trbCyan;
        private System.Windows.Forms.TrackBar trbMagenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TrackBar trbKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
    }
}

