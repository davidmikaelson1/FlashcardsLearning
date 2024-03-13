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
            this.incepeSaInveti = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaUnFlashcard = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutor = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intraInCont = new System.Windows.Forms.ToolStripMenuItem();
            this.iesiDinCont = new System.Windows.Forms.ToolStripMenuItem();
            this.figurina = new System.Windows.Forms.PictureBox();
            this.textIntrebare = new System.Windows.Forms.TextBox();
            this.textRaspuns = new System.Windows.Forms.TextBox();
            this.verifica = new System.Windows.Forms.Button();
            this.maiDeparte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stergeIntrebarea = new System.Windows.Forms.Button();
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
            this.meniu.Size = new System.Drawing.Size(1058, 44);
            this.meniu.TabIndex = 0;
            this.meniu.Text = "menuStrip1";
            this.meniu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.meniu_ItemClicked);
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incepeSaInveti,
            this.adaugaUnFlashcard,
            this.ajutor});
            this.meniuToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniuToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(109, 40);
            this.meniuToolStripMenuItem.Text = "Meniu";
            this.meniuToolStripMenuItem.Click += new System.EventHandler(this.meniuToolStripMenuItem_Click);
            // 
            // incepeSaInveti
            // 
            this.incepeSaInveti.BackColor = System.Drawing.Color.AntiqueWhite;
            this.incepeSaInveti.Enabled = false;
            this.incepeSaInveti.ForeColor = System.Drawing.Color.Maroon;
            this.incepeSaInveti.Name = "incepeSaInveti";
            this.incepeSaInveti.Size = new System.Drawing.Size(408, 44);
            this.incepeSaInveti.Text = "Incepe sa inveti";
            this.incepeSaInveti.Click += new System.EventHandler(this.adaugaUnFlashcardToolStripMenuItem_Click);
            // 
            // adaugaUnFlashcard
            // 
            this.adaugaUnFlashcard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.adaugaUnFlashcard.Enabled = false;
            this.adaugaUnFlashcard.ForeColor = System.Drawing.Color.Maroon;
            this.adaugaUnFlashcard.Name = "adaugaUnFlashcard";
            this.adaugaUnFlashcard.Size = new System.Drawing.Size(408, 44);
            this.adaugaUnFlashcard.Text = "Adauga un flashcard";
            this.adaugaUnFlashcard.Click += new System.EventHandler(this.adaugaUnFlashcardToolStripMenuItem1_Click);
            // 
            // ajutor
            // 
            this.ajutor.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ajutor.ForeColor = System.Drawing.Color.Maroon;
            this.ajutor.Name = "ajutor";
            this.ajutor.Size = new System.Drawing.Size(408, 44);
            this.ajutor.Text = "Ajutor";
            this.ajutor.Click += new System.EventHandler(this.ajutor_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intraInCont,
            this.iesiDinCont});
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(99, 40);
            this.loginToolStripMenuItem.Text = "Cont";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // intraInCont
            // 
            this.intraInCont.BackColor = System.Drawing.Color.AntiqueWhite;
            this.intraInCont.ForeColor = System.Drawing.Color.Maroon;
            this.intraInCont.Name = "intraInCont";
            this.intraInCont.Size = new System.Drawing.Size(292, 44);
            this.intraInCont.Text = "Intra in cont";
            this.intraInCont.Click += new System.EventHandler(this.intraInContToolStripMenuItem_Click);
            // 
            // iesiDinCont
            // 
            this.iesiDinCont.BackColor = System.Drawing.Color.AntiqueWhite;
            this.iesiDinCont.Enabled = false;
            this.iesiDinCont.ForeColor = System.Drawing.Color.Maroon;
            this.iesiDinCont.Name = "iesiDinCont";
            this.iesiDinCont.Size = new System.Drawing.Size(292, 44);
            this.iesiDinCont.Text = "Iesi din cont";
            this.iesiDinCont.Click += new System.EventHandler(this.iesiDinContToolStripMenuItem_Click);
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
            // textIntrebare
            // 
            this.textIntrebare.BackColor = System.Drawing.Color.Wheat;
            this.textIntrebare.Enabled = false;
            this.textIntrebare.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIntrebare.ForeColor = System.Drawing.Color.Black;
            this.textIntrebare.Location = new System.Drawing.Point(12, 80);
            this.textIntrebare.Margin = new System.Windows.Forms.Padding(0);
            this.textIntrebare.Multiline = true;
            this.textIntrebare.Name = "textIntrebare";
            this.textIntrebare.Size = new System.Drawing.Size(618, 341);
            this.textIntrebare.TabIndex = 2;
            this.textIntrebare.Text = "Esti gata pentru o noua sesiune de invatare inteligenta?";
            // 
            // textRaspuns
            // 
            this.textRaspuns.BackColor = System.Drawing.Color.Wheat;
            this.textRaspuns.Enabled = false;
            this.textRaspuns.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRaspuns.ForeColor = System.Drawing.Color.Black;
            this.textRaspuns.Location = new System.Drawing.Point(12, 431);
            this.textRaspuns.Margin = new System.Windows.Forms.Padding(0);
            this.textRaspuns.Multiline = true;
            this.textRaspuns.Name = "textRaspuns";
            this.textRaspuns.Size = new System.Drawing.Size(618, 121);
            this.textRaspuns.TabIndex = 3;
            this.textRaspuns.Text = "Scrie aici raspunsul tau";
            this.textRaspuns.Visible = false;
            // 
            // verifica
            // 
            this.verifica.AutoSize = true;
            this.verifica.BackColor = System.Drawing.Color.AntiqueWhite;
            this.verifica.Enabled = false;
            this.verifica.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifica.ForeColor = System.Drawing.Color.Maroon;
            this.verifica.Location = new System.Drawing.Point(288, 558);
            this.verifica.Margin = new System.Windows.Forms.Padding(0);
            this.verifica.Name = "verifica";
            this.verifica.Size = new System.Drawing.Size(133, 46);
            this.verifica.TabIndex = 4;
            this.verifica.Text = "Verifica";
            this.verifica.UseVisualStyleBackColor = false;
            this.verifica.Visible = false;
            this.verifica.Click += new System.EventHandler(this.button1_Click);
            // 
            // maiDeparte
            // 
            this.maiDeparte.AutoSize = true;
            this.maiDeparte.BackColor = System.Drawing.Color.AntiqueWhite;
            this.maiDeparte.Enabled = false;
            this.maiDeparte.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maiDeparte.ForeColor = System.Drawing.Color.Maroon;
            this.maiDeparte.Location = new System.Drawing.Point(429, 558);
            this.maiDeparte.Margin = new System.Windows.Forms.Padding(0);
            this.maiDeparte.Name = "maiDeparte";
            this.maiDeparte.Size = new System.Drawing.Size(194, 46);
            this.maiDeparte.TabIndex = 5;
            this.maiDeparte.Text = "Mai departe";
            this.maiDeparte.UseVisualStyleBackColor = false;
            this.maiDeparte.Visible = false;
            this.maiDeparte.Click += new System.EventHandler(this.button2_Click);
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
            // stergeIntrebarea
            // 
            this.stergeIntrebarea.AutoSize = true;
            this.stergeIntrebarea.BackColor = System.Drawing.Color.AntiqueWhite;
            this.stergeIntrebarea.Enabled = false;
            this.stergeIntrebarea.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeIntrebarea.ForeColor = System.Drawing.Color.Maroon;
            this.stergeIntrebarea.Location = new System.Drawing.Point(12, 558);
            this.stergeIntrebarea.Margin = new System.Windows.Forms.Padding(0);
            this.stergeIntrebarea.Name = "stergeIntrebarea";
            this.stergeIntrebarea.Size = new System.Drawing.Size(262, 46);
            this.stergeIntrebarea.TabIndex = 8;
            this.stergeIntrebarea.Text = "Sterge intrebarea";
            this.stergeIntrebarea.UseVisualStyleBackColor = false;
            this.stergeIntrebarea.Visible = false;
            this.stergeIntrebarea.Click += new System.EventHandler(this.stergeIntrebarea_Click_1);
            // 
            // aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.stergeIntrebarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maiDeparte);
            this.Controls.Add(this.verifica);
            this.Controls.Add(this.textRaspuns);
            this.Controls.Add(this.textIntrebare);
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
        private System.Windows.Forms.ToolStripMenuItem incepeSaInveti;
        private System.Windows.Forms.ToolStripMenuItem adaugaUnFlashcard;
        private System.Windows.Forms.ToolStripMenuItem ajutor;
        private System.Windows.Forms.PictureBox figurina;
        private System.Windows.Forms.TextBox textIntrebare;
        private System.Windows.Forms.TextBox textRaspuns;
        private System.Windows.Forms.Button verifica;
        private System.Windows.Forms.Button maiDeparte;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intraInCont;
        private System.Windows.Forms.ToolStripMenuItem iesiDinCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stergeIntrebarea;
    }
}

