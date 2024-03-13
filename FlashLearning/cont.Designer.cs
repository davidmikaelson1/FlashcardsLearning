namespace FlashLearning
{
    partial class account
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
            this.numeUtilizator = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.reenter_password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.reenter_password_text = new System.Windows.Forms.TextBox();
            this.log_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeUtilizator
            // 
            this.numeUtilizator.AutoSize = true;
            this.numeUtilizator.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeUtilizator.ForeColor = System.Drawing.Color.Maroon;
            this.numeUtilizator.Location = new System.Drawing.Point(78, 101);
            this.numeUtilizator.Margin = new System.Windows.Forms.Padding(0);
            this.numeUtilizator.Name = "numeUtilizator";
            this.numeUtilizator.Size = new System.Drawing.Size(164, 36);
            this.numeUtilizator.TabIndex = 0;
            this.numeUtilizator.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Enabled = false;
            this.password.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Maroon;
            this.password.Location = new System.Drawing.Point(78, 156);
            this.password.Margin = new System.Windows.Forms.Padding(0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(157, 36);
            this.password.TabIndex = 1;
            this.password.Text = "Password:";
            this.password.Visible = false;
            // 
            // reenter_password
            // 
            this.reenter_password.AutoSize = true;
            this.reenter_password.Enabled = false;
            this.reenter_password.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter_password.ForeColor = System.Drawing.Color.Maroon;
            this.reenter_password.Location = new System.Drawing.Point(78, 209);
            this.reenter_password.Margin = new System.Windows.Forms.Padding(0);
            this.reenter_password.Name = "reenter_password";
            this.reenter_password.Size = new System.Drawing.Size(270, 36);
            this.reenter_password.TabIndex = 2;
            this.reenter_password.Text = "Reenter password:";
            this.reenter_password.Visible = false;
            this.reenter_password.Click += new System.EventHandler(this.confirmaParola_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Wheat;
            this.username.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(235, 101);
            this.username.Margin = new System.Windows.Forms.Padding(0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(399, 44);
            this.username.TabIndex = 3;
            // 
            // password_text
            // 
            this.password_text.BackColor = System.Drawing.Color.Wheat;
            this.password_text.Enabled = false;
            this.password_text.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.ForeColor = System.Drawing.Color.Black;
            this.password_text.Location = new System.Drawing.Point(228, 154);
            this.password_text.Margin = new System.Windows.Forms.Padding(0);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(406, 44);
            this.password_text.TabIndex = 4;
            this.password_text.UseSystemPasswordChar = true;
            this.password_text.Visible = false;
            // 
            // reenter_password_text
            // 
            this.reenter_password_text.BackColor = System.Drawing.Color.Wheat;
            this.reenter_password_text.Enabled = false;
            this.reenter_password_text.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reenter_password_text.ForeColor = System.Drawing.Color.Black;
            this.reenter_password_text.Location = new System.Drawing.Point(340, 209);
            this.reenter_password_text.Margin = new System.Windows.Forms.Padding(0);
            this.reenter_password_text.Name = "reenter_password_text";
            this.reenter_password_text.Size = new System.Drawing.Size(294, 44);
            this.reenter_password_text.TabIndex = 5;
            this.reenter_password_text.UseSystemPasswordChar = true;
            this.reenter_password_text.Visible = false;
            this.reenter_password_text.TextChanged += new System.EventHandler(this.textConfirmaParola_TextChanged);
            // 
            // log_in
            // 
            this.log_in.AutoSize = true;
            this.log_in.BackColor = System.Drawing.Color.AntiqueWhite;
            this.log_in.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_in.ForeColor = System.Drawing.Color.Maroon;
            this.log_in.Location = new System.Drawing.Point(408, 267);
            this.log_in.Margin = new System.Windows.Forms.Padding(0);
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(226, 46);
            this.log_in.TabIndex = 6;
            this.log_in.Text = "Log in";
            this.log_in.UseVisualStyleBackColor = false;
            this.log_in.Click += new System.EventHandler(this.button1_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(698, 424);
            this.Controls.Add(this.log_in);
            this.Controls.Add(this.reenter_password_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username);
            this.Controls.Add(this.reenter_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.numeUtilizator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "account";
            this.Text = "cont";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeUtilizator;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label reenter_password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.TextBox reenter_password_text;
        private System.Windows.Forms.Button log_in;
    }
}