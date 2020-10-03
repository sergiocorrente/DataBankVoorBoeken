namespace DataBankVoorBoeken
{
    partial class addBook
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
            this.lvGenres = new System.Windows.Forms.ListView();
            this.lvAuthors = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // lvGenres
            // 
            this.lvGenres.CheckBoxes = true;
            this.lvGenres.HideSelection = false;
            this.lvGenres.Location = new System.Drawing.Point(135, 124);
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(193, 68);
            this.lvGenres.TabIndex = 31;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvAuthors
            // 
            this.lvAuthors.CheckBoxes = true;
            this.lvAuthors.FullRowSelect = true;
            this.lvAuthors.HideSelection = false;
            this.lvAuthors.Location = new System.Drawing.Point(135, 44);
            this.lvAuthors.Name = "lvAuthors";
            this.lvAuthors.ShowGroups = false;
            this.lvAuthors.Size = new System.Drawing.Size(193, 74);
            this.lvAuthors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAuthors.TabIndex = 30;
            this.lvAuthors.UseCompatibleStateImageBehavior = false;
            this.lvAuthors.View = System.Windows.Forms.View.SmallIcon;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Genre(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Auteur(s):";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(135, 317);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(194, 28);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "Voeg toe";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Aantal pagina\'s:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Publicatiejaar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Uitgever:";
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(135, 290);
            this.numScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(194, 20);
            this.numScore.TabIndex = 22;
            this.numScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numScore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(135, 260);
            this.numPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(194, 20);
            this.numPages.TabIndex = 21;
            this.numPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(135, 230);
            this.numYear.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(194, 20);
            this.numYear.TabIndex = 20;
            this.numYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(135, 198);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(193, 21);
            this.cbxPublisher.TabIndex = 19;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(135, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(193, 20);
            this.txtTitle.TabIndex = 18;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(66, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(30, 13);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Titel:";
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.lvGenres);
            this.Controls.Add(this.lvAuthors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.cbxPublisher);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbl1);
            this.Name = "addBook";
            this.Text = "addBook";
            this.Load += new System.EventHandler(this.addBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvGenres;
        private System.Windows.Forms.ListView lvAuthors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbl1;
    }
}