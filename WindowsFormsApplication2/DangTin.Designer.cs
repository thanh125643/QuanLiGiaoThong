namespace WindowsFormsApplication2
{
    partial class DangTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangTin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPhuong = new System.Windows.Forms.ComboBox();
            this.cmbQuan = new System.Windows.Forms.ComboBox();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoNguoiLQ = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDuong = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chi tiết ";
            // 
            // cmbPhuong
            // 
            this.cmbPhuong.FormattingEnabled = true;
            this.cmbPhuong.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbPhuong.Location = new System.Drawing.Point(468, 148);
            this.cmbPhuong.Name = "cmbPhuong";
            this.cmbPhuong.Size = new System.Drawing.Size(58, 21);
            this.cmbPhuong.TabIndex = 6;
            // 
            // cmbQuan
            // 
            this.cmbQuan.FormattingEnabled = true;
            this.cmbQuan.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbQuan.Location = new System.Drawing.Point(644, 148);
            this.cmbQuan.Name = "cmbQuan";
            this.cmbQuan.Size = new System.Drawing.Size(61, 21);
            this.cmbQuan.TabIndex = 7;
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(68, 24);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(669, 89);
            this.txtChiTiet.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày xảy ra";
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(111, 206);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(247, 20);
            this.dtNgay.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số người liên quan";
            // 
            // txtSoNguoiLQ
            // 
            this.txtSoNguoiLQ.Location = new System.Drawing.Point(492, 209);
            this.txtSoNguoiLQ.Name = "txtSoNguoiLQ";
            this.txtSoNguoiLQ.Size = new System.Drawing.Size(77, 20);
            this.txtSoNguoiLQ.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(394, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 50);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDuong
            // 
            this.txtDuong.Location = new System.Drawing.Point(91, 148);
            this.txtDuong.Name = "txtDuong";
            this.txtDuong.Size = new System.Drawing.Size(267, 20);
            this.txtDuong.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(263, 259);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 50);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DangTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 321);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDuong);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSoNguoiLQ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.cmbQuan);
            this.Controls.Add(this.cmbPhuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangTin";
            this.Text = "DangTin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangTin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPhuong;
        private System.Windows.Forms.ComboBox cmbQuan;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoNguoiLQ;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDuong;
        private System.Windows.Forms.Button btnBack;
    }
}