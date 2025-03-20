namespace TestWindowsForm_VietNam
{
    partial class frmTestWindowsForm
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
            this.lblChonChuong = new System.Windows.Forms.Label();
            this.cmbChonChuong = new System.Windows.Forms.ComboBox();
            this.btnVaoBaiKiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChonChuong
            // 
            this.lblChonChuong.AutoSize = true;
            this.lblChonChuong.Location = new System.Drawing.Point(31, 18);
            this.lblChonChuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonChuong.Name = "lblChonChuong";
            this.lblChonChuong.Size = new System.Drawing.Size(265, 22);
            this.lblChonChuong.TabIndex = 0;
            this.lblChonChuong.Text = "Chọn chương muốn kiểm tra:";
            // 
            // cmbChonChuong
            // 
            this.cmbChonChuong.FormattingEnabled = true;
            this.cmbChonChuong.Items.AddRange(new object[] {
            "Chương 1",
            "Chương 2",
            "Chương 3",
            "Chương 4",
            "Chương 5",
            "Chương 6",
            "Chương 7",
            "Chương 8"});
            this.cmbChonChuong.Location = new System.Drawing.Point(46, 66);
            this.cmbChonChuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChonChuong.Name = "cmbChonChuong";
            this.cmbChonChuong.Size = new System.Drawing.Size(214, 30);
            this.cmbChonChuong.TabIndex = 1;
            // 
            // btnVaoBaiKiemTra
            // 
            this.btnVaoBaiKiemTra.Location = new System.Drawing.Point(64, 123);
            this.btnVaoBaiKiemTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVaoBaiKiemTra.Name = "btnVaoBaiKiemTra";
            this.btnVaoBaiKiemTra.Size = new System.Drawing.Size(173, 66);
            this.btnVaoBaiKiemTra.TabIndex = 2;
            this.btnVaoBaiKiemTra.Text = "Kiểm tra ngay";
            this.btnVaoBaiKiemTra.UseVisualStyleBackColor = true;
            this.btnVaoBaiKiemTra.Click += new System.EventHandler(this.btnVaoBaiKiemTra_Click);
            // 
            // frmTestWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 221);
            this.Controls.Add(this.btnVaoBaiKiemTra);
            this.Controls.Add(this.cmbChonChuong);
            this.Controls.Add(this.lblChonChuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmTestWindowsForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChonChuong;
        private System.Windows.Forms.ComboBox cmbChonChuong;
        private System.Windows.Forms.Button btnVaoBaiKiemTra;
    }
}

