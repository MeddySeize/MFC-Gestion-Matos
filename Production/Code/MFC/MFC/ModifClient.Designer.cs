namespace MFC
{
    partial class ModifClientWind
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
            this.BModifClient_Annuler = new System.Windows.Forms.Button();
            this.BModifClient_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LAddClient_Cli = new System.Windows.Forms.Label();
            this.TBModifClient_Tel = new System.Windows.Forms.TextBox();
            this.TBModifClient_Email = new System.Windows.Forms.TextBox();
            this.TBModifClient_Cli = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BModifClient_Annuler
            // 
            this.BModifClient_Annuler.Location = new System.Drawing.Point(272, 215);
            this.BModifClient_Annuler.Margin = new System.Windows.Forms.Padding(4);
            this.BModifClient_Annuler.Name = "BModifClient_Annuler";
            this.BModifClient_Annuler.Size = new System.Drawing.Size(119, 42);
            this.BModifClient_Annuler.TabIndex = 15;
            this.BModifClient_Annuler.Text = "Annuler";
            this.BModifClient_Annuler.UseVisualStyleBackColor = true;
            // 
            // BModifClient_OK
            // 
            this.BModifClient_OK.Location = new System.Drawing.Point(145, 215);
            this.BModifClient_OK.Margin = new System.Windows.Forms.Padding(4);
            this.BModifClient_OK.Name = "BModifClient_OK";
            this.BModifClient_OK.Size = new System.Drawing.Size(119, 42);
            this.BModifClient_OK.TabIndex = 14;
            this.BModifClient_OK.Text = "OK";
            this.BModifClient_OK.UseVisualStyleBackColor = true;
            this.BModifClient_OK.Click += new System.EventHandler(this.BModifClient_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Téléphone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            // 
            // LAddClient_Cli
            // 
            this.LAddClient_Cli.AutoSize = true;
            this.LAddClient_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddClient_Cli.Location = new System.Drawing.Point(17, 21);
            this.LAddClient_Cli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAddClient_Cli.Name = "LAddClient_Cli";
            this.LAddClient_Cli.Size = new System.Drawing.Size(57, 20);
            this.LAddClient_Cli.TabIndex = 11;
            this.LAddClient_Cli.Text = "Client:";
            // 
            // TBModifClient_Tel
            // 
            this.TBModifClient_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModifClient_Tel.Location = new System.Drawing.Point(21, 171);
            this.TBModifClient_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.TBModifClient_Tel.Name = "TBModifClient_Tel";
            this.TBModifClient_Tel.Size = new System.Drawing.Size(365, 29);
            this.TBModifClient_Tel.TabIndex = 10;
            this.TBModifClient_Tel.Text = " ";
            // 
            // TBModifClient_Email
            // 
            this.TBModifClient_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModifClient_Email.Location = new System.Drawing.Point(21, 111);
            this.TBModifClient_Email.Margin = new System.Windows.Forms.Padding(4);
            this.TBModifClient_Email.Name = "TBModifClient_Email";
            this.TBModifClient_Email.Size = new System.Drawing.Size(365, 29);
            this.TBModifClient_Email.TabIndex = 9;
            // 
            // TBModifClient_Cli
            // 
            this.TBModifClient_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBModifClient_Cli.Location = new System.Drawing.Point(21, 44);
            this.TBModifClient_Cli.Margin = new System.Windows.Forms.Padding(4);
            this.TBModifClient_Cli.Name = "TBModifClient_Cli";
            this.TBModifClient_Cli.Size = new System.Drawing.Size(365, 29);
            this.TBModifClient_Cli.TabIndex = 8;
            // 
            // ModifClientWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 270);
            this.Controls.Add(this.BModifClient_Annuler);
            this.Controls.Add(this.BModifClient_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LAddClient_Cli);
            this.Controls.Add(this.TBModifClient_Tel);
            this.Controls.Add(this.TBModifClient_Email);
            this.Controls.Add(this.TBModifClient_Cli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifClientWind";
            this.Text = "Modifier un Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BModifClient_Annuler;
        private System.Windows.Forms.Button BModifClient_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LAddClient_Cli;
        private System.Windows.Forms.TextBox TBModifClient_Tel;
        private System.Windows.Forms.TextBox TBModifClient_Email;
        private System.Windows.Forms.TextBox TBModifClient_Cli;
    }
}