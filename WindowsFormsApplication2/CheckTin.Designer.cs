namespace WindowsFormsApplication2
{
    partial class CheckTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckTin));
            this.button1 = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChiTiet = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNguoiLQ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDInform = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(141, 275);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(49, 42);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(196, 275);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(49, 42);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(363, 275);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(49, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(418, 275);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(49, 42);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Người đăng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nơi xảy ra vụ việc";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(141, 195);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(293, 20);
            this.txtDiaDiem.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chi tiết vụ việc";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtChiTiet
            // 
            this.txtChiTiet.Location = new System.Drawing.Point(141, 84);
            this.txtChiTiet.Multiline = true;
            this.txtChiTiet.Name = "txtChiTiet";
            this.txtChiTiet.Size = new System.Drawing.Size(476, 89);
            this.txtChiTiet.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(141, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Location = new System.Drawing.Point(141, 237);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(293, 20);
            this.txtThoiGian.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thời gian xảy ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trạng thái";
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbTrangThai.Location = new System.Drawing.Point(524, 237);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(80, 21);
            this.cmbTrangThai.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Loại Thông Tin";
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "Unchecked",
            "Checked"});
            this.cmbLoai.Location = new System.Drawing.Point(245, 10);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(121, 21);
            this.cmbLoai.TabIndex = 16;
            this.cmbLoai.SelectedIndexChanged += new System.EventHandler(this.cmbLoai_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(372, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số người LQ";
            // 
            // txtSoNguoiLQ
            // 
            this.txtSoNguoiLQ.Location = new System.Drawing.Point(524, 195);
            this.txtSoNguoiLQ.Name = "txtSoNguoiLQ";
            this.txtSoNguoiLQ.Size = new System.Drawing.Size(80, 20);
            this.txtSoNguoiLQ.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID Inform";
            // 
            // txtIDInform
            // 
            this.txtIDInform.Location = new System.Drawing.Point(455, 48);
            this.txtIDInform.Name = "txtIDInform";
            this.txtIDInform.Size = new System.Drawing.Size(162, 20);
            this.txtIDInform.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(265, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 329);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtIDInform);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSoNguoiLQ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTrangThai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThoiGian);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtChiTiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckTin";
            this.Text = "CheckTin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckTin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChiTiet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNguoiLQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDInform;
        private System.Windows.Forms.Button btnBack;
    }
}