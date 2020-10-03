namespace DataBankVoorBoeken
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
            this.gbxGegevens = new System.Windows.Forms.GroupBox();
            this.labGenre = new System.Windows.Forms.Label();
            this.labAuteur = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.labUigever = new System.Windows.Forms.Label();
            this.labPublicatie = new System.Windows.Forms.Label();
            this.lablPagina = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labId = new System.Windows.Forms.Label();
            this.lstBoeken = new System.Windows.Forms.ListBox();
            this.gbxGegevens.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGegevens
            // 
            this.gbxGegevens.Controls.Add(this.labGenre);
            this.gbxGegevens.Controls.Add(this.labAuteur);
            this.gbxGegevens.Controls.Add(this.labScore);
            this.gbxGegevens.Controls.Add(this.labUigever);
            this.gbxGegevens.Controls.Add(this.labPublicatie);
            this.gbxGegevens.Controls.Add(this.lablPagina);
            this.gbxGegevens.Controls.Add(this.btnToevoegen);
            this.gbxGegevens.Controls.Add(this.label4);
            this.gbxGegevens.Controls.Add(this.label2);
            this.gbxGegevens.Controls.Add(this.label1);
            this.gbxGegevens.Controls.Add(this.labId);
            this.gbxGegevens.Location = new System.Drawing.Point(387, 80);
            this.gbxGegevens.Name = "gbxGegevens";
            this.gbxGegevens.Size = new System.Drawing.Size(244, 290);
            this.gbxGegevens.TabIndex = 9;
            this.gbxGegevens.TabStop = false;
            this.gbxGegevens.Text = "Boek";
            // 
            // labGenre
            // 
            this.labGenre.AutoSize = true;
            this.labGenre.Location = new System.Drawing.Point(100, 193);
            this.labGenre.Name = "labGenre";
            this.labGenre.Size = new System.Drawing.Size(36, 13);
            this.labGenre.TabIndex = 12;
            this.labGenre.Text = "Genre";
            // 
            // labAuteur
            // 
            this.labAuteur.AutoSize = true;
            this.labAuteur.Location = new System.Drawing.Point(100, 160);
            this.labAuteur.Name = "labAuteur";
            this.labAuteur.Size = new System.Drawing.Size(38, 13);
            this.labAuteur.TabIndex = 11;
            this.labAuteur.Text = "Auteur";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(100, 108);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(13, 13);
            this.labScore.TabIndex = 10;
            this.labScore.Text = "5";
            // 
            // labUigever
            // 
            this.labUigever.AutoSize = true;
            this.labUigever.Location = new System.Drawing.Point(100, 134);
            this.labUigever.Name = "labUigever";
            this.labUigever.Size = new System.Drawing.Size(29, 13);
            this.labUigever.TabIndex = 9;
            this.labUigever.Text = "publi";
            // 
            // labPublicatie
            // 
            this.labPublicatie.AutoSize = true;
            this.labPublicatie.Location = new System.Drawing.Point(98, 83);
            this.labPublicatie.Name = "labPublicatie";
            this.labPublicatie.Size = new System.Drawing.Size(31, 13);
            this.labPublicatie.TabIndex = 7;
            this.labPublicatie.Text = "2000";
            // 
            // lablPagina
            // 
            this.lablPagina.AutoSize = true;
            this.lablPagina.Location = new System.Drawing.Point(100, 57);
            this.lablPagina.Name = "lablPagina";
            this.lablPagina.Size = new System.Drawing.Size(45, 13);
            this.lablPagina.TabIndex = 6;
            this.lablPagina.Text = "Paginas";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(0, 231);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(232, 27);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Auteur(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:\r\n\r\nPaginas:\r\n\r\nPublicatie:\r\n\r\nScore:\r\n\r\nUitgever:";
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(100, 30);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(15, 13);
            this.labId.TabIndex = 0;
            this.labId.Text = "id";
            // 
            // lstBoeken
            // 
            this.lstBoeken.FormattingEnabled = true;
            this.lstBoeken.Location = new System.Drawing.Point(169, 80);
            this.lstBoeken.Name = "lstBoeken";
            this.lstBoeken.Size = new System.Drawing.Size(138, 290);
            this.lstBoeken.TabIndex = 8;
            this.lstBoeken.SelectedIndexChanged += new System.EventHandler(this.lstBoeken_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxGegevens);
            this.Controls.Add(this.lstBoeken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbxGegevens.ResumeLayout(false);
            this.gbxGegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGegevens;
        private System.Windows.Forms.Label labGenre;
        private System.Windows.Forms.Label labAuteur;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labUigever;
        private System.Windows.Forms.Label labPublicatie;
        private System.Windows.Forms.Label lablPagina;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.ListBox lstBoeken;
    }
}

