namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kondisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.garansiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengajuanReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bantuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem,
            this.barangToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.bantuanToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gudangToolStripMenuItem,
            this.merekToolStripMenuItem,
            this.kondisiToolStripMenuItem,
            this.garansiToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // gudangToolStripMenuItem
            // 
            this.gudangToolStripMenuItem.Name = "gudangToolStripMenuItem";
            this.gudangToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gudangToolStripMenuItem.Text = "Gudang";
            this.gudangToolStripMenuItem.Click += new System.EventHandler(this.gudangToolStripMenuItem_Click);
            // 
            // merekToolStripMenuItem
            // 
            this.merekToolStripMenuItem.Name = "merekToolStripMenuItem";
            this.merekToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.merekToolStripMenuItem.Text = "Merek";
            this.merekToolStripMenuItem.Click += new System.EventHandler(this.merekToolStripMenuItem_Click);
            // 
            // kondisiToolStripMenuItem
            // 
            this.kondisiToolStripMenuItem.Name = "kondisiToolStripMenuItem";
            this.kondisiToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kondisiToolStripMenuItem.Text = "Kondisi";
            this.kondisiToolStripMenuItem.Click += new System.EventHandler(this.kondisiToolStripMenuItem_Click);
            // 
            // garansiToolStripMenuItem
            // 
            this.garansiToolStripMenuItem.Name = "garansiToolStripMenuItem";
            this.garansiToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.garansiToolStripMenuItem.Text = "Garansi";
            this.garansiToolStripMenuItem.Click += new System.EventHandler(this.garansiToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBarangToolStripMenuItem,
            this.stokBarangToolStripMenuItem});
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.barangToolStripMenuItem.Text = "Barang";
            // 
            // tambahBarangToolStripMenuItem
            // 
            this.tambahBarangToolStripMenuItem.Name = "tambahBarangToolStripMenuItem";
            this.tambahBarangToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tambahBarangToolStripMenuItem.Text = "Kelola Barang (item)";
            this.tambahBarangToolStripMenuItem.Click += new System.EventHandler(this.tambahBarangToolStripMenuItem_Click);
            // 
            // stokBarangToolStripMenuItem
            // 
            this.stokBarangToolStripMenuItem.Name = "stokBarangToolStripMenuItem";
            this.stokBarangToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.stokBarangToolStripMenuItem.Text = "Stok Barang";
            this.stokBarangToolStripMenuItem.Click += new System.EventHandler(this.stokBarangToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahTransaksiToolStripMenuItem,
            this.pengajuanReturnToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // tambahTransaksiToolStripMenuItem
            // 
            this.tambahTransaksiToolStripMenuItem.Name = "tambahTransaksiToolStripMenuItem";
            this.tambahTransaksiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tambahTransaksiToolStripMenuItem.Text = "Tambah Transaksi";
            this.tambahTransaksiToolStripMenuItem.Click += new System.EventHandler(this.tambahTransaksiToolStripMenuItem_Click);
            // 
            // pengajuanReturnToolStripMenuItem
            // 
            this.pengajuanReturnToolStripMenuItem.Name = "pengajuanReturnToolStripMenuItem";
            this.pengajuanReturnToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.pengajuanReturnToolStripMenuItem.Text = "Pengajuan Return";
            this.pengajuanReturnToolStripMenuItem.Click += new System.EventHandler(this.pengajuanReturnToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // bantuanToolStripMenuItem
            // 
            this.bantuanToolStripMenuItem.Name = "bantuanToolStripMenuItem";
            this.bantuanToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.bantuanToolStripMenuItem.Text = "Bantuan";
            this.bantuanToolStripMenuItem.Click += new System.EventHandler(this.bantuanToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem merekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kondisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem garansiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengajuanReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bantuanToolStripMenuItem;
    }
}

