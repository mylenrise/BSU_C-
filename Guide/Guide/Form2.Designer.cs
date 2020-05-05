namespace Guide
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.ComboBox();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(141, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(141, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Стоимость";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(324, 141);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(114, 22);
            this.tbName.TabIndex = 11;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(324, 255);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(114, 22);
            this.tbPrice.TabIndex = 12;
            this.tbPrice.Leave += new System.EventHandler(this.tbPrice_Leave);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(324, 318);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(114, 22);
            this.tbNum.TabIndex = 15;
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(141, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(234, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Добавить";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbType
            // 
            this.tbType.FormattingEnabled = true;
            this.tbType.Items.AddRange(new object[] {
            "Кроссовки",
            "Ботинки",
            "Лоферы",
            "Туфли на каблуке",
            "Туфли на плоской подошве",
            "Слиперы"});
            this.tbType.Location = new System.Drawing.Point(324, 194);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(114, 24);
            this.tbType.TabIndex = 17;
            this.tbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(252, 376);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 460);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form2";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tbType;
        private System.Windows.Forms.Button btOk;
    }
}