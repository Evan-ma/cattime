namespace Cattime
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.job_num = new System.Windows.Forms.TextBox();
            this.paswd = new System.Windows.Forms.TextBox();
            this.land_btm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // job_num
            // 
            this.job_num.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.job_num.Font = new System.Drawing.Font("华文中宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.job_num.Location = new System.Drawing.Point(413, 88);
            this.job_num.Margin = new System.Windows.Forms.Padding(4);
            this.job_num.Name = "job_num";
            this.job_num.Size = new System.Drawing.Size(203, 42);
            this.job_num.TabIndex = 0;
            // 
            // paswd
            // 
            this.paswd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.paswd.Font = new System.Drawing.Font("华文中宋", 15.75F);
            this.paswd.Location = new System.Drawing.Point(413, 166);
            this.paswd.Margin = new System.Windows.Forms.Padding(4);
            this.paswd.Name = "paswd";
            this.paswd.PasswordChar = '@';
            this.paswd.Size = new System.Drawing.Size(203, 42);
            this.paswd.TabIndex = 1;
            this.paswd.UseSystemPasswordChar = true;
            // 
            // land_btm
            // 
            this.land_btm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.land_btm.Location = new System.Drawing.Point(563, 272);
            this.land_btm.Margin = new System.Windows.Forms.Padding(4);
            this.land_btm.Name = "land_btm";
            this.land_btm.Size = new System.Drawing.Size(100, 39);
            this.land_btm.TabIndex = 2;
            this.land_btm.Text = "登陆";
            this.land_btm.UseVisualStyleBackColor = false;
            this.land_btm.Click += new System.EventHandler(this.land_btm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文中宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(336, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "工号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文中宋", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(336, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.land_btm);
            this.Controls.Add(this.paswd);
            this.Controls.Add(this.job_num);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(727, 401);
            this.MinimumSize = new System.Drawing.Size(727, 401);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox job_num;
        private System.Windows.Forms.TextBox paswd;
        private System.Windows.Forms.Button land_btm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}