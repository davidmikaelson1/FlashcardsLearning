namespace FlashLearning
{
    partial class ajutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajutor));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(58, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(922, 387);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(239, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(529, 44);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Ghid de utilizare al aplicației de învățare\r\n";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(845, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Închide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "ajutor";
            this.Text = "ajutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}