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
            this.TBAddInter_Client = new System.Windows.Forms.TextBox();
            this.TBAddInter_Site = new System.Windows.Forms.TextBox();
            this.TBAddInter_Mat = new System.Windows.Forms.TextBox();
            this.TBAddInter_TMat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPAddInter = new System.Windows.Forms.DateTimePicker();
            this.BAddInter_OK = new System.Windows.Forms.Button();
            this.BAddInter_Annul = new System.Windows.Forms.Button();
            this.LAddInter_Client = new System.Windows.Forms.Label();
            this.LAddInter_Site = new System.Windows.Forms.Label();
            this.LAddInter_Mat = new System.Windows.Forms.Label();
            this.LAddInter_TMat = new System.Windows.Forms.Label();
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
            // TBAddInter_Client
            // 
            this.TBAddInter_Client.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.TBAddInter_Client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TBAddInter_Client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBAddInter_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddInter_Client.Location = new System.Drawing.Point(20, 64);
            this.TBAddInter_Client.Name = "TBAddInter_Client";
            this.TBAddInter_Client.Size = new System.Drawing.Size(207, 24);
            this.TBAddInter_Client.TabIndex = 2;
            // 
            // TBAddInter_Site
            // 
            this.TBAddInter_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddInter_Site.Location = new System.Drawing.Point(20, 107);
            this.TBAddInter_Site.Name = "TBAddInter_Site";
            this.TBAddInter_Site.Size = new System.Drawing.Size(207, 24);
            this.TBAddInter_Site.TabIndex = 3;
            // 
            // TBAddInter_Mat
            // 
            this.TBAddInter_Mat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddInter_Mat.Location = new System.Drawing.Point(20, 149);
            this.TBAddInter_Mat.Name = "TBAddInter_Mat";
            this.TBAddInter_Mat.Size = new System.Drawing.Size(207, 24);
            this.TBAddInter_Mat.TabIndex = 4;
            // 
            // TBAddInter_TMat
            // 
            this.TBAddInter_TMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddInter_TMat.Location = new System.Drawing.Point(20, 198);
            this.TBAddInter_TMat.Name = "TBAddInter_TMat";
            this.TBAddInter_TMat.Size = new System.Drawing.Size(207, 24);
            this.TBAddInter_TMat.TabIndex = 5;
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
            // AddInterWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 359);
            this.Controls.Add(this.LAddInter_TMat);
            this.Controls.Add(this.LAddInter_Mat);
            this.Controls.Add(this.LAddInter_Site);
            this.Controls.Add(this.LAddInter_Client);
            this.Controls.Add(this.BAddInter_Annul);
            this.Controls.Add(this.BAddInter_OK);
            this.Controls.Add(this.DTPAddInter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBAddInter_TMat);
            this.Controls.Add(this.TBAddInter_Mat);
            this.Controls.Add(this.TBAddInter_Site);
            this.Controls.Add(this.TBAddInter_Client);
            this.Controls.Add(this.LAddInterWind);
            this.Name = "AddInterWind";
            this.Text = "Créer une Intervention";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LAddInterWind;
        private System.Windows.Forms.TextBox TBAddInter_Client;
        private System.Windows.Forms.TextBox TBAddInter_Site;
        private System.Windows.Forms.TextBox TBAddInter_Mat;
        private System.Windows.Forms.TextBox TBAddInter_TMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPAddInter;
        private System.Windows.Forms.Button BAddInter_OK;
        private System.Windows.Forms.Button BAddInter_Annul;
        private System.Windows.Forms.Label LAddInter_Client;
        private System.Windows.Forms.Label LAddInter_Site;
        private System.Windows.Forms.Label LAddInter_Mat;
        private System.Windows.Forms.Label LAddInter_TMat;
    }
}