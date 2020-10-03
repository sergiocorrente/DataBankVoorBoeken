namespace DataBankVoorBoeken
{
    partial class addAuteur
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFAchternaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvoornaam = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFAchternaam
            // 
            this.txtFAchternaam.Location = new System.Drawing.Point(109, 57);
            this.txtFAchternaam.Name = "txtFAchternaam";
            this.txtFAchternaam.Size = new System.Drawing.Size(224, 20);
            this.txtFAchternaam.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Achternaam:";
            // 
            // txtvoornaam
            // 
            this.txtvoornaam.Location = new System.Drawing.Point(109, 25);
            this.txtvoornaam.Name = "txtvoornaam";
            this.txtvoornaam.Size = new System.Drawing.Size(224, 20);
            this.txtvoornaam.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(58, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Voornaam:";
            // 
            // addAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 167);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFAchternaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvoornaam);
            this.Controls.Add(this.lbl1);
            this.Name = "addAuteur";
            this.Text = "addAuteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFAchternaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvoornaam;
        private System.Windows.Forms.Label lbl1;
    }
}