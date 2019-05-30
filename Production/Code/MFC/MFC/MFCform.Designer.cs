namespace MFC
{
    partial class MFCWind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFCWind));
            this.tabNav = new System.Windows.Forms.TabControl();
            this.AccueilPage = new System.Windows.Forms.TabPage();
            this.LInterEnCours = new System.Windows.Forms.Label();
            this.LAlertesMtbf = new System.Windows.Forms.Label();
            this.buttonDelInter = new System.Windows.Forms.Button();
            this.BFinishInter1 = new System.Windows.Forms.Button();
            this.buttonDelMtbf = new System.Windows.Forms.Button();
            this.buttonAddInter1 = new System.Windows.Forms.Button();
            this.GridInterCours = new System.Windows.Forms.DataGridView();
            this.GridMTBF = new System.Windows.Forms.DataGridView();
            this.InterPage = new System.Windows.Forms.TabPage();
            this.bModifyInter = new System.Windows.Forms.Button();
            this.bFinishInter2 = new System.Windows.Forms.Button();
            this.bAddInter2 = new System.Windows.Forms.Button();
            this.bDelInter2 = new System.Windows.Forms.Button();
            this.DGInter = new System.Windows.Forms.DataGridView();
            this.materielPage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAddMat = new System.Windows.Forms.Button();
            this.DGMat = new System.Windows.Forms.DataGridView();
            this.TabClientSites = new System.Windows.Forms.TabPage();
            this.BModifSites = new System.Windows.Forms.Button();
            this.BSupprSites = new System.Windows.Forms.Button();
            this.BAjoutSites = new System.Windows.Forms.Button();
            this.BModifClient = new System.Windows.Forms.Button();
            this.BSupprClient = new System.Windows.Forms.Button();
            this.BAjoutClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lclient = new System.Windows.Forms.Label();
            this.DGSites = new System.Windows.Forms.DataGridView();
            this.DGClient = new System.Windows.Forms.DataGridView();
            this.tabNav.SuspendLayout();
            this.AccueilPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInterCours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMTBF)).BeginInit();
            this.InterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGInter)).BeginInit();
            this.materielPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGMat)).BeginInit();
            this.TabClientSites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClient)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNav
            // 
            this.tabNav.Controls.Add(this.AccueilPage);
            this.tabNav.Controls.Add(this.InterPage);
            this.tabNav.Controls.Add(this.materielPage);
            this.tabNav.Controls.Add(this.TabClientSites);
            this.tabNav.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNav.Location = new System.Drawing.Point(-4, 1);
            this.tabNav.Name = "tabNav";
            this.tabNav.SelectedIndex = 0;
            this.tabNav.Size = new System.Drawing.Size(1024, 539);
            this.tabNav.TabIndex = 0;
            // 
            // AccueilPage
            // 
            this.AccueilPage.BackColor = System.Drawing.Color.Gainsboro;
            this.AccueilPage.Controls.Add(this.LInterEnCours);
            this.AccueilPage.Controls.Add(this.LAlertesMtbf);
            this.AccueilPage.Controls.Add(this.buttonDelInter);
            this.AccueilPage.Controls.Add(this.BFinishInter1);
            this.AccueilPage.Controls.Add(this.buttonDelMtbf);
            this.AccueilPage.Controls.Add(this.buttonAddInter1);
            this.AccueilPage.Controls.Add(this.GridInterCours);
            this.AccueilPage.Controls.Add(this.GridMTBF);
            this.AccueilPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccueilPage.Location = new System.Drawing.Point(4, 40);
            this.AccueilPage.Name = "AccueilPage";
            this.AccueilPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccueilPage.Size = new System.Drawing.Size(1016, 495);
            this.AccueilPage.TabIndex = 0;
            this.AccueilPage.Text = "Accueil";
            // 
            // LInterEnCours
            // 
            this.LInterEnCours.AutoSize = true;
            this.LInterEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInterEnCours.Location = new System.Drawing.Point(28, 278);
            this.LInterEnCours.Name = "LInterEnCours";
            this.LInterEnCours.Size = new System.Drawing.Size(411, 46);
            this.LInterEnCours.TabIndex = 9;
            this.LInterEnCours.Text = "Interventions en cours";
            // 
            // LAlertesMtbf
            // 
            this.LAlertesMtbf.AutoSize = true;
            this.LAlertesMtbf.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAlertesMtbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlertesMtbf.Location = new System.Drawing.Point(28, 37);
            this.LAlertesMtbf.Name = "LAlertesMtbf";
            this.LAlertesMtbf.Size = new System.Drawing.Size(263, 46);
            this.LAlertesMtbf.TabIndex = 8;
            this.LAlertesMtbf.Text = "Alertes MTBF";
            // 
            // buttonDelInter
            // 
            this.buttonDelInter.BackColor = System.Drawing.Color.White;
            this.buttonDelInter.Location = new System.Drawing.Point(843, 406);
            this.buttonDelInter.Name = "buttonDelInter";
            this.buttonDelInter.Size = new System.Drawing.Size(159, 70);
            this.buttonDelInter.TabIndex = 7;
            this.buttonDelInter.Text = "Supprimer";
            this.buttonDelInter.UseVisualStyleBackColor = false;
            // 
            // BFinishInter1
            // 
            this.BFinishInter1.BackColor = System.Drawing.Color.White;
            this.BFinishInter1.Location = new System.Drawing.Point(843, 327);
            this.BFinishInter1.Name = "BFinishInter1";
            this.BFinishInter1.Size = new System.Drawing.Size(159, 70);
            this.BFinishInter1.TabIndex = 6;
            this.BFinishInter1.Text = "Terminer";
            this.BFinishInter1.UseVisualStyleBackColor = false;
            // 
            // buttonDelMtbf
            // 
            this.buttonDelMtbf.BackColor = System.Drawing.Color.White;
            this.buttonDelMtbf.Location = new System.Drawing.Point(843, 165);
            this.buttonDelMtbf.Name = "buttonDelMtbf";
            this.buttonDelMtbf.Size = new System.Drawing.Size(159, 70);
            this.buttonDelMtbf.TabIndex = 5;
            this.buttonDelMtbf.Text = "Supprimer";
            this.buttonDelMtbf.UseVisualStyleBackColor = false;
            // 
            // buttonAddInter1
            // 
            this.buttonAddInter1.BackColor = System.Drawing.Color.White;
            this.buttonAddInter1.Location = new System.Drawing.Point(843, 86);
            this.buttonAddInter1.Name = "buttonAddInter1";
            this.buttonAddInter1.Size = new System.Drawing.Size(159, 70);
            this.buttonAddInter1.TabIndex = 4;
            this.buttonAddInter1.Text = "Ajouter";
            this.buttonAddInter1.UseVisualStyleBackColor = false;
            // 
            // GridInterCours
            // 
            this.GridInterCours.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridInterCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInterCours.Location = new System.Drawing.Point(27, 327);
            this.GridInterCours.Name = "GridInterCours";
            this.GridInterCours.RowTemplate.Height = 24;
            this.GridInterCours.Size = new System.Drawing.Size(810, 149);
            this.GridInterCours.TabIndex = 3;
            // 
            // GridMTBF
            // 
            this.GridMTBF.AllowUserToAddRows = false;
            this.GridMTBF.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridMTBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMTBF.Location = new System.Drawing.Point(27, 86);
            this.GridMTBF.Name = "GridMTBF";
            this.GridMTBF.RowHeadersVisible = false;
            this.GridMTBF.RowTemplate.Height = 24;
            this.GridMTBF.Size = new System.Drawing.Size(810, 149);
            this.GridMTBF.TabIndex = 1;
            // 
            // InterPage
            // 
            this.InterPage.BackColor = System.Drawing.Color.Gainsboro;
            this.InterPage.Controls.Add(this.bModifyInter);
            this.InterPage.Controls.Add(this.bFinishInter2);
            this.InterPage.Controls.Add(this.bAddInter2);
            this.InterPage.Controls.Add(this.bDelInter2);
            this.InterPage.Controls.Add(this.DGInter);
            this.InterPage.Location = new System.Drawing.Point(4, 40);
            this.InterPage.Name = "InterPage";
            this.InterPage.Padding = new System.Windows.Forms.Padding(3);
            this.InterPage.Size = new System.Drawing.Size(1016, 495);
            this.InterPage.TabIndex = 1;
            this.InterPage.Text = "Intervention";
            // 
            // bModifyInter
            // 
            this.bModifyInter.BackColor = System.Drawing.Color.White;
            this.bModifyInter.Location = new System.Drawing.Point(906, 369);
            this.bModifyInter.Name = "bModifyInter";
            this.bModifyInter.Size = new System.Drawing.Size(92, 81);
            this.bModifyInter.TabIndex = 9;
            this.bModifyInter.Text = "...";
            this.bModifyInter.UseVisualStyleBackColor = false;
            // 
            // bFinishInter2
            // 
            this.bFinishInter2.BackColor = System.Drawing.Color.White;
            this.bFinishInter2.Location = new System.Drawing.Point(906, 267);
            this.bFinishInter2.Name = "bFinishInter2";
            this.bFinishInter2.Size = new System.Drawing.Size(92, 81);
            this.bFinishInter2.TabIndex = 8;
            this.bFinishInter2.Text = "F?";
            this.bFinishInter2.UseVisualStyleBackColor = false;
            // 
            // bAddInter2
            // 
            this.bAddInter2.BackColor = System.Drawing.Color.White;
            this.bAddInter2.Location = new System.Drawing.Point(906, 66);
            this.bAddInter2.Name = "bAddInter2";
            this.bAddInter2.Size = new System.Drawing.Size(92, 81);
            this.bAddInter2.TabIndex = 7;
            this.bAddInter2.Text = "Add";
            this.bAddInter2.UseVisualStyleBackColor = false;
            // 
            // bDelInter2
            // 
            this.bDelInter2.BackColor = System.Drawing.Color.White;
            this.bDelInter2.Location = new System.Drawing.Point(906, 166);
            this.bDelInter2.Name = "bDelInter2";
            this.bDelInter2.Size = new System.Drawing.Size(92, 81);
            this.bDelInter2.TabIndex = 6;
            this.bDelInter2.Text = "Del";
            this.bDelInter2.UseVisualStyleBackColor = false;
            // 
            // DGInter
            // 
            this.DGInter.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInter.Location = new System.Drawing.Point(8, 6);
            this.DGInter.Name = "DGInter";
            this.DGInter.RowHeadersVisible = false;
            this.DGInter.RowTemplate.Height = 24;
            this.DGInter.Size = new System.Drawing.Size(892, 480);
            this.DGInter.TabIndex = 0;
            // 
            // materielPage
            // 
            this.materielPage.BackColor = System.Drawing.Color.Gainsboro;
            this.materielPage.Controls.Add(this.button4);
            this.materielPage.Controls.Add(this.button3);
            this.materielPage.Controls.Add(this.button2);
            this.materielPage.Controls.Add(this.buttonAddMat);
            this.materielPage.Controls.Add(this.DGMat);
            this.materielPage.Location = new System.Drawing.Point(4, 40);
            this.materielPage.Name = "materielPage";
            this.materielPage.Padding = new System.Windows.Forms.Padding(3);
            this.materielPage.Size = new System.Drawing.Size(1016, 495);
            this.materielPage.TabIndex = 2;
            this.materielPage.Text = "Matériel";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(786, 325);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 81);
            this.button4.TabIndex = 11;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(786, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 81);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(786, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 81);
            this.button2.TabIndex = 9;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonAddMat
            // 
            this.buttonAddMat.BackColor = System.Drawing.Color.White;
            this.buttonAddMat.Location = new System.Drawing.Point(786, 15);
            this.buttonAddMat.Name = "buttonAddMat";
            this.buttonAddMat.Size = new System.Drawing.Size(187, 81);
            this.buttonAddMat.TabIndex = 8;
            this.buttonAddMat.Text = "Ajouter";
            this.buttonAddMat.UseVisualStyleBackColor = false;
            this.buttonAddMat.Click += new System.EventHandler(this.buttonAddMat_Click);
            // 
            // DGMat
            // 
            this.DGMat.AllowUserToAddRows = false;
            this.DGMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMat.Location = new System.Drawing.Point(6, 6);
            this.DGMat.Name = "DGMat";
            this.DGMat.RowHeadersVisible = false;
            this.DGMat.RowTemplate.Height = 24;
            this.DGMat.Size = new System.Drawing.Size(774, 480);
            this.DGMat.TabIndex = 1;
            // 
            // TabClientSites
            // 
            this.TabClientSites.BackColor = System.Drawing.Color.Gainsboro;
            this.TabClientSites.Controls.Add(this.BModifSites);
            this.TabClientSites.Controls.Add(this.BSupprSites);
            this.TabClientSites.Controls.Add(this.BAjoutSites);
            this.TabClientSites.Controls.Add(this.BModifClient);
            this.TabClientSites.Controls.Add(this.BSupprClient);
            this.TabClientSites.Controls.Add(this.BAjoutClient);
            this.TabClientSites.Controls.Add(this.label1);
            this.TabClientSites.Controls.Add(this.Lclient);
            this.TabClientSites.Controls.Add(this.DGSites);
            this.TabClientSites.Controls.Add(this.DGClient);
            this.TabClientSites.Location = new System.Drawing.Point(4, 40);
            this.TabClientSites.Name = "TabClientSites";
            this.TabClientSites.Padding = new System.Windows.Forms.Padding(3);
            this.TabClientSites.Size = new System.Drawing.Size(1016, 495);
            this.TabClientSites.TabIndex = 3;
            this.TabClientSites.Text = "Client et Sites";
            // 
            // BModifSites
            // 
            this.BModifSites.BackColor = System.Drawing.Color.White;
            this.BModifSites.Location = new System.Drawing.Point(8, 423);
            this.BModifSites.Name = "BModifSites";
            this.BModifSites.Size = new System.Drawing.Size(59, 55);
            this.BModifSites.TabIndex = 9;
            this.BModifSites.Text = "...";
            this.BModifSites.UseVisualStyleBackColor = false;
            // 
            // BSupprSites
            // 
            this.BSupprSites.BackColor = System.Drawing.Color.White;
            this.BSupprSites.Location = new System.Drawing.Point(8, 362);
            this.BSupprSites.Name = "BSupprSites";
            this.BSupprSites.Size = new System.Drawing.Size(59, 55);
            this.BSupprSites.TabIndex = 8;
            this.BSupprSites.Text = "-";
            this.BSupprSites.UseVisualStyleBackColor = false;
            // 
            // BAjoutSites
            // 
            this.BAjoutSites.BackColor = System.Drawing.Color.White;
            this.BAjoutSites.Location = new System.Drawing.Point(8, 301);
            this.BAjoutSites.Name = "BAjoutSites";
            this.BAjoutSites.Size = new System.Drawing.Size(59, 55);
            this.BAjoutSites.TabIndex = 7;
            this.BAjoutSites.Text = "+";
            this.BAjoutSites.UseVisualStyleBackColor = false;
            // 
            // BModifClient
            // 
            this.BModifClient.BackColor = System.Drawing.Color.White;
            this.BModifClient.Location = new System.Drawing.Point(8, 177);
            this.BModifClient.Name = "BModifClient";
            this.BModifClient.Size = new System.Drawing.Size(59, 55);
            this.BModifClient.TabIndex = 6;
            this.BModifClient.Text = "...";
            this.BModifClient.UseVisualStyleBackColor = false;
            // 
            // BSupprClient
            // 
            this.BSupprClient.BackColor = System.Drawing.Color.White;
            this.BSupprClient.Location = new System.Drawing.Point(8, 116);
            this.BSupprClient.Name = "BSupprClient";
            this.BSupprClient.Size = new System.Drawing.Size(59, 55);
            this.BSupprClient.TabIndex = 5;
            this.BSupprClient.Text = "-";
            this.BSupprClient.UseVisualStyleBackColor = false;
            // 
            // BAjoutClient
            // 
            this.BAjoutClient.BackColor = System.Drawing.Color.White;
            this.BAjoutClient.Location = new System.Drawing.Point(8, 55);
            this.BAjoutClient.Name = "BAjoutClient";
            this.BAjoutClient.Size = new System.Drawing.Size(59, 55);
            this.BAjoutClient.TabIndex = 4;
            this.BAjoutClient.Text = "+";
            this.BAjoutClient.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sites";
            // 
            // Lclient
            // 
            this.Lclient.AutoSize = true;
            this.Lclient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lclient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lclient.Location = new System.Drawing.Point(66, 11);
            this.Lclient.Name = "Lclient";
            this.Lclient.Size = new System.Drawing.Size(94, 41);
            this.Lclient.TabIndex = 2;
            this.Lclient.Text = "Client";
            // 
            // DGSites
            // 
            this.DGSites.AllowUserToAddRows = false;
            this.DGSites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSites.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSites.Location = new System.Drawing.Point(73, 301);
            this.DGSites.Name = "DGSites";
            this.DGSites.RowHeadersVisible = false;
            this.DGSites.Size = new System.Drawing.Size(925, 177);
            this.DGSites.TabIndex = 1;
            // 
            // DGClient
            // 
            this.DGClient.AllowUserToAddRows = false;
            this.DGClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGClient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClient.Location = new System.Drawing.Point(73, 55);
            this.DGClient.Name = "DGClient";
            this.DGClient.RowHeadersVisible = false;
            this.DGClient.Size = new System.Drawing.Size(925, 177);
            this.DGClient.TabIndex = 0;
            // 
            // MFCWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 536);
            this.Controls.Add(this.tabNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MFCWind";
            this.Text = "MFC";
            this.Load += new System.EventHandler(this.MFCWind_Load);
            this.tabNav.ResumeLayout(false);
            this.AccueilPage.ResumeLayout(false);
            this.AccueilPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridInterCours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMTBF)).EndInit();
            this.InterPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGInter)).EndInit();
            this.materielPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGMat)).EndInit();
            this.TabClientSites.ResumeLayout(false);
            this.TabClientSites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNav;
        private System.Windows.Forms.TabPage AccueilPage;
        private System.Windows.Forms.TabPage InterPage;
        private System.Windows.Forms.TabPage materielPage;
        private System.Windows.Forms.DataGridView GridMTBF;
        private System.Windows.Forms.Button buttonDelMtbf;
        private System.Windows.Forms.Button buttonAddInter1;
        private System.Windows.Forms.DataGridView GridInterCours;
        private System.Windows.Forms.Button buttonDelInter;
        private System.Windows.Forms.Button BFinishInter1;
        private System.Windows.Forms.Button bAddInter2;
        private System.Windows.Forms.Button bDelInter2;
        private System.Windows.Forms.DataGridView DGInter;
        private System.Windows.Forms.Button bModifyInter;
        private System.Windows.Forms.Button bFinishInter2;
        private System.Windows.Forms.DataGridView DGMat;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddMat;
        private System.Windows.Forms.TabPage TabClientSites;
        private System.Windows.Forms.DataGridView DGClient;
        private System.Windows.Forms.Label Lclient;
        private System.Windows.Forms.DataGridView DGSites;
        private System.Windows.Forms.Label LInterEnCours;
        private System.Windows.Forms.Label LAlertesMtbf;
        private System.Windows.Forms.Button BModifSites;
        private System.Windows.Forms.Button BSupprSites;
        private System.Windows.Forms.Button BAjoutSites;
        private System.Windows.Forms.Button BModifClient;
        private System.Windows.Forms.Button BSupprClient;
        private System.Windows.Forms.Button BAjoutClient;
        private System.Windows.Forms.Label label1;
    }
}

