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
            this.buttonModMat = new System.Windows.Forms.Button();
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
            this.ParamètrePage = new System.Windows.Forms.TabPage();
            this.buttonDecon = new System.Windows.Forms.Button();
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
            this.ParamètrePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNav
            // 
            this.tabNav.Controls.Add(this.AccueilPage);
            this.tabNav.Controls.Add(this.InterPage);
            this.tabNav.Controls.Add(this.materielPage);
            this.tabNav.Controls.Add(this.TabClientSites);
            this.tabNav.Controls.Add(this.ParamètrePage);
            this.tabNav.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNav.Location = new System.Drawing.Point(-3, 1);
            this.tabNav.Margin = new System.Windows.Forms.Padding(2);
            this.tabNav.Name = "tabNav";
            this.tabNav.SelectedIndex = 0;
            this.tabNav.Size = new System.Drawing.Size(768, 438);
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
            this.AccueilPage.Location = new System.Drawing.Point(4, 34);
            this.AccueilPage.Margin = new System.Windows.Forms.Padding(2);
            this.AccueilPage.Name = "AccueilPage";
            this.AccueilPage.Padding = new System.Windows.Forms.Padding(2);
            this.AccueilPage.Size = new System.Drawing.Size(760, 400);
            this.AccueilPage.TabIndex = 0;
            this.AccueilPage.Text = "Accueil";
            // 
            // LInterEnCours
            // 
            this.LInterEnCours.AutoSize = true;
            this.LInterEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInterEnCours.Location = new System.Drawing.Point(4, 213);
            this.LInterEnCours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LInterEnCours.Name = "LInterEnCours";
            this.LInterEnCours.Size = new System.Drawing.Size(330, 37);
            this.LInterEnCours.TabIndex = 9;
            this.LInterEnCours.Text = "Interventions en cours";
            // 
            // LAlertesMtbf
            // 
            this.LAlertesMtbf.AutoSize = true;
            this.LAlertesMtbf.Cursor = System.Windows.Forms.Cursors.Default;
            this.LAlertesMtbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAlertesMtbf.Location = new System.Drawing.Point(10, 30);
            this.LAlertesMtbf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LAlertesMtbf.Name = "LAlertesMtbf";
            this.LAlertesMtbf.Size = new System.Drawing.Size(212, 37);
            this.LAlertesMtbf.TabIndex = 8;
            this.LAlertesMtbf.Text = "Alertes MTBF";
            // 
            // buttonDelInter
            // 
            this.buttonDelInter.BackColor = System.Drawing.Color.White;
            this.buttonDelInter.Location = new System.Drawing.Point(624, 329);
            this.buttonDelInter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelInter.Name = "buttonDelInter";
            this.buttonDelInter.Size = new System.Drawing.Size(124, 57);
            this.buttonDelInter.TabIndex = 7;
            this.buttonDelInter.Text = "Supprimer";
            this.buttonDelInter.UseVisualStyleBackColor = false;
            // 
            // BFinishInter1
            // 
            this.BFinishInter1.BackColor = System.Drawing.Color.White;
            this.BFinishInter1.Location = new System.Drawing.Point(624, 265);
            this.BFinishInter1.Margin = new System.Windows.Forms.Padding(2);
            this.BFinishInter1.Name = "BFinishInter1";
            this.BFinishInter1.Size = new System.Drawing.Size(124, 57);
            this.BFinishInter1.TabIndex = 6;
            this.BFinishInter1.Text = "Terminer";
            this.BFinishInter1.UseVisualStyleBackColor = false;
            // 
            // buttonDelMtbf
            // 
            this.buttonDelMtbf.BackColor = System.Drawing.Color.White;
            this.buttonDelMtbf.Location = new System.Drawing.Point(622, 133);
            this.buttonDelMtbf.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelMtbf.Name = "buttonDelMtbf";
            this.buttonDelMtbf.Size = new System.Drawing.Size(124, 57);
            this.buttonDelMtbf.TabIndex = 5;
            this.buttonDelMtbf.Text = "Supprimer";
            this.buttonDelMtbf.UseVisualStyleBackColor = false;
            // 
            // buttonAddInter1
            // 
            this.buttonAddInter1.BackColor = System.Drawing.Color.White;
            this.buttonAddInter1.Location = new System.Drawing.Point(622, 72);
            this.buttonAddInter1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddInter1.Name = "buttonAddInter1";
            this.buttonAddInter1.Size = new System.Drawing.Size(124, 57);
            this.buttonAddInter1.TabIndex = 4;
            this.buttonAddInter1.Text = "Ajouter";
            this.buttonAddInter1.UseVisualStyleBackColor = false;
            this.buttonAddInter1.Click += new System.EventHandler(this.buttonAddInter1_Click);
            // 
            // GridInterCours
            // 
            this.GridInterCours.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridInterCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridInterCours.Location = new System.Drawing.Point(10, 252);
            this.GridInterCours.Margin = new System.Windows.Forms.Padding(2);
            this.GridInterCours.Name = "GridInterCours";
            this.GridInterCours.RowTemplate.Height = 24;
            this.GridInterCours.Size = new System.Drawing.Size(608, 134);
            this.GridInterCours.TabIndex = 3;
            // 
            // GridMTBF
            // 
            this.GridMTBF.AllowUserToAddRows = false;
            this.GridMTBF.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridMTBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMTBF.Location = new System.Drawing.Point(10, 69);
            this.GridMTBF.Margin = new System.Windows.Forms.Padding(2);
            this.GridMTBF.Name = "GridMTBF";
            this.GridMTBF.RowHeadersVisible = false;
            this.GridMTBF.RowTemplate.Height = 24;
            this.GridMTBF.Size = new System.Drawing.Size(608, 121);
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
            this.InterPage.Location = new System.Drawing.Point(4, 34);
            this.InterPage.Margin = new System.Windows.Forms.Padding(2);
            this.InterPage.Name = "InterPage";
            this.InterPage.Padding = new System.Windows.Forms.Padding(2);
            this.InterPage.Size = new System.Drawing.Size(760, 400);
            this.InterPage.TabIndex = 1;
            this.InterPage.Text = "Intervention";
            // 
            // bModifyInter
            // 
            this.bModifyInter.BackColor = System.Drawing.Color.White;
            this.bModifyInter.Location = new System.Drawing.Point(589, 215);
            this.bModifyInter.Margin = new System.Windows.Forms.Padding(2);
            this.bModifyInter.Name = "bModifyInter";
            this.bModifyInter.Size = new System.Drawing.Size(159, 66);
            this.bModifyInter.TabIndex = 9;
            this.bModifyInter.Text = "Modifier";
            this.bModifyInter.UseVisualStyleBackColor = false;
            // 
            // bFinishInter2
            // 
            this.bFinishInter2.BackColor = System.Drawing.Color.White;
            this.bFinishInter2.Location = new System.Drawing.Point(589, 145);
            this.bFinishInter2.Margin = new System.Windows.Forms.Padding(2);
            this.bFinishInter2.Name = "bFinishInter2";
            this.bFinishInter2.Size = new System.Drawing.Size(160, 66);
            this.bFinishInter2.TabIndex = 8;
            this.bFinishInter2.Text = "Terminer";
            this.bFinishInter2.UseVisualStyleBackColor = false;
            // 
            // bAddInter2
            // 
            this.bAddInter2.BackColor = System.Drawing.Color.White;
            this.bAddInter2.Location = new System.Drawing.Point(589, 5);
            this.bAddInter2.Margin = new System.Windows.Forms.Padding(2);
            this.bAddInter2.Name = "bAddInter2";
            this.bAddInter2.Size = new System.Drawing.Size(159, 66);
            this.bAddInter2.TabIndex = 7;
            this.bAddInter2.Text = "Ajouter";
            this.bAddInter2.UseVisualStyleBackColor = false;
            this.bAddInter2.Click += new System.EventHandler(this.bAddInter2_Click);
            // 
            // bDelInter2
            // 
            this.bDelInter2.BackColor = System.Drawing.Color.White;
            this.bDelInter2.Location = new System.Drawing.Point(589, 75);
            this.bDelInter2.Margin = new System.Windows.Forms.Padding(2);
            this.bDelInter2.Name = "bDelInter2";
            this.bDelInter2.Size = new System.Drawing.Size(159, 66);
            this.bDelInter2.TabIndex = 6;
            this.bDelInter2.Text = "Supprimer";
            this.bDelInter2.UseVisualStyleBackColor = false;
            // 
            // DGInter
            // 
            this.DGInter.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGInter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGInter.Location = new System.Drawing.Point(6, 5);
            this.DGInter.Margin = new System.Windows.Forms.Padding(2);
            this.DGInter.Name = "DGInter";
            this.DGInter.RowTemplate.Height = 24;
            this.DGInter.Size = new System.Drawing.Size(579, 390);
            this.DGInter.TabIndex = 0;
            // 
            // materielPage
            // 
            this.materielPage.BackColor = System.Drawing.Color.Gainsboro;
            this.materielPage.Controls.Add(this.buttonModMat);
            this.materielPage.Controls.Add(this.button2);
            this.materielPage.Controls.Add(this.buttonAddMat);
            this.materielPage.Controls.Add(this.DGMat);
            this.materielPage.Location = new System.Drawing.Point(4, 34);
            this.materielPage.Margin = new System.Windows.Forms.Padding(2);
            this.materielPage.Name = "materielPage";
            this.materielPage.Padding = new System.Windows.Forms.Padding(2);
            this.materielPage.Size = new System.Drawing.Size(760, 400);
            this.materielPage.TabIndex = 2;
            this.materielPage.Text = "Matériel";
            // 
            // buttonModMat
            // 
            this.buttonModMat.BackColor = System.Drawing.Color.White;
            this.buttonModMat.Location = new System.Drawing.Point(588, 144);
            this.buttonModMat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModMat.Name = "buttonModMat";
            this.buttonModMat.Size = new System.Drawing.Size(160, 66);
            this.buttonModMat.TabIndex = 11;
            this.buttonModMat.Text = "Modifier";
            this.buttonModMat.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(588, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 66);
            this.button2.TabIndex = 9;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonAddMat
            // 
            this.buttonAddMat.BackColor = System.Drawing.Color.White;
            this.buttonAddMat.Location = new System.Drawing.Point(588, 4);
            this.buttonAddMat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMat.Name = "buttonAddMat";
            this.buttonAddMat.Size = new System.Drawing.Size(160, 66);
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
            this.DGMat.Location = new System.Drawing.Point(4, 5);
            this.DGMat.Margin = new System.Windows.Forms.Padding(2);
            this.DGMat.Name = "DGMat";
            this.DGMat.RowTemplate.Height = 24;
            this.DGMat.Size = new System.Drawing.Size(580, 390);
            this.DGMat.TabIndex = 1;
            // 
            // TabClientSites
            // 
            this.TabClientSites.BackColor = System.Drawing.Color.Gainsboro;
            this.TabClientSites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.TabClientSites.Location = new System.Drawing.Point(4, 34);
            this.TabClientSites.Margin = new System.Windows.Forms.Padding(2);
            this.TabClientSites.Name = "TabClientSites";
            this.TabClientSites.Padding = new System.Windows.Forms.Padding(2);
            this.TabClientSites.Size = new System.Drawing.Size(760, 400);
            this.TabClientSites.TabIndex = 3;
            this.TabClientSites.Text = "Client et Sites";
            // 
            // BModifSites
            // 
            this.BModifSites.BackColor = System.Drawing.Color.White;
            this.BModifSites.Location = new System.Drawing.Point(6, 344);
            this.BModifSites.Margin = new System.Windows.Forms.Padding(2);
            this.BModifSites.Name = "BModifSites";
            this.BModifSites.Size = new System.Drawing.Size(44, 45);
            this.BModifSites.TabIndex = 9;
            this.BModifSites.Text = "...";
            this.BModifSites.UseVisualStyleBackColor = false;
            // 
            // BSupprSites
            // 
            this.BSupprSites.BackColor = System.Drawing.Color.White;
            this.BSupprSites.Location = new System.Drawing.Point(6, 294);
            this.BSupprSites.Margin = new System.Windows.Forms.Padding(2);
            this.BSupprSites.Name = "BSupprSites";
            this.BSupprSites.Size = new System.Drawing.Size(44, 45);
            this.BSupprSites.TabIndex = 8;
            this.BSupprSites.Text = "-";
            this.BSupprSites.UseVisualStyleBackColor = false;
            // 
            // BAjoutSites
            // 
            this.BAjoutSites.BackColor = System.Drawing.Color.White;
            this.BAjoutSites.Location = new System.Drawing.Point(6, 245);
            this.BAjoutSites.Margin = new System.Windows.Forms.Padding(2);
            this.BAjoutSites.Name = "BAjoutSites";
            this.BAjoutSites.Size = new System.Drawing.Size(44, 45);
            this.BAjoutSites.TabIndex = 7;
            this.BAjoutSites.Text = "+";
            this.BAjoutSites.UseVisualStyleBackColor = false;
            this.BAjoutSites.Click += new System.EventHandler(this.BAjoutSites_Click);
            // 
            // BModifClient
            // 
            this.BModifClient.BackColor = System.Drawing.Color.White;
            this.BModifClient.Location = new System.Drawing.Point(6, 144);
            this.BModifClient.Margin = new System.Windows.Forms.Padding(2);
            this.BModifClient.Name = "BModifClient";
            this.BModifClient.Size = new System.Drawing.Size(44, 45);
            this.BModifClient.TabIndex = 6;
            this.BModifClient.Text = "...";
            this.BModifClient.UseVisualStyleBackColor = false;
            // 
            // BSupprClient
            // 
            this.BSupprClient.BackColor = System.Drawing.Color.White;
            this.BSupprClient.Location = new System.Drawing.Point(6, 94);
            this.BSupprClient.Margin = new System.Windows.Forms.Padding(2);
            this.BSupprClient.Name = "BSupprClient";
            this.BSupprClient.Size = new System.Drawing.Size(44, 45);
            this.BSupprClient.TabIndex = 5;
            this.BSupprClient.Text = "-";
            this.BSupprClient.UseVisualStyleBackColor = false;
            // 
            // BAjoutClient
            // 
            this.BAjoutClient.BackColor = System.Drawing.Color.White;
            this.BAjoutClient.Location = new System.Drawing.Point(6, 45);
            this.BAjoutClient.Margin = new System.Windows.Forms.Padding(2);
            this.BAjoutClient.Name = "BAjoutClient";
            this.BAjoutClient.Size = new System.Drawing.Size(44, 45);
            this.BAjoutClient.TabIndex = 4;
            this.BAjoutClient.Text = "+";
            this.BAjoutClient.UseVisualStyleBackColor = false;
            this.BAjoutClient.Click += new System.EventHandler(this.BAjoutClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sites";
            // 
            // Lclient
            // 
            this.Lclient.AutoSize = true;
            this.Lclient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lclient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lclient.Location = new System.Drawing.Point(50, 9);
            this.Lclient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lclient.Name = "Lclient";
            this.Lclient.Size = new System.Drawing.Size(77, 32);
            this.Lclient.TabIndex = 2;
            this.Lclient.Text = "Client";
            // 
            // DGSites
            // 
            this.DGSites.AllowUserToAddRows = false;
            this.DGSites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSites.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSites.Location = new System.Drawing.Point(55, 245);
            this.DGSites.Margin = new System.Windows.Forms.Padding(2);
            this.DGSites.Name = "DGSites";
            this.DGSites.Size = new System.Drawing.Size(694, 144);
            this.DGSites.TabIndex = 1;
            // 
            // DGClient
            // 
            this.DGClient.AllowUserToAddRows = false;
            this.DGClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGClient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClient.Location = new System.Drawing.Point(55, 45);
            this.DGClient.Margin = new System.Windows.Forms.Padding(2);
            this.DGClient.Name = "DGClient";
            this.DGClient.Size = new System.Drawing.Size(694, 144);
            this.DGClient.TabIndex = 0;
            // 
            // ParamètrePage
            // 
            this.ParamètrePage.Controls.Add(this.buttonDecon);
            this.ParamètrePage.Location = new System.Drawing.Point(4, 34);
            this.ParamètrePage.Name = "ParamètrePage";
            this.ParamètrePage.Padding = new System.Windows.Forms.Padding(3);
            this.ParamètrePage.Size = new System.Drawing.Size(760, 400);
            this.ParamètrePage.TabIndex = 4;
            this.ParamètrePage.Text = "Paramètre";
            this.ParamètrePage.UseVisualStyleBackColor = true;
            // 
            // buttonDecon
            // 
            this.buttonDecon.Location = new System.Drawing.Point(11, 18);
            this.buttonDecon.Name = "buttonDecon";
            this.buttonDecon.Size = new System.Drawing.Size(145, 48);
            this.buttonDecon.TabIndex = 0;
            this.buttonDecon.Text = "Déconnexion";
            this.buttonDecon.UseVisualStyleBackColor = true;
            this.buttonDecon.Click += new System.EventHandler(this.buttonDecon_Click);
            // 
            // MFCWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 436);
            this.Controls.Add(this.tabNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MFCWind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.ParamètrePage.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonModMat;
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
        private System.Windows.Forms.TabPage ParamètrePage;
        private System.Windows.Forms.Button buttonDecon;
    }
}

