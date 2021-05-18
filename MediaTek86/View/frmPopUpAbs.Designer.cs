
namespace MediaTek86.View
{
    partial class frmPopUpAbs
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
            this.dateDeb = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.lstMotif = new System.Windows.Forms.ComboBox();
            this.lblDateDeb = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateDeb
            // 
            this.dateDeb.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeb.Location = new System.Drawing.Point(418, 101);
            this.dateDeb.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dateDeb.Name = "dateDeb";
            this.dateDeb.Size = new System.Drawing.Size(344, 34);
            this.dateDeb.TabIndex = 0;
            // 
            // dateFin
            // 
            this.dateFin.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Location = new System.Drawing.Point(418, 179);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(344, 34);
            this.dateFin.TabIndex = 1;
            // 
            // lstMotif
            // 
            this.lstMotif.FormattingEnabled = true;
            this.lstMotif.Location = new System.Drawing.Point(418, 264);
            this.lstMotif.Name = "lstMotif";
            this.lstMotif.Size = new System.Drawing.Size(344, 36);
            this.lstMotif.TabIndex = 2;
            // 
            // lblDateDeb
            // 
            this.lblDateDeb.AutoSize = true;
            this.lblDateDeb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDeb.Location = new System.Drawing.Point(190, 101);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(192, 31);
            this.lblDateDeb.TabIndex = 3;
            this.lblDateDeb.Text = "Date de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(232, 179);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(153, 31);
            this.lblDateFin.TabIndex = 4;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(141, 262);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(237, 31);
            this.lblMotif.TabIndex = 5;
            this.lblMotif.Text = "Motif de l\'absence :";
            // 
            // btnVal
            // 
            this.btnVal.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnVal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVal.Location = new System.Drawing.Point(215, 356);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(215, 75);
            this.btnVal.TabIndex = 6;
            this.btnVal.Text = "OK";
            this.btnVal.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(485, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(215, 75);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // PopUpAbs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 504);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDeb);
            this.Controls.Add(this.lstMotif);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateDeb);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PopUpAbs";
            this.Text = "Ajouter / Modier une absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDeb;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.ComboBox lstMotif;
        private System.Windows.Forms.Label lblDateDeb;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Button btnCancel;
    }
}