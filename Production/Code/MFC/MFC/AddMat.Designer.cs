namespace MFC
{
    partial class AddMatWind
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBAddMat_Materiel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBAddMat_NumSerie = new System.Windows.Forms.TextBox();
            this.CBAddMat_TMateriel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBAddMat_MTBF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBAddMat_Client = new System.Windows.Forms.ComboBox();
            this.DTPAddMateriel = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CBAddMat_Site = new System.Windows.Forms.ComboBox();
            this.RTBAddMateriel_Desc = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Matériel:";
            // 
            // TBAddMat_Materiel
            // 
            this.TBAddMat_Materiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddMat_Materiel.Location = new System.Drawing.Point(17, 48);
            this.TBAddMat_Materiel.Name = "TBAddMat_Materiel";
            this.TBAddMat_Materiel.Size = new System.Drawing.Size(187, 24);
            this.TBAddMat_Materiel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro de série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type de Matériel:";
            // 
            // TBAddMat_NumSerie
            // 
            this.TBAddMat_NumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddMat_NumSerie.Location = new System.Drawing.Point(17, 108);
            this.TBAddMat_NumSerie.Name = "TBAddMat_NumSerie";
            this.TBAddMat_NumSerie.Size = new System.Drawing.Size(187, 24);
            this.TBAddMat_NumSerie.TabIndex = 5;
            // 
            // CBAddMat_TMateriel
            // 
            this.CBAddMat_TMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAddMat_TMateriel.FormattingEnabled = true;
            this.CBAddMat_TMateriel.Location = new System.Drawing.Point(221, 48);
            this.CBAddMat_TMateriel.Name = "CBAddMat_TMateriel";
            this.CBAddMat_TMateriel.Size = new System.Drawing.Size(204, 24);
            this.CBAddMat_TMateriel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "MTBF";
            // 
            // CBAddMat_MTBF
            // 
            this.CBAddMat_MTBF.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.CBAddMat_MTBF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBAddMat_MTBF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CBAddMat_MTBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAddMat_MTBF.FormattingEnabled = true;
            this.CBAddMat_MTBF.Location = new System.Drawing.Point(221, 108);
            this.CBAddMat_MTBF.Name = "CBAddMat_MTBF";
            this.CBAddMat_MTBF.Size = new System.Drawing.Size(204, 24);
            this.CBAddMat_MTBF.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client";
            // 
            // CBAddMat_Client
            // 
            this.CBAddMat_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAddMat_Client.FormattingEnabled = true;
            this.CBAddMat_Client.Location = new System.Drawing.Point(17, 168);
            this.CBAddMat_Client.Name = "CBAddMat_Client";
            this.CBAddMat_Client.Size = new System.Drawing.Size(187, 26);
            this.CBAddMat_Client.TabIndex = 11;
            // 
            // DTPAddMateriel
            // 
            this.DTPAddMateriel.CustomFormat = "dd/MM/yyyy";
            this.DTPAddMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPAddMateriel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPAddMateriel.Location = new System.Drawing.Point(17, 231);
            this.DTPAddMateriel.Name = "DTPAddMateriel";
            this.DTPAddMateriel.Size = new System.Drawing.Size(236, 24);
            this.DTPAddMateriel.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date d\'installation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Site";
            // 
            // CBAddMat_Site
            // 
            this.CBAddMat_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBAddMat_Site.FormattingEnabled = true;
            this.CBAddMat_Site.Location = new System.Drawing.Point(221, 168);
            this.CBAddMat_Site.Name = "CBAddMat_Site";
            this.CBAddMat_Site.Size = new System.Drawing.Size(204, 26);
            this.CBAddMat_Site.TabIndex = 15;
            // 
            // RTBAddMateriel_Desc
            // 
            this.RTBAddMateriel_Desc.Location = new System.Drawing.Point(17, 296);
            this.RTBAddMateriel_Desc.Name = "RTBAddMateriel_Desc";
            this.RTBAddMateriel_Desc.Size = new System.Drawing.Size(408, 131);
            this.RTBAddMateriel_Desc.TabIndex = 16;
            this.RTBAddMateriel_Desc.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddMatWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RTBAddMateriel_Desc);
            this.Controls.Add(this.CBAddMat_Site);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPAddMateriel);
            this.Controls.Add(this.CBAddMat_Client);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBAddMat_MTBF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBAddMat_TMateriel);
            this.Controls.Add(this.TBAddMat_NumSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBAddMat_Materiel);
            this.Controls.Add(this.label1);
            this.Name = "AddMatWind";
            this.Text = "Ajouter un Matériel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAddMat_Materiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBAddMat_NumSerie;
        private System.Windows.Forms.ComboBox CBAddMat_TMateriel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBAddMat_MTBF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBAddMat_Client;
        private System.Windows.Forms.DateTimePicker DTPAddMateriel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBAddMat_Site;
        private System.Windows.Forms.RichTextBox RTBAddMateriel_Desc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}