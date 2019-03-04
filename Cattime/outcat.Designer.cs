namespace Cattime
{
    partial class outcat
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
            this.comx1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numtext = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboB1 = new System.Windows.Forms.ComboBox();
            this.pricel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtext)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "品种";
            // 
            // comx1
            // 
            this.comx1.FormattingEnabled = true;
            this.comx1.Location = new System.Drawing.Point(107, 219);
            this.comx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comx1.Name = "comx1";
            this.comx1.Size = new System.Drawing.Size(120, 23);
            this.comx1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 212);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(21, 278);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(627, 238);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "品种";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "数量";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "进价";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "总价";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(343, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "售价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(47, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "品种";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "售出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numtext
            // 
            this.numtext.Font = new System.Drawing.Font("宋体", 12F);
            this.numtext.Location = new System.Drawing.Point(200, 55);
            this.numtext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numtext.Name = "numtext";
            this.numtext.Size = new System.Drawing.Size(115, 30);
            this.numtext.TabIndex = 4;
            this.numtext.ValueChanged += new System.EventHandler(this.numtext_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(197, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "数量";
            // 
            // comboB1
            // 
            this.comboB1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboB1.FormattingEnabled = true;
            this.comboB1.Location = new System.Drawing.Point(49, 56);
            this.comboB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboB1.Name = "comboB1";
            this.comboB1.Size = new System.Drawing.Size(120, 28);
            this.comboB1.TabIndex = 1;
            this.comboB1.SelectedIndexChanged += new System.EventHandler(this.comboB1_SelectedIndexChanged);
            // 
            // pricel
            // 
            this.pricel.AutoSize = true;
            this.pricel.Font = new System.Drawing.Font("宋体", 12F);
            this.pricel.Location = new System.Drawing.Point(353, 60);
            this.pricel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pricel.Name = "pricel";
            this.pricel.Size = new System.Drawing.Size(89, 20);
            this.pricel.TabIndex = 17;
            this.pricel.Text = "  0 (￥)";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("宋体", 12F);
            this.sum.Location = new System.Drawing.Point(505, 60);
            this.sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(99, 20);
            this.sum.TabIndex = 19;
            this.sum.Text = "   0 (￥)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(505, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "总价";
            // 
            // outcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 554);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.pricel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboB1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "outcat";
            this.Text = "售卖";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comx1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboB1;
        private System.Windows.Forms.Label pricel;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}