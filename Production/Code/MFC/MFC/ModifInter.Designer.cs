namespace MFC
{
    partial class ModifInterWind
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
            this.components = new System.ComponentModel.Container();
            this.LModifInterWind = new System.Windows.Forms.Label();
            this.CBModifInter_TMateriel = new System.Windows.Forms.ComboBox();
            this.dsetTmatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsetTmat = new MFC.DsetTmat();
            this.dsetInterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsetInter = new MFC.DsetInter();
            this.CBModifInter_Matériel = new System.Windows.Forms.ComboBox();
            this.dsetMatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsetMat = new MFC.DsetMat();
            this.CBModifInter_Site = new System.Windows.Forms.ComboBox();
            this.dsetSiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsetSite = new MFC.DsetSite();
            this.CBModifInter_Client = new System.Windows.Forms.ComboBox();
            this.dsetClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsetClient = new MFC.DsetClient();
            this.LModifInter_TMat = new System.Windows.Forms.Label();
            this.LModifInter_Mat = new System.Windows.Forms.Label();
            this.LModifInter_Site = new System.Windows.Forms.Label();
            this.LModifInter_Client = new System.Windows.Forms.Label();
            this.BModifInter_Annul = new System.Windows.Forms.Button();
            this.BModifInter_OK = new System.Windows.Forms.Button();
            this.DTPModifInter_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new MFC.DsetClientTableAdapters.ClientTableAdapter();
            this.siteTableAdapter = new MFC.DsetSiteTableAdapters.SiteTableAdapter();
            this.materielTableAdapter = new MFC.DsetMatTableAdapters.MaterielTableAdapter();
            this.type_MaterielTableAdapter = new MFC.DsetTmatTableAdapters.Type_MaterielTableAdapter();
            this.interventionTableAdapter = new MFC.DsetInterTableAdapters.InterventionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsetTmatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetTmat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetInterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetInter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetMatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetSiteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetClient)).BeginInit();
            this.SuspendLayout();
            // 
            // LModifInterWind
            // 
            this.LModifInterWind.AutoSize = true;
            this.LModifInterWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModifInterWind.Location = new System.Drawing.Point(16, 28);
            this.LModifInterWind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModifInterWind.Name = "LModifInterWind";
            this.LModifInterWind.Size = new System.Drawing.Size(263, 25);
            this.LModifInterWind.TabIndex = 2;
            this.LModifInterWind.Text = "Informations sur l\'intervention";
            // 
            // CBModifInter_TMateriel
            // 
            this.CBModifInter_TMateriel.DataSource = this.dsetTmatBindingSource;
            this.CBModifInter_TMateriel.DisplayMember = "Nom";
            this.CBModifInter_TMateriel.FormattingEnabled = true;
            this.CBModifInter_TMateriel.Location = new System.Drawing.Point(27, 244);
            this.CBModifInter_TMateriel.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifInter_TMateriel.Name = "CBModifInter_TMateriel";
            this.CBModifInter_TMateriel.Size = new System.Drawing.Size(273, 24);
            this.CBModifInter_TMateriel.TabIndex = 29;
            // 
            // dsetTmatBindingSource
            // 
            this.dsetTmatBindingSource.DataMember = "Type_Materiel";
            this.dsetTmatBindingSource.DataSource = this.dsetTmat;
            // 
            // dsetTmat
            // 
            this.dsetTmat.DataSetName = "DsetTmat";
            this.dsetTmat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsetInterBindingSource
            // 
            this.dsetInterBindingSource.DataMember = "Intervention";
            this.dsetInterBindingSource.DataSource = this.dsetInter;
            // 
            // dsetInter
            // 
            this.dsetInter.DataSetName = "DsetInter";
            this.dsetInter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBModifInter_Matériel
            // 
            this.CBModifInter_Matériel.DataSource = this.dsetMatBindingSource;
            this.CBModifInter_Matériel.DisplayMember = "Nom";
            this.CBModifInter_Matériel.FormattingEnabled = true;
            this.CBModifInter_Matériel.Location = new System.Drawing.Point(27, 185);
            this.CBModifInter_Matériel.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifInter_Matériel.Name = "CBModifInter_Matériel";
            this.CBModifInter_Matériel.Size = new System.Drawing.Size(273, 24);
            this.CBModifInter_Matériel.TabIndex = 28;
            // 
            // dsetMatBindingSource
            // 
            this.dsetMatBindingSource.DataMember = "Materiel";
            this.dsetMatBindingSource.DataSource = this.dsetMat;
            // 
            // dsetMat
            // 
            this.dsetMat.DataSetName = "DsetMat";
            this.dsetMat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBModifInter_Site
            // 
            this.CBModifInter_Site.DataSource = this.dsetSiteBindingSource;
            this.CBModifInter_Site.DisplayMember = "Nom";
            this.CBModifInter_Site.FormattingEnabled = true;
            this.CBModifInter_Site.Location = new System.Drawing.Point(27, 132);
            this.CBModifInter_Site.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifInter_Site.Name = "CBModifInter_Site";
            this.CBModifInter_Site.Size = new System.Drawing.Size(273, 24);
            this.CBModifInter_Site.TabIndex = 27;
            // 
            // dsetSiteBindingSource
            // 
            this.dsetSiteBindingSource.DataMember = "Site";
            this.dsetSiteBindingSource.DataSource = this.dsetSite;
            // 
            // dsetSite
            // 
            this.dsetSite.DataSetName = "DsetSite";
            this.dsetSite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBModifInter_Client
            // 
            this.CBModifInter_Client.DataSource = this.dsetClientBindingSource;
            this.CBModifInter_Client.DisplayMember = "Client";
            this.CBModifInter_Client.FormattingEnabled = true;
            this.CBModifInter_Client.Location = new System.Drawing.Point(27, 82);
            this.CBModifInter_Client.Margin = new System.Windows.Forms.Padding(4);
            this.CBModifInter_Client.Name = "CBModifInter_Client";
            this.CBModifInter_Client.Size = new System.Drawing.Size(273, 24);
            this.CBModifInter_Client.TabIndex = 26;
            // 
            // dsetClientBindingSource
            // 
            this.dsetClientBindingSource.DataMember = "Client";
            this.dsetClientBindingSource.DataSource = this.dsetClient;
            // 
            // dsetClient
            // 
            this.dsetClient.DataSetName = "DsetClient";
            this.dsetClient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LModifInter_TMat
            // 
            this.LModifInter_TMat.AutoSize = true;
            this.LModifInter_TMat.Location = new System.Drawing.Point(23, 224);
            this.LModifInter_TMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModifInter_TMat.Name = "LModifInter_TMat";
            this.LModifInter_TMat.Size = new System.Drawing.Size(94, 17);
            this.LModifInter_TMat.TabIndex = 25;
            this.LModifInter_TMat.Text = "Type Matériel";
            // 
            // LModifInter_Mat
            // 
            this.LModifInter_Mat.AutoSize = true;
            this.LModifInter_Mat.Location = new System.Drawing.Point(23, 165);
            this.LModifInter_Mat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModifInter_Mat.Name = "LModifInter_Mat";
            this.LModifInter_Mat.Size = new System.Drawing.Size(58, 17);
            this.LModifInter_Mat.TabIndex = 24;
            this.LModifInter_Mat.Text = "Matériel";
            // 
            // LModifInter_Site
            // 
            this.LModifInter_Site.AutoSize = true;
            this.LModifInter_Site.Location = new System.Drawing.Point(23, 112);
            this.LModifInter_Site.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModifInter_Site.Name = "LModifInter_Site";
            this.LModifInter_Site.Size = new System.Drawing.Size(32, 17);
            this.LModifInter_Site.TabIndex = 23;
            this.LModifInter_Site.Text = "Site";
            // 
            // LModifInter_Client
            // 
            this.LModifInter_Client.AutoSize = true;
            this.LModifInter_Client.Location = new System.Drawing.Point(23, 59);
            this.LModifInter_Client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LModifInter_Client.Name = "LModifInter_Client";
            this.LModifInter_Client.Size = new System.Drawing.Size(43, 17);
            this.LModifInter_Client.TabIndex = 22;
            this.LModifInter_Client.Text = "Client";
            // 
            // BModifInter_Annul
            // 
            this.BModifInter_Annul.Location = new System.Drawing.Point(292, 377);
            this.BModifInter_Annul.Margin = new System.Windows.Forms.Padding(4);
            this.BModifInter_Annul.Name = "BModifInter_Annul";
            this.BModifInter_Annul.Size = new System.Drawing.Size(145, 50);
            this.BModifInter_Annul.TabIndex = 21;
            this.BModifInter_Annul.Text = "Annuler";
            this.BModifInter_Annul.UseVisualStyleBackColor = true;
            this.BModifInter_Annul.Click += new System.EventHandler(this.BModifInter_Annul_Click_1);
            // 
            // BModifInter_OK
            // 
            this.BModifInter_OK.Location = new System.Drawing.Point(188, 377);
            this.BModifInter_OK.Margin = new System.Windows.Forms.Padding(4);
            this.BModifInter_OK.Name = "BModifInter_OK";
            this.BModifInter_OK.Size = new System.Drawing.Size(96, 50);
            this.BModifInter_OK.TabIndex = 20;
            this.BModifInter_OK.Text = "OK";
            this.BModifInter_OK.UseVisualStyleBackColor = true;
            this.BModifInter_OK.Click += new System.EventHandler(this.BModifInter_OK_Click);
            // 
            // DTPModifInter_Date
            // 
            this.DTPModifInter_Date.CustomFormat = "dd/MM/yyyy";
            this.DTPModifInter_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPModifInter_Date.Location = new System.Drawing.Point(25, 319);
            this.DTPModifInter_Date.Margin = new System.Windows.Forms.Padding(4);
            this.DTPModifInter_Date.Name = "DTPModifInter_Date";
            this.DTPModifInter_Date.Size = new System.Drawing.Size(265, 22);
            this.DTPModifInter_Date.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 290);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Veuillez entrer une date d\'intervention:";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // materielTableAdapter
            // 
            this.materielTableAdapter.ClearBeforeFill = true;
            // 
            // type_MaterielTableAdapter
            // 
            this.type_MaterielTableAdapter.ClearBeforeFill = true;
            // 
            // interventionTableAdapter
            // 
            this.interventionTableAdapter.ClearBeforeFill = true;
            // 
            // ModifInterWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 442);
            this.Controls.Add(this.CBModifInter_TMateriel);
            this.Controls.Add(this.CBModifInter_Matériel);
            this.Controls.Add(this.CBModifInter_Site);
            this.Controls.Add(this.CBModifInter_Client);
            this.Controls.Add(this.LModifInter_TMat);
            this.Controls.Add(this.LModifInter_Mat);
            this.Controls.Add(this.LModifInter_Site);
            this.Controls.Add(this.LModifInter_Client);
            this.Controls.Add(this.BModifInter_Annul);
            this.Controls.Add(this.BModifInter_OK);
            this.Controls.Add(this.DTPModifInter_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LModifInterWind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifInterWind";
            this.Text = "Modifier une intervention";
            this.Load += new System.EventHandler(this.ModifInterWind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsetTmatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetTmat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetInterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetInter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetMatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetSiteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsetClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LModifInterWind;
        public System.Windows.Forms.ComboBox CBModifInter_TMateriel;
        public System.Windows.Forms.ComboBox CBModifInter_Matériel;
        public System.Windows.Forms.ComboBox CBModifInter_Site;
        public System.Windows.Forms.ComboBox CBModifInter_Client;
        private System.Windows.Forms.Label LModifInter_TMat;
        private System.Windows.Forms.Label LModifInter_Mat;
        private System.Windows.Forms.Label LModifInter_Site;
        private System.Windows.Forms.Label LModifInter_Client;
        private System.Windows.Forms.Button BModifInter_Annul;
        private System.Windows.Forms.Button BModifInter_OK;
        private System.Windows.Forms.DateTimePicker DTPModifInter_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dsetClientBindingSource;
        private DsetClient dsetClient;
        private DsetClientTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource dsetSiteBindingSource;
        private DsetSite dsetSite;
        private DsetSiteTableAdapters.SiteTableAdapter siteTableAdapter;
        private System.Windows.Forms.BindingSource dsetMatBindingSource;
        private DsetMat dsetMat;
        private DsetMatTableAdapters.MaterielTableAdapter materielTableAdapter;
        private System.Windows.Forms.BindingSource dsetTmatBindingSource;
        private DsetTmat dsetTmat;
        private DsetTmatTableAdapters.Type_MaterielTableAdapter type_MaterielTableAdapter;
        private System.Windows.Forms.BindingSource dsetInterBindingSource;
        private DsetInter dsetInter;
        private DsetInterTableAdapters.InterventionTableAdapter interventionTableAdapter;
    }
}