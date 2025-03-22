namespace TestWindowsForm_VietNam
{
    partial class frmKetquakiemtra
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
            this.lblketqua = new System.Windows.Forms.Label();
            this.lblcaudung = new System.Windows.Forms.Label();
            this.lblcausai = new System.Windows.Forms.Label();
            this.lblsocaudalam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Location = new System.Drawing.Point(45, 11);
            this.lblketqua.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(50, 16);
            this.lblketqua.TabIndex = 0;
            this.lblketqua.Text = "label1";
            // 
            // lblcaudung
            // 
            this.lblcaudung.AutoSize = true;
            this.lblcaudung.Location = new System.Drawing.Point(428, 13);
            this.lblcaudung.Name = "lblcaudung";
            this.lblcaudung.Size = new System.Drawing.Size(50, 16);
            this.lblcaudung.TabIndex = 1;
            this.lblcaudung.Text = "label1";
            // 
            // lblcausai
            // 
            this.lblcausai.AutoSize = true;
            this.lblcausai.Location = new System.Drawing.Point(525, 13);
            this.lblcausai.Name = "lblcausai";
            this.lblcausai.Size = new System.Drawing.Size(50, 16);
            this.lblcausai.TabIndex = 2;
            this.lblcausai.Text = "label2";
            // 
            // lblsocaudalam
            // 
            this.lblsocaudalam.AutoSize = true;
            this.lblsocaudalam.Location = new System.Drawing.Point(428, 57);
            this.lblsocaudalam.Name = "lblsocaudalam";
            this.lblsocaudalam.Size = new System.Drawing.Size(50, 16);
            this.lblsocaudalam.TabIndex = 3;
            this.lblsocaudalam.Text = "label1";
            // 
            // frmKetquakiemtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 881);
            this.Controls.Add(this.lblsocaudalam);
            this.Controls.Add(this.lblcausai);
            this.Controls.Add(this.lblcaudung);
            this.Controls.Add(this.lblketqua);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmKetquakiemtra";
            this.Text = "Kết quả";
            this.Load += new System.EventHandler(this.frmKetquakiemtra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.Label lblcaudung;
        private System.Windows.Forms.Label lblcausai;
        private System.Windows.Forms.Label lblsocaudalam;
    }
}