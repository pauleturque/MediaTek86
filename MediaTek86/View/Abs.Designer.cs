
namespace MediaTek86.View
{
    partial class Connection
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
            this.lblBanner = new System.Windows.Forms.Label();
            this.lstBoxAbs = new System.Windows.Forms.CheckedListBox();
            this.btnAddAbs = new System.Windows.Forms.Button();
            this.btnDelAbs = new System.Windows.Forms.Button();
            this.btnModAbs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, -3);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Padding = new System.Windows.Forms.Padding(280, 40, 280, 40);
            this.lblBanner.Size = new System.Drawing.Size(732, 115);
            this.lblBanner.TabIndex = 2;
            this.lblBanner.Text = "MediaTek86";
            // 
            // lstBoxAbs
            // 
            this.lstBoxAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxAbs.FormattingEnabled = true;
            this.lstBoxAbs.Location = new System.Drawing.Point(66, 200);
            this.lstBoxAbs.Name = "lstBoxAbs";
            this.lstBoxAbs.Size = new System.Drawing.Size(575, 214);
            this.lstBoxAbs.TabIndex = 3;
            // 
            // btnAddAbs
            // 
            this.btnAddAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAbs.Location = new System.Drawing.Point(66, 159);
            this.btnAddAbs.Name = "btnAddAbs";
            this.btnAddAbs.Size = new System.Drawing.Size(96, 35);
            this.btnAddAbs.TabIndex = 4;
            this.btnAddAbs.Text = "Ajouter";
            this.btnAddAbs.UseVisualStyleBackColor = false;
            // 
            // btnDelAbs
            // 
            this.btnDelAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAbs.Location = new System.Drawing.Point(168, 159);
            this.btnDelAbs.Name = "btnDelAbs";
            this.btnDelAbs.Size = new System.Drawing.Size(96, 35);
            this.btnDelAbs.TabIndex = 5;
            this.btnDelAbs.Text = "Supprimer";
            this.btnDelAbs.UseVisualStyleBackColor = false;
            // 
            // btnModAbs
            // 
            this.btnModAbs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModAbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAbs.Location = new System.Drawing.Point(270, 159);
            this.btnModAbs.Name = "btnModAbs";
            this.btnModAbs.Size = new System.Drawing.Size(96, 35);
            this.btnModAbs.TabIndex = 6;
            this.btnModAbs.Text = "Modifier";
            this.btnModAbs.UseVisualStyleBackColor = false;
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 445);
            this.Controls.Add(this.btnModAbs);
            this.Controls.Add(this.btnDelAbs);
            this.Controls.Add(this.btnAddAbs);
            this.Controls.Add(this.lstBoxAbs);
            this.Controls.Add(this.lblBanner);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.CheckedListBox lstBoxAbs;
        private System.Windows.Forms.Button btnAddAbs;
        private System.Windows.Forms.Button btnDelAbs;
        private System.Windows.Forms.Button btnModAbs;
    }
}