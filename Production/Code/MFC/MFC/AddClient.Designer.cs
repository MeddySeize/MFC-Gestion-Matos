namespace MFC
{
    partial class AddClientWind
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
            this.TBAddClient_Cli = new System.Windows.Forms.TextBox();
            this.TBAddClient_Email = new System.Windows.Forms.TextBox();
            this.TBAddClient_Tel = new System.Windows.Forms.TextBox();
            this.LAddClient_Cli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BAddClient_OK = new System.Windows.Forms.Button();
            this.BAddClient_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBAddClient_Cli
            // 
            this.TBAddClient_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddClient_Cli.Location = new System.Drawing.Point(16, 40);
            this.TBAddClient_Cli.Name = "TBAddClient_Cli";
            this.TBAddClient_Cli.Size = new System.Drawing.Size(275, 24);
            this.TBAddClient_Cli.TabIndex = 0;
            // 
            // TBAddClient_Email
            // 
            this.TBAddClient_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddClient_Email.Location = new System.Drawing.Point(16, 94);
            this.TBAddClient_Email.Name = "TBAddClient_Email";
            this.TBAddClient_Email.Size = new System.Drawing.Size(275, 24);
            this.TBAddClient_Email.TabIndex = 1;
            // 
            // TBAddClient_Tel
            // 
            this.TBAddClient_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddClient_Tel.Location = new System.Drawing.Point(16, 143);
            this.TBAddClient_Tel.Name = "TBAddClient_Tel";
            this.TBAddClient_Tel.Size = new System.Drawing.Size(275, 24);
            this.TBAddClient_Tel.TabIndex = 2;
            // 
            // LAddClient_Cli
            // 
            this.LAddClient_Cli.AutoSize = true;
            this.LAddClient_Cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAddClient_Cli.Location = new System.Drawing.Point(13, 21);
            this.LAddClient_Cli.Name = "LAddClient_Cli";
            this.LAddClient_Cli.Size = new System.Drawing.Size(44, 16);
            this.LAddClient_Cli.TabIndex = 3;
            this.LAddClient_Cli.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone:";
            // 
            // BAddClient_OK
            // 
            this.BAddClient_OK.Location = new System.Drawing.Point(107, 173);
            this.BAddClient_OK.Name = "BAddClient_OK";
            this.BAddClient_OK.Size = new System.Drawing.Size(89, 34);
            this.BAddClient_OK.TabIndex = 6;
            this.BAddClient_OK.Text = "OK";
            this.BAddClient_OK.UseVisualStyleBackColor = true;
            this.BAddClient_OK.Click += new System.EventHandler(this.BAddClient_OK_Click);
            // 
            // BAddClient_Annuler
            // 
            this.BAddClient_Annuler.Location = new System.Drawing.Point(202, 173);
            this.BAddClient_Annuler.Name = "BAddClient_Annuler";
            this.BAddClient_Annuler.Size = new System.Drawing.Size(89, 34);
            this.BAddClient_Annuler.TabIndex = 7;
            this.BAddClient_Annuler.Text = "Annuler";
            this.BAddClient_Annuler.UseVisualStyleBackColor = true;
            this.BAddClient_Annuler.Click += new System.EventHandler(this.BAddClient_Annuler_Click);
            // 
            // AddClientWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 219);
            this.Controls.Add(this.BAddClient_Annuler);
            this.Controls.Add(this.BAddClient_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LAddClient_Cli);
            this.Controls.Add(this.TBAddClient_Tel);
            this.Controls.Add(this.TBAddClient_Email);
            this.Controls.Add(this.TBAddClient_Cli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClientWind";
            this.Text = "Ajouter un Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAddClient_Cli;
        private System.Windows.Forms.TextBox TBAddClient_Email;
        private System.Windows.Forms.TextBox TBAddClient_Tel;
        private System.Windows.Forms.Label LAddClient_Cli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BAddClient_OK;
        private System.Windows.Forms.Button BAddClient_Annuler;
    }
}