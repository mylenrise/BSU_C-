namespace Guide
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кравченя Дарья Дмитриевна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "3 курс, 12 группа";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.ForeColor = System.Drawing.Color.Green;
            this.btAdd.Location = new System.Drawing.Point(287, 453);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(124, 37);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btDelete.Location = new System.Drawing.Point(523, 453);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(124, 37);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Удалить";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(171, 132);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(565, 253);
            this.dgvTable.TabIndex = 7;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btUpdate.ForeColor = System.Drawing.Color.Black;
            this.btUpdate.Location = new System.Drawing.Point(780, 132);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(124, 37);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Обновить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Обувь",
            "Тип"});
            this.comboBox1.Location = new System.Drawing.Point(615, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Обувь";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(519, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Для удаления выделите весь ряд";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

