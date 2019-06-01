namespace MFC
{
    partial class AddInterWind
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
            this.LAddInterWind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPAddInter = new System.Windows.Forms.DateTimePicker();
            this.BAddInter_OK = new System.Windows.Forms.Button();
            this.BAddInter_Annul = new System.Windows.Forms.Button();
            this.LAddInter_Client = new System.Windows.Forms.Label();
            this.LAddInter_Site = new System.Windows.Forms.Label();
            this.LAddInter_Mat = new System.Windows.Forms.Label();
            this.LAddInter_TMat = new System.Windows.Forms.Label();
            this.CBAddInter_Client = new System.Windows.Forms.ComboBox();
            this.CBAddInter_Site = new System.Windows.Forms.ComboBox();
            this.CBAddInter_Matériel = new System.Windows.Forms.ComboBox();
            this.CBAddInter_TMateriel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LAddInterWind
            // 
            this.LAddInterWind.AutoSize = true;
            this.LAddInterWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddInterWind.Location = new System.Drawing.Point(11, 9);
            this.LAddInterWind.Name = "LAddInterWind";
            this.LAddInterWind.Size = new System.Drawing.Size(216, 20);
            this.LAddInterWind.TabIndex = 1;
            this.LAddInterWind.Text = "Informations sur l\'intervention";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Veuillez entrer une date d\'intervention:";
            // 
            // DTPAddInter
            // 
            this.DTPAddInter.CustomFormat = "dd/MM/yyyy";
            this.DTPAddInter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPAddInter.Location = new System.Drawing.Point(20, 259);
            this.DTPAddInter.Name = "DTPAddInter";
            this.DTPAddInter.Size = new System.Drawing.Size(200, 20);
            this.DTPAddInter.TabIndex = 7;
            // 
            // BAddInter_OK
            // 
            this.BAddInter_OK.Location = new System.Drawing.Point(142, 306);
            this.BAddInter_OK.Name = "BAddInter_OK";
            this.BAddInter_OK.Size = new System.Drawing.Size(72, 41);
            this.BAddInter_OK.TabIndex = 8;
            this.BAddInter_OK.Text = "OK";
            this.BAddInter_OK.UseVisualStyleBackColor = true;
            this.BAddInter_OK.Click += new System.EventHandler(this.BAddInter_OK_Click);
            // 
            // BAddInter_Annul
            // 
            this.BAddInter_Annul.Location = new System.Drawing.Point(220, 306);
            this.BAddInter_Annul.Name = "BAddInter_Annul";
            this.BAddInter_Annul.Size = new System.Drawing.Size(109, 41);
            this.BAddInter_Annul.TabIndex = 9;
            this.BAddInter_Annul.Text = "Annuler";
            this.BAddInter_Annul.UseVisualStyleBackColor = true;
            this.BAddInter_Annul.Click += new System.EventHandler(this.BAddInter_Annul_Click);
            // 
            // LAddInter_Client
            // 
            this.LAddInter_Client.AutoSize = true;
            this.LAddInter_Client.Location = new System.Drawing.Point(18, 48);
            this.LAddInter_Client.Name = "LAddInter_Client";
            this.LAddInter_Client.Size = new System.Drawing.Size(33, 13);
            this.LAddInter_Client.TabIndex = 10;
            this.LAddInter_Client.Text = "Client";
            // 
            // LAddInter_Site
            // 
            this.LAddInter_Site.AutoSize = true;
            this.LAddInter_Site.Location = new System.Drawing.Point(18, 91);
            this.LAddInter_Site.Name = "LAddInter_Site";
            this.LAddInter_Site.Size = new System.Drawing.Size(25, 13);
            this.LAddInter_Site.TabIndex = 11;
            this.LAddInter_Site.Text = "Site";
            // 
            // LAddInter_Mat
            // 
            this.LAddInter_Mat.AutoSize = true;
            this.LAddInter_Mat.Location = new System.Drawing.Point(18, 134);
            this.LAddInter_Mat.Name = "LAddInter_Mat";
            this.LAddInter_Mat.Size = new System.Drawing.Size(44, 13);
            this.LAddInter_Mat.TabIndex = 12;
            this.LAddInter_Mat.Text = "Matériel";
            // 
            // LAddInter_TMat
            // 
            this.LAddInter_TMat.AutoSize = true;
            this.LAddInter_TMat.Location = new System.Drawing.Point(18, 182);
            this.LAddInter_TMat.Name = "LAddInter_TMat";
            this.LAddInter_TMat.Size = new System.Drawing.Size(71, 13);
            this.LAddInter_TMat.TabIndex = 13;
            this.LAddInter_TMat.Text = "Type Matériel";
            // 
            // CBAddInter_Client
            // 
            this.CBAddInter_Client.FormattingEnabled = true;
            this.CBAddInter_Client.Location = new System.Drawing.Point(21, 67);
            this.CBAddInter_Client.Name = "CBAddInter_Client";
            this.CBAddInter_Client.Size = new System.Drawing.Size(206, 21);
            this.CBAddInter_Client.TabIndex = 14;
            // 
            // CBAddInter_Site
            // 
            this.CBAddInter_Site.FormattingEnabled = true;
            this.CBAddInter_Site.Location = new System.Drawing.Point(21, 107);
            this.CBAddInter_Site.Name = "CBAddInter_Site";
            this.CBAddInter_Site.Size = new System.Drawing.Size(206, 21);
            this.CBAddInter_Site.TabIndex = 15;
            // 
            // CBAddInter_Matériel
            // 
            this.CBAddInter_Matériel.FormattingEnabled = true;
            this.CBAddInter_Matériel.Location = new System.Drawing.Point(21, 150);
            this.CBAddInter_Matériel.Name = "CBAddInter_Matériel";
            this.CBAddInter_Matériel.Size = new System.Drawing.Size(206, 21);
            this.CBAddInter_Matériel.TabIndex = 16;
            // 
            // CBAddInter_TMateriel
            // 
            this.CBAddInter_TMateriel.FormattingEnabled = true;
            this.CBAddInter_TMateriel.Location = new System.Drawing.Point(21, 198);
            this.CBAddInter_TMateriel.Name = "CBAddInter_TMateriel";
            this.CBAddInter_TMateriel.Size = new System.Drawing.Size(206, 21);
            this.CBAddInter_TMateriel.TabIndex = 17;
            // 
            // AddInterWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 359);
            this.Controls.Add(this.CBAddInter_TMateriel);
            this.Controls.Add(this.CBAddInter_Matériel);
            this.Controls.Add(this.CBAddInter_Site);
            this.Controls.Add(this.CBAddInter_Client);
            this.Controls.Add(this.LAddInter_TMat);
            this.Controls.Add(this.LAddInter_Mat);
            this.Controls.Add(this.LAddInter_Site);
            this.Controls.Add(this.LAddInter_Client);
            this.Controls.Add(this.BAddInter_Annul);
            this.Controls.Add(this.BAddInter_OK);
            this.Controls.Add(this.DTPAddInter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LAddInterWind);
            this.Name = "AddInterWind";
            this.Text = "Créer une Intervention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LAddInterWind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPAddInter;
        private System.Windows.Forms.Button BAddInter_OK;
        private System.Windows.Forms.Button BAddInter_Annul;
        private System.Windows.Forms.Label LAddInter_Client;
        private System.Windows.Forms.Label LAddInter_Site;
        private System.Windows.Forms.Label LAddInter_Mat;
        private System.Windows.Forms.Label LAddInter_TMat;
        private System.Windows.Forms.ComboBox CBAddInter_Client;
        private System.Windows.Forms.ComboBox CBAddInter_Site;
        private System.Windows.Forms.ComboBox CBAddInter_Matériel;
        private System.Windows.Forms.ComboBox CBAddInter_TMateriel;
    }
}