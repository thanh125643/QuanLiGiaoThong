namespace WindowsFormsApplication2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhiệmVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dKTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbQuan = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtViecChuaGQ = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daToolStripMenuItem,
            this.nhiệmVụToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.checkTinToolStripMenuItem,
            this.phânCôngToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.dKTTToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daToolStripMenuItem
            // 
            this.daToolStripMenuItem.Name = "daToolStripMenuItem";
            this.daToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.daToolStripMenuItem.Text = "Đăng tin";
            this.daToolStripMenuItem.Click += new System.EventHandler(this.daToolStripMenuItem_Click);
            // 
            // nhiệmVụToolStripMenuItem
            // 
            this.nhiệmVụToolStripMenuItem.Name = "nhiệmVụToolStripMenuItem";
            this.nhiệmVụToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.nhiệmVụToolStripMenuItem.Text = "Nhiệm Vụ";
            this.nhiệmVụToolStripMenuItem.Click += new System.EventHandler(this.nhiệmVụToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // checkTinToolStripMenuItem
            // 
            this.checkTinToolStripMenuItem.Name = "checkTinToolStripMenuItem";
            this.checkTinToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.checkTinToolStripMenuItem.Text = "CheckTin";
            this.checkTinToolStripMenuItem.Click += new System.EventHandler(this.checkTinToolStripMenuItem_Click);
            // 
            // phânCôngToolStripMenuItem
            // 
            this.phânCôngToolStripMenuItem.Name = "phânCôngToolStripMenuItem";
            this.phânCôngToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.phânCôngToolStripMenuItem.Text = "Phân Công";
            this.phânCôngToolStripMenuItem.Click += new System.EventHandler(this.phânCôngToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // dKTTToolStripMenuItem
            // 
            this.dKTTToolStripMenuItem.Name = "dKTTToolStripMenuItem";
            this.dKTTToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dKTTToolStripMenuItem.Text = "DKTT";
            this.dKTTToolStripMenuItem.Click += new System.EventHandler(this.dKTTToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đã giải quyết";
            // 
            // cmbQuan
            // 
            this.cmbQuan.FormattingEnabled = true;
            this.cmbQuan.Items.AddRange(new object[] {
            "Q01",
            "Q02",
            "Q03",
            "Q04",
            "Q05",
            "Q06",
            "Q07",
            "Q08",
            "Q09",
            "Q10",
            "Q11",
            "Q12",
            "Q13",
            "Q14",
            "Q15"});
            this.cmbQuan.Location = new System.Drawing.Point(98, 110);
            this.cmbQuan.Name = "cmbQuan";
            this.cmbQuan.Size = new System.Drawing.Size(100, 21);
            this.cmbQuan.TabIndex = 5;
            this.cmbQuan.DropDown += new System.EventHandler(this.cmbQuan_DropDown);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(98, 199);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(221, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 338);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(63, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chưa giải quyết";
            // 
            // txtViecChuaGQ
            // 
            this.txtViecChuaGQ.Location = new System.Drawing.Point(98, 155);
            this.txtViecChuaGQ.Name = "txtViecChuaGQ";
            this.txtViecChuaGQ.Size = new System.Drawing.Size(100, 20);
            this.txtViecChuaGQ.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 365);
            this.Controls.Add(this.txtViecChuaGQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.cmbQuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhiệmVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dKTTToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbQuan;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtViecChuaGQ;
    }
}