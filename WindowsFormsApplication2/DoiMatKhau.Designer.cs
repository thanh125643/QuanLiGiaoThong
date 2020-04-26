namespace WindowsFormsApplication2
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mậ khẩu";
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(133, 57);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.PasswordChar = '*';
            this.txtMkCu.Size = new System.Drawing.Size(190, 20);
            this.txtMkCu.TabIndex = 3;
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(133, 103);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.PasswordChar = '*';
            this.txtMkMoi.Size = new System.Drawing.Size(190, 20);
            this.txtMkMoi.TabIndex = 4;
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(133, 152);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(190, 20);
            this.txtNhapLai.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(193, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 48);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(68, 194);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 48);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 270);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMkMoi);
            this.Controls.Add(this.txtMkCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoiMatKhau";
            this.Text = "Doi Mat Khau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoiMatKhau_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;

    }
}