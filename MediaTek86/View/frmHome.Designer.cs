
namespace MediaTek86.View
{
    partial class frmHome
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
            this.listPersonnel = new System.Windows.Forms.CheckedListBox();
            this.btnAddPerso = new System.Windows.Forms.Button();
            this.btnDelPerso = new System.Windows.Forms.Button();
            this.btnModPerso = new System.Windows.Forms.Button();
            this.btnAbs = new System.Windows.Forms.Button();
            this.lblBanner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPersonnel
            // 
            this.listPersonnel.FormattingEnabled = true;
            this.listPersonnel.Location = new System.Drawing.Point(38, 357);
            this.listPersonnel.Name = "listPersonnel";
            this.listPersonnel.Size = new System.Drawing.Size(944, 510);
            this.listPersonnel.TabIndex = 0;
            this.listPersonnel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddPerso
            // 
            this.btnAddPerso.Location = new System.Drawing.Point(38, 295);
            this.btnAddPerso.Name = "btnAddPerso";
            this.btnAddPerso.Size = new System.Drawing.Size(155, 41);
            this.btnAddPerso.TabIndex = 1;
            this.btnAddPerso.Text = "Ajouter";
            this.btnAddPerso.UseVisualStyleBackColor = true;
            this.btnAddPerso.Click += new System.EventHandler(this.btnAddPerso_Click);
            // 
            // btnDelPerso
            // 
            this.btnDelPerso.Location = new System.Drawing.Point(216, 295);
            this.btnDelPerso.Name = "btnDelPerso";
            this.btnDelPerso.Size = new System.Drawing.Size(149, 41);
            this.btnDelPerso.TabIndex = 2;
            this.btnDelPerso.Text = "Supprimer";
            this.btnDelPerso.UseVisualStyleBackColor = true;
            // 
            // btnModPerso
            // 
            this.btnModPerso.Location = new System.Drawing.Point(386, 295);
            this.btnModPerso.Name = "btnModPerso";
            this.btnModPerso.Size = new System.Drawing.Size(163, 41);
            this.btnModPerso.TabIndex = 3;
            this.btnModPerso.Text = "Modifier";
            this.btnModPerso.UseVisualStyleBackColor = true;
            // 
            // btnAbs
            // 
            this.btnAbs.Location = new System.Drawing.Point(570, 295);
            this.btnAbs.Name = "btnAbs";
            this.btnAbs.Size = new System.Drawing.Size(171, 41);
            this.btnAbs.TabIndex = 4;
            this.btnAbs.Text = "Absences";
            this.btnAbs.UseVisualStyleBackColor = true;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(-22, -4);
            this.lblBanner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBanner.MaximumSize = new System.Drawing.Size(1468, 224);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Padding = new System.Windows.Forms.Padding(350, 77, 350, 77);
            this.lblBanner.Size = new System.Drawing.Size(919, 199);
            this.lblBanner.TabIndex = 5;
            this.lblBanner.Text = "MediaTek86";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 875);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.btnAbs);
            this.Controls.Add(this.btnModPerso);
            this.Controls.Add(this.btnDelPerso);
            this.Controls.Add(this.btnAddPerso);
            this.Controls.Add(this.listPersonnel);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHome";
            this.Text = "MediaTek - Personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listPersonnel;
        private System.Windows.Forms.Button btnAddPerso;
        private System.Windows.Forms.Button btnDelPerso;
        private System.Windows.Forms.Button btnModPerso;
        private System.Windows.Forms.Button btnAbs;
        private System.Windows.Forms.Label lblBanner;
    }
}