namespace FlashLearning
{
    partial class add_a_question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_a_question));
            this.textIntrebare = new System.Windows.Forms.TextBox();
            this.figurina = new System.Windows.Forms.PictureBox();
            this.textRaspuns = new System.Windows.Forms.TextBox();
            this.adaugaIntrebarea = new System.Windows.Forms.Button();
            this.renunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.figurina)).BeginInit();
            this.SuspendLayout();
            // 
            // textIntrebare
            // 
            this.textIntrebare.BackColor = System.Drawing.Color.Wheat;
            this.textIntrebare.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIntrebare.ForeColor = System.Drawing.Color.Black;
            this.textIntrebare.Location = new System.Drawing.Point(444, 44);
            this.textIntrebare.Margin = new System.Windows.Forms.Padding(0);
            this.textIntrebare.Multiline = true;
            this.textIntrebare.Name = "textIntrebare";
            this.textIntrebare.Size = new System.Drawing.Size(605, 341);
            this.textIntrebare.TabIndex = 3;
            this.textIntrebare.Text = "Write here your question";
            // 
            // figurina
            // 
            this.figurina.Image = ((System.Drawing.Image)(resources.GetObject("figurina.Image")));
            this.figurina.Location = new System.Drawing.Point(12, 84);
            this.figurina.Name = "figurina";
            this.figurina.Size = new System.Drawing.Size(441, 432);
            this.figurina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.figurina.TabIndex = 5;
            this.figurina.TabStop = false;
            // 
            // textRaspuns
            // 
            this.textRaspuns.BackColor = System.Drawing.Color.Wheat;
            this.textRaspuns.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRaspuns.ForeColor = System.Drawing.Color.Black;
            this.textRaspuns.Location = new System.Drawing.Point(444, 395);
            this.textRaspuns.Margin = new System.Windows.Forms.Padding(0);
            this.textRaspuns.Multiline = true;
            this.textRaspuns.Name = "textRaspuns";
            this.textRaspuns.Size = new System.Drawing.Size(605, 121);
            this.textRaspuns.TabIndex = 6;
            this.textRaspuns.Text = "Write here the correct answer";
            // 
            // adaugaIntrebarea
            // 
            this.adaugaIntrebarea.AutoSize = true;
            this.adaugaIntrebarea.BackColor = System.Drawing.Color.Wheat;
            this.adaugaIntrebarea.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaIntrebarea.ForeColor = System.Drawing.Color.Maroon;
            this.adaugaIntrebarea.Location = new System.Drawing.Point(767, 525);
            this.adaugaIntrebarea.Margin = new System.Windows.Forms.Padding(0);
            this.adaugaIntrebarea.Name = "adaugaIntrebarea";
            this.adaugaIntrebarea.Size = new System.Drawing.Size(282, 46);
            this.adaugaIntrebarea.TabIndex = 7;
            this.adaugaIntrebarea.Text = "Add question";
            this.adaugaIntrebarea.UseVisualStyleBackColor = false;
            this.adaugaIntrebarea.Click += new System.EventHandler(this.button2_Click);
            // 
            // renunta
            // 
            this.renunta.AutoSize = true;
            this.renunta.BackColor = System.Drawing.Color.Wheat;
            this.renunta.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renunta.ForeColor = System.Drawing.Color.Maroon;
            this.renunta.Location = new System.Drawing.Point(610, 525);
            this.renunta.Margin = new System.Windows.Forms.Padding(0);
            this.renunta.Name = "renunta";
            this.renunta.Size = new System.Drawing.Size(143, 46);
            this.renunta.TabIndex = 8;
            this.renunta.Text = "Give up";
            this.renunta.UseVisualStyleBackColor = false;
            this.renunta.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_a_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.renunta);
            this.Controls.Add(this.adaugaIntrebarea);
            this.Controls.Add(this.textRaspuns);
            this.Controls.Add(this.textIntrebare);
            this.Controls.Add(this.figurina);
            this.Name = "add_a_question";
            this.Text = "adaugare";
            this.Load += new System.EventHandler(this.form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.figurina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textIntrebare;
        private System.Windows.Forms.PictureBox figurina;
        private System.Windows.Forms.TextBox textRaspuns;
        private System.Windows.Forms.Button adaugaIntrebarea;
        private System.Windows.Forms.Button renunta;
    }
}