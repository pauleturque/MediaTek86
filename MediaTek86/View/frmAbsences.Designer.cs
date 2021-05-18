
namespace MediaTek86.View
{
    partial class frmAbsences
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
            this.lstAbs = new System.Windows.Forms.CheckedListBox();
            this.lblBanner = new System.Windows.Forms.Label();
            this.btnAddAbs = new System.Windows.Forms.Button();
            this.btnDelAbs = new System.Windows.Forms.Button();
            this.btnModAbs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAbs
            // 
            this.lstAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAbs.FormattingEnabled = true;
            this.lstAbs.Location = new System.Drawing.Point(32, 420);
            this.lstAbs.Name = "lstAbs";
            this.lstAbs.Size = new System.Drawing.Size(1352, 500);
            this.lstAbs.TabIndex = 0;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(-25, 9);
            this.lblBanner.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Padding = new System.Windows.Forms.Padding(560, 77, 560, 77);
            this.lblBanner.Size = new System.Drawing.Size(1468, 224);
            this.lblBanner.TabIndex = 3;
            this.lblBanner.Text = "MediaTek86";
            // 
            // btnAddAbs
            // 
            this.btnAddAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAbs.Location = new System.Drawing.Point(32, 352);
            this.btnAddAbs.Name = "btnAddAbs";
            this.btnAddAbs.Size = new System.Drawing.Size(207, 45);
            this.btnAddAbs.TabIndex = 4;
            this.btnAddAbs.Text = "Ajouter";
            this.btnAddAbs.UseVisualStyleBackColor = false;
            // 
            // btnDelAbs
            // 
            this.btnDelAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAbs.Location = new System.Drawing.Point(266, 352);
            this.btnDelAbs.Name = "btnDelAbs";
            this.btnDelAbs.Size = new System.Drawing.Size(207, 45);
            this.btnDelAbs.TabIndex = 5;
            this.btnDelAbs.Text = "Supprimer";
            this.btnDelAbs.UseVisualStyleBackColor = false;
            // 
            // btnModAbs
            // 
            this.btnModAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAbs.Location = new System.Drawing.Point(502, 352);
            this.btnModAbs.Name = "btnModAbs";
            this.btnModAbs.Size = new System.Drawing.Size(207, 45);
            this.btnModAbs.TabIndex = 6;
            this.btnModAbs.Text = "Modifier";
            this.btnModAbs.UseVisualStyleBackColor = false;
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 956);
            this.Controls.Add(this.btnModAbs);
            this.Controls.Add(this.btnDelAbs);
            this.Controls.Add(this.btnAddAbs);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.lstAbs);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Absences";
            this.Text = "Absences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstAbs;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Button btnAddAbs;
        private System.Windows.Forms.Button btnDelAbs;
        private System.Windows.Forms.Button btnModAbs;
    }
}