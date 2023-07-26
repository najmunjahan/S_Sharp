namespace BBMS
{
    partial class AdminLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminloginBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AdminloginBtn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.close_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 3;
            // 
            // cancel
            // 
            this.cancel.AutoSize = true;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.cancel.Location = new System.Drawing.Point(325, 381);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 22);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blood Bank Management System";
            // 
            // AdminloginBtn
            // 
            this.AdminloginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AdminloginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminloginBtn.FlatAppearance.BorderSize = 0;
            this.AdminloginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminloginBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminloginBtn.ForeColor = System.Drawing.Color.White;
            this.AdminloginBtn.Location = new System.Drawing.Point(285, 251);
            this.AdminloginBtn.Name = "AdminloginBtn";
            this.AdminloginBtn.Size = new System.Drawing.Size(148, 35);
            this.AdminloginBtn.TabIndex = 2;
            this.AdminloginBtn.Text = "LOGIN";
            this.AdminloginBtn.UseVisualStyleBackColor = false;
            this.AdminloginBtn.Click += new System.EventHandler(this.AdminloginBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pass);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Location = new System.Drawing.Point(167, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.SystemColors.Control;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.pass.Location = new System.Drawing.Point(55, 10);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(370, 28);
            this.pass.TabIndex = 2;
            this.pass.Text = "Password";
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            this.pass.Enter += new System.EventHandler(this.pass_Enter);
            this.pass.Leave += new System.EventHandler(this.pass_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BBMS.Properties.Resources.passwordpng;
            this.pictureBox3.Location = new System.Drawing.Point(20, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // close_btn
            // 
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.close_btn.Location = new System.Drawing.Point(760, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 40);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(258, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Login To Your Account";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AdminloginBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cancel;
    }
}