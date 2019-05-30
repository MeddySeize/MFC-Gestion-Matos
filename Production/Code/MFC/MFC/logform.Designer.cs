namespace MFC
{
    partial class FLogin
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
            this.Ulabel = new System.Windows.Forms.Label();
            this.UText = new System.Windows.Forms.TextBox();
            this.Ptext = new System.Windows.Forms.TextBox();
            this.Plabel = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ulabel
            // 
            this.Ulabel.AutoSize = true;
            this.Ulabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ulabel.Location = new System.Drawing.Point(3, 10);
            this.Ulabel.Name = "Ulabel";
            this.Ulabel.Size = new System.Drawing.Size(155, 25);
            this.Ulabel.TabIndex = 1;
            this.Ulabel.Text = "Nom d\'utilisateur";
            // 
            // UText
            // 
            this.UText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UText.Location = new System.Drawing.Point(169, 10);
            this.UText.Name = "UText";
            this.UText.Size = new System.Drawing.Size(266, 27);
            this.UText.TabIndex = 2;
            // 
            // Ptext
            // 
            this.Ptext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ptext.Location = new System.Drawing.Point(169, 61);
            this.Ptext.Name = "Ptext";
            this.Ptext.Size = new System.Drawing.Size(266, 27);
            this.Ptext.TabIndex = 4;
            // 
            // Plabel
            // 
            this.Plabel.AutoSize = true;
            this.Plabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plabel.Location = new System.Drawing.Point(17, 60);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(132, 25);
            this.Plabel.TabIndex = 5;
            this.Plabel.Text = "Mot de Passe";
            // 
            // LoginBut
            // 
            this.LoginBut.Location = new System.Drawing.Point(169, 94);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(117, 37);
            this.LoginBut.TabIndex = 6;
            this.LoginBut.Text = "Valider";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Plabel);
            this.panel1.Controls.Add(this.LoginBut);
            this.panel1.Controls.Add(this.Ptext);
            this.panel1.Controls.Add(this.UText);
            this.panel1.Controls.Add(this.Ulabel);
            this.panel1.Location = new System.Drawing.Point(-5, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 144);
            this.panel1.TabIndex = 9;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 325);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ulabel;
        private System.Windows.Forms.TextBox UText;
        private System.Windows.Forms.TextBox Ptext;
        private System.Windows.Forms.Label Plabel;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Panel panel1;
    }
}