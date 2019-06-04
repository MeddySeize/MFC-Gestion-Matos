namespace MFC
{
    partial class ModifMatWind
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
            this.BModifMat_Annul = new System.Windows.Forms.Button();
            this.BModifMat_OK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.RTBModifMat_Desc = new System.Windows.Forms.RichTextBox();
            this.CBModifMat_Site = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPModifMateriel_Date = new System.Windows.Forms.DateTimePicker();
            this.CBModifMat_Client = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBModifMat__MTBF = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBModifMat_TMateriel = new System.Windows.Forms.ComboBox();
            this.TBModifMat_NumSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBModifMat_Materiel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BModifMat_Annul
            // 
            this.BModifMat_Annul.Location = new System.Drawing.Point(415, 525);
            this.BModifMat_Annul.Margin = new System.Windows.Forms.Padding(4);
            this.BModifMat_Annul.Name = "BModifMat_Annul";
            this.BModifMat_Annul.Size = new System.Drawing.Size(152, 58);
            this.BModifMat_Annul.TabIndex = 37;
            this.BModifMat_Annul.Text = "Annuler";
            this.BModifMat_Annul.UseVisualStyleBackColor = true;
            this.BModifMat_Annul.Click += new System.EventHandler(this.BModifMat_Annul_Click);
            // 
            // BModifMat_OK
            // 
            this.BModifMat_OK.Location = new System.Drawing.Point(237, 525);
            this.BModifMat_OK.Margin = new System.Windows.Forms.Padding(4);
            this.BModifMat_OK.Name = "BModifMat_OK";
            this.BModifMat_OK.Size = new System.Drawing.Size(152, 58);
            this.BModifMat_OK.TabIndex = 36;
            this.BModifMat_OK.Text = "OK";
            this.BModifMat_OK.UseVisualStyleBackColor = true;
            this.BModifMat_OK.Click += new System.EventHandler(this.BModifMat_OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 328);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Description:";
            // 
            // RTBModifMat_Desc
            // 
            this.RTBModifMat_Desc.Location = new System.Drawing.Point(23, 356);
            this.RTBModifMat_Desc.Margin = new System.Windows.Forms.Padding(4);
            this.RTBModifMat_Desc.Name = "RTBModifMat_Desc";
            this.RTBModifMat_Desc.Size = new System.Drawing.Size(543, 160);
            this.RTBModifMat_Desc.TabIndex = 34;
            this.RTBModifMat_Desc.Text = "";
            // 
            // CBModifMat_Site
            // 
            this.CBModifMat_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModifMat_Site.FormattingEnabled = true;
            this.CBModifMat_Site.Location = new System.Drawing.Point(295, 199);
            this.CBModifMat_Site.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifMat_Site.Name = "CBModifMat_Site";
            this.CBModifMat_Site.Size = new System.Drawing.Size(271, 32);
            this.CBModifMat_Site.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Site";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Date d\'installation";
            // 
            // DTPModifMateriel_Date
            // 
            this.DTPModifMateriel_Date.CustomFormat = "dd/MM/yyyy";
            this.DTPModifMateriel_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPModifMateriel_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPModifMateriel_Date.Location = new System.Drawing.Point(23, 276);
            this.DTPModifMateriel_Date.Margin = new System.Windows.Forms.Padding(4);
            this.DTPModifMateriel_Date.Name = "DTPModifMateriel_Date";
            this.DTPModifMateriel_Date.Size = new System.Drawing.Size(313, 29);
            this.DTPModifMateriel_Date.TabIndex = 30;
            // 
            // CBModifMat_Client
            // 
            this.CBModifMat_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModifMat_Client.FormattingEnabled = true;
            this.CBModifMat_Client.Location = new System.Drawing.Point(23, 199);
            this.CBModifMat_Client.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifMat_Client.Name = "CBModifMat_Client";
            this.CBModifMat_Client.Size = new System.Drawing.Size(248, 32);
            this.CBModifMat_Client.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Client";
            // 
            // CBModifMat__MTBF
            // 
            this.CBModifMat__MTBF.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.CBModifMat__MTBF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBModifMat__MTBF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBModifMat__MTBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModifMat__MTBF.FormattingEnabled = true;
            this.CBModifMat__MTBF.Location = new System.Drawing.Point(295, 125);
            this.CBModifMat__MTBF.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifMat__MTBF.Name = "CBModifMat__MTBF";
            this.CBModifMat__MTBF.Size = new System.Drawing.Size(271, 28);
            this.CBModifMat__MTBF.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "MTBF";
            // 
            // CBModifMat_TMateriel
            // 
            this.CBModifMat_TMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBModifMat_TMateriel.FormattingEnabled = true;
            this.CBModifMat_TMateriel.Location = new System.Drawing.Point(295, 51);
            this.CBModifMat_TMateriel.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifMat_TMateriel.Name = "CBModifMat_TMateriel";
            this.CBModifMat_TMateriel.Size = new System.Drawing.Size(271, 28);
            this.CBModifMat_TMateriel.TabIndex = 25;
            // 
            // TBModifMat_NumSerie
            // 
            this.TBModifMat_NumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModifMat_NumSerie.Location = new System.Drawing.Point(23, 125);
            this.TBModifMat_NumSerie.Margin = new System.Windows.Forms.Padding(4);
            this.TBModifMat_NumSerie.Name = "TBModifMat_NumSerie";
            this.TBModifMat_NumSerie.Size = new System.Drawing.Size(248, 29);
            this.TBModifMat_NumSerie.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type de Matériel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numéro de série:";
            // 
            // TBModifMat_Materiel
            // 
            this.TBModifMat_Materiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModifMat_Materiel.Location = new System.Drawing.Point(23, 51);
            this.TBModifMat_Materiel.Margin = new System.Windows.Forms.Padding(4);
            this.TBModifMat_Materiel.Name = "TBModifMat_Materiel";
            this.TBModifMat_Materiel.Size = new System.Drawing.Size(248, 29);
            this.TBModifMat_Materiel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nom du Matériel:";
            // 
            // ModifMatWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 606);
            this.Controls.Add(this.BModifMat_Annul);
            this.Controls.Add(this.BModifMat_OK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RTBModifMat_Desc);
            this.Controls.Add(this.CBModifMat_Site);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPModifMateriel_Date);
            this.Controls.Add(this.CBModifMat_Client);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBModifMat__MTBF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBModifMat_TMateriel);
            this.Controls.Add(this.TBModifMat_NumSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBModifMat_Materiel);
            this.Controls.Add(this.label1);
            this.Name = "ModifMatWind";
            this.Text = "Modifier un Matériel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BModifMat_Annul;
        private System.Windows.Forms.Button BModifMat_OK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox RTBModifMat_Desc;
        private System.Windows.Forms.ComboBox CBModifMat_Site;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPModifMateriel_Date;
        private System.Windows.Forms.ComboBox CBModifMat_Client;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBModifMat__MTBF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBModifMat_TMateriel;
        private System.Windows.Forms.TextBox TBModifMat_NumSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBModifMat_Materiel;
        private System.Windows.Forms.Label label1;
    }
}