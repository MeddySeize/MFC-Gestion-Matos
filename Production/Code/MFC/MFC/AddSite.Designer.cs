namespace MFC
{
    partial class AddSiteWind
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
            this.LAddSite_Nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAddSite_Nom = new System.Windows.Forms.TextBox();
            this.TBAddSite_Adr = new System.Windows.Forms.TextBox();
            this.TBAddSite_CP = new System.Windows.Forms.TextBox();
            this.TBAddSite_Ville = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAddSite_Nom
            // 
            this.LAddSite_Nom.AutoSize = true;
            this.LAddSite_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddSite_Nom.Location = new System.Drawing.Point(22, 13);
            this.LAddSite_Nom.Name = "LAddSite_Nom";
            this.LAddSite_Nom.Size = new System.Drawing.Size(41, 18);
            this.LAddSite_Nom.TabIndex = 0;
            this.LAddSite_Nom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville";
            // 
            // TBAddSite_Nom
            // 
            this.TBAddSite_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddSite_Nom.Location = new System.Drawing.Point(21, 34);
            this.TBAddSite_Nom.Name = "TBAddSite_Nom";
            this.TBAddSite_Nom.Size = new System.Drawing.Size(317, 26);
            this.TBAddSite_Nom.TabIndex = 4;
            // 
            // TBAddSite_Adr
            // 
            this.TBAddSite_Adr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddSite_Adr.Location = new System.Drawing.Point(21, 94);
            this.TBAddSite_Adr.Name = "TBAddSite_Adr";
            this.TBAddSite_Adr.Size = new System.Drawing.Size(317, 26);
            this.TBAddSite_Adr.TabIndex = 5;
            // 
            // TBAddSite_CP
            // 
            this.TBAddSite_CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddSite_CP.Location = new System.Drawing.Point(21, 159);
            this.TBAddSite_CP.Name = "TBAddSite_CP";
            this.TBAddSite_CP.Size = new System.Drawing.Size(317, 26);
            this.TBAddSite_CP.TabIndex = 6;
            // 
            // TBAddSite_Ville
            // 
            this.TBAddSite_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddSite_Ville.Location = new System.Drawing.Point(21, 225);
            this.TBAddSite_Ville.Name = "TBAddSite_Ville";
            this.TBAddSite_Ville.Size = new System.Drawing.Size(317, 26);
            this.TBAddSite_Ville.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddSiteWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBAddSite_Ville);
            this.Controls.Add(this.TBAddSite_CP);
            this.Controls.Add(this.TBAddSite_Adr);
            this.Controls.Add(this.TBAddSite_Nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LAddSite_Nom);
            this.Name = "AddSiteWind";
            this.Text = "Ajouter un Site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAddSite_Nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAddSite_Nom;
        private System.Windows.Forms.TextBox TBAddSite_Adr;
        private System.Windows.Forms.TextBox TBAddSite_CP;
        private System.Windows.Forms.TextBox TBAddSite_Ville;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}