namespace Gestion_ecole
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bienvenue = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.mdpOublie = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenue
            // 
            this.Bienvenue.AutoSize = true;
            this.Bienvenue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bienvenue.Location = new System.Drawing.Point(48, 36);
            this.Bienvenue.Name = "Bienvenue";
            this.Bienvenue.Size = new System.Drawing.Size(391, 39);
            this.Bienvenue.TabIndex = 0;
            this.Bienvenue.Text = "Bienvenue sur NOTARY";
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifiant.Location = new System.Drawing.Point(96, 274);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(63, 16);
            this.identifiant.TabIndex = 1;
            this.identifiant.Text = "Identifiant";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(70, 329);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(89, 16);
            this.mdp.TabIndex = 2;
            this.mdp.Text = "Mot de passe";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifiant.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIdentifiant.Location = new System.Drawing.Point(165, 271);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(160, 22);
            this.txtIdentifiant.TabIndex = 3;
            this.txtIdentifiant.Text = "\r\n";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMdp.Location = new System.Drawing.Point(165, 326);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMdp.Size = new System.Drawing.Size(160, 22);
            this.txtMdp.TabIndex = 4;
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConnecter.Location = new System.Drawing.Point(165, 398);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(160, 40);
            this.btnConnecter.TabIndex = 5;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // mdpOublie
            // 
            this.mdpOublie.ActiveLinkColor = System.Drawing.Color.Blue;
            this.mdpOublie.AutoSize = true;
            this.mdpOublie.LinkColor = System.Drawing.Color.Black;
            this.mdpOublie.Location = new System.Drawing.Point(194, 369);
            this.mdpOublie.Name = "mdpOublie";
            this.mdpOublie.Size = new System.Drawing.Size(102, 13);
            this.mdpOublie.TabIndex = 6;
            this.mdpOublie.TabStop = true;
            this.mdpOublie.Text = "Mot de passe oublié";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mdpOublie);
            this.Controls.Add(this.btnConnecter);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.Bienvenue);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page Authentification ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenue;
        private System.Windows.Forms.Label identifiant;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.LinkLabel mdpOublie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

