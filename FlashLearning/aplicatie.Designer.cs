namespace FlashLearning
{
    partial class aplicatie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aplicatie));
            this.meniu = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start_learning = new System.Windows.Forms.ToolStripMenuItem();
            this.add_a_flashcard = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutor = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enter_account = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_account = new System.Windows.Forms.ToolStripMenuItem();
            this.figurina = new System.Windows.Forms.PictureBox();
            this.question_text = new System.Windows.Forms.TextBox();
            this.answer_text = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.go_forward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_question = new System.Windows.Forms.Button();
            this.meniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figurina)).BeginInit();
            this.SuspendLayout();
            // 
            // meniu
            // 
            this.meniu.BackColor = System.Drawing.Color.Transparent;
            this.meniu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.meniu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.meniu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.meniu.Location = new System.Drawing.Point(0, 0);
            this.meniu.Name = "meniu";
            this.meniu.Size = new System.Drawing.Size(1058, 46);
            this.meniu.TabIndex = 0;
            this.meniu.Text = "menuStrip1";
            this.meniu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.meniu_ItemClicked);
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_learning,
            this.add_a_flashcard,
            this.ajutor});
            this.meniuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(100, 42);
            this.meniuToolStripMenuItem.Text = "Menu";
            this.meniuToolStripMenuItem.Click += new System.EventHandler(this.meniuToolStripMenuItem_Click);
            // 
            // start_learning
            // 
            this.start_learning.BackColor = System.Drawing.Color.AntiqueWhite;
            this.start_learning.Enabled = false;
            this.start_learning.ForeColor = System.Drawing.Color.Maroon;
            this.start_learning.Name = "start_learning";
            this.start_learning.Size = new System.Drawing.Size(403, 44);
            this.start_learning.Text = "Start learning";
            this.start_learning.Click += new System.EventHandler(this.add_new_item_ToolStripMenuItem_Click);
            // 
            // add_a_flashcard
            // 
            this.add_a_flashcard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.add_a_flashcard.Enabled = false;
            this.add_a_flashcard.ForeColor = System.Drawing.Color.Maroon;
            this.add_a_flashcard.Name = "add_a_flashcard";
            this.add_a_flashcard.Size = new System.Drawing.Size(403, 44);
            this.add_a_flashcard.Text = "Add a new flashcard";
            this.add_a_flashcard.Click += new System.EventHandler(this.adaugaUnFlashcardToolStripMenuItem1_Click);
            // 
            // ajutor
            // 
            this.ajutor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ajutor.ForeColor = System.Drawing.Color.Maroon;
            this.ajutor.Name = "ajutor";
            this.ajutor.Size = new System.Drawing.Size(403, 44);
            this.ajutor.Text = "Help";
            this.ajutor.Click += new System.EventHandler(this.help_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enter_account,
            this.exit_account});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(145, 42);
            this.loginToolStripMenuItem.Text = "Account";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // enter_account
            // 
            this.enter_account.BackColor = System.Drawing.Color.AntiqueWhite;
            this.enter_account.ForeColor = System.Drawing.Color.Maroon;
            this.enter_account.Name = "enter_account";
            this.enter_account.Size = new System.Drawing.Size(226, 44);
            this.enter_account.Text = "Log in";
            this.enter_account.Click += new System.EventHandler(this.enter_account_ToolStripMenuItem_Click);
            // 
            // exit_account
            // 
            this.exit_account.BackColor = System.Drawing.Color.AntiqueWhite;
            this.exit_account.Enabled = false;
            this.exit_account.ForeColor = System.Drawing.Color.Maroon;
            this.exit_account.Name = "exit_account";
            this.exit_account.Size = new System.Drawing.Size(226, 44);
            this.exit_account.Text = "Log out";
            this.exit_account.Click += new System.EventHandler(this.exit_account_ToolStripMenuItem_Click);
            // 
            // figurina
            // 
            this.figurina.Image = ((System.Drawing.Image)(resources.GetObject("figurina.Image")));
            this.figurina.Location = new System.Drawing.Point(605, 120);
            this.figurina.Name = "figurina";
            this.figurina.Size = new System.Drawing.Size(441, 432);
            this.figurina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.figurina.TabIndex = 1;
            this.figurina.TabStop = false;
            // 
            // question_text
            // 
            this.question_text.BackColor = System.Drawing.Color.Wheat;
            this.question_text.Enabled = false;
            this.question_text.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_text.ForeColor = System.Drawing.Color.Black;
            this.question_text.Location = new System.Drawing.Point(12, 80);
            this.question_text.Margin = new System.Windows.Forms.Padding(0);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(618, 341);
            this.question_text.TabIndex = 2;
            this.question_text.Text = "Are you ready for a new smart learning session?";
            this.question_text.TextChanged += new System.EventHandler(this.question_text_TextChanged);
            // 
            // answer_text
            // 
            this.answer_text.BackColor = System.Drawing.Color.Wheat;
            this.answer_text.Enabled = false;
            this.answer_text.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_text.ForeColor = System.Drawing.Color.Black;
            this.answer_text.Location = new System.Drawing.Point(12, 431);
            this.answer_text.Margin = new System.Windows.Forms.Padding(0);
            this.answer_text.Multiline = true;
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(618, 121);
            this.answer_text.TabIndex = 3;
            this.answer_text.Text = "Write your answer here";
            this.answer_text.Visible = false;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.BackColor = System.Drawing.Color.AntiqueWhite;
            this.check.Enabled = false;
            this.check.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Maroon;
            this.check.Location = new System.Drawing.Point(262, 558);
            this.check.Margin = new System.Windows.Forms.Padding(0);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(157, 46);
            this.check.TabIndex = 4;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.button1_Click);
            // 
            // go_forward
            // 
            this.go_forward.AutoSize = true;
            this.go_forward.BackColor = System.Drawing.Color.AntiqueWhite;
            this.go_forward.Enabled = false;
            this.go_forward.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_forward.ForeColor = System.Drawing.Color.Maroon;
            this.go_forward.Location = new System.Drawing.Point(427, 558);
            this.go_forward.Margin = new System.Windows.Forms.Padding(0);
            this.go_forward.Name = "go_forward";
            this.go_forward.Size = new System.Drawing.Size(213, 46);
            this.go_forward.TabIndex = 5;
            this.go_forward.Text = "Next question";
            this.go_forward.UseVisualStyleBackColor = false;
            this.go_forward.Visible = false;
            this.go_forward.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(273, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 36);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // delete_question
            // 
            this.delete_question.AutoSize = true;
            this.delete_question.BackColor = System.Drawing.Color.AntiqueWhite;
            this.delete_question.Enabled = false;
            this.delete_question.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_question.ForeColor = System.Drawing.Color.Maroon;
            this.delete_question.Location = new System.Drawing.Point(12, 558);
            this.delete_question.Margin = new System.Windows.Forms.Padding(0);
            this.delete_question.Name = "delete_question";
            this.delete_question.Size = new System.Drawing.Size(241, 46);
            this.delete_question.TabIndex = 8;
            this.delete_question.Text = "Delete question";
            this.delete_question.UseVisualStyleBackColor = false;
            this.delete_question.Visible = false;
            this.delete_question.Click += new System.EventHandler(this.stergeIntrebarea_Click_1);
            // 
            // aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.delete_question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.go_forward);
            this.Controls.Add(this.check);
            this.Controls.Add(this.answer_text);
            this.Controls.Add(this.question_text);
            this.Controls.Add(this.figurina);
            this.Controls.Add(this.meniu);
            this.MainMenuStrip = this.meniu;
            this.Name = "aplicatie";
            this.Text = "aplicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.meniu.ResumeLayout(false);
            this.meniu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.figurina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meniu;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem start_learning;
        private System.Windows.Forms.ToolStripMenuItem add_a_flashcard;
        private System.Windows.Forms.ToolStripMenuItem ajutor;
        private System.Windows.Forms.PictureBox figurina;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.TextBox answer_text;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button go_forward;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enter_account;
        private System.Windows.Forms.ToolStripMenuItem exit_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_question;
    }
}

