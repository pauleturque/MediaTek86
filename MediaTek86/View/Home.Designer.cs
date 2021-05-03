
namespace MediaTek86
{
    partial class Home
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
            this.lstBoxPerso = new System.Windows.Forms.CheckedListBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.btnAddPerso = new System.Windows.Forms.Button();
            this.btnDelPerso = new System.Windows.Forms.Button();
            this.btnModPerso = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxPerso
            // 
            this.lstBoxPerso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPerso.FormattingEnabled = true;
            this.lstBoxPerso.Location = new System.Drawing.Point(31, 200);
            this.lstBoxPerso.Name = "lstBoxPerso";
            this.lstBoxPerso.Size = new System.Drawing.Size(659, 213);
            this.lstBoxPerso.TabIndex = 0;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(-5, -1);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Padding = new System.Windows.Forms.Padding(280, 40, 280, 40);
            this.lblBanner.Size = new System.Drawing.Size(732, 115);
            this.lblBanner.TabIndex = 1;
            this.lblBanner.Text = "MediaTek86";
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddPerso.FlatAppearance.BorderSize = 0;
            this.btnAddPerso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddPerso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerso.Location = new System.Drawing.Point(31, 166);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(88, 28);
            this.btnAddPerso.TabIndex = 2;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = false;
            // 
            // btnDelPerso
            // 
            this.btnDelPerso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelPerso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPerso.Location = new System.Drawing.Point(125, 166);
            this.btnDelPerso.Name = "btnDelPerso";
            this.btnDelPerso.Size = new System.Drawing.Size(87, 28);
            this.btnDelPerso.TabIndex = 3;
            this.btnDelPerso.Text = "Supprimer";
            this.btnDelPerso.UseVisualStyleBackColor = false;
            // 
            // btnModPerso
            // 
            this.btnModPerso.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModPerso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModPerso.Location = new System.Drawing.Point(218, 166);
            this.btnModPerso.Name = "btnModPerso";
            this.btnModPerso.Size = new System.Drawing.Size(85, 28);
            this.btnModPerso.TabIndex = 4;
            this.btnModPerso.Text = "Modifier";
            this.btnModPerso.UseVisualStyleBackColor = false;
            // 
            // btnAbs
            // 
            this.btnAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbs.Location = new System.Drawing.Point(309, 166);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(92, 28);
            this.btnAbs.TabIndex = 5;
            this.btnAbs.Text = "Absences";
            this.btnAbs.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 458);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnModPerso);
            this.Controls.Add(this.btnDelPerso);
            this.Controls.Add(this.btnAddPerso);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.lstBoxPerso);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "MediaTek86 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstBoxPerso;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnAddPerso;
        private System.Windows.Forms.Button btnDelPerso;
        private System.Windows.Forms.Button btnModPerso;
        private System.Windows.Forms.Button btnAbs;
    }
}

