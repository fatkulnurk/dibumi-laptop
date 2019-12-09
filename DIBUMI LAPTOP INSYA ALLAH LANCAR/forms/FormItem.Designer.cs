namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    partial class FormItem
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.merek_comboBox1 = new System.Windows.Forms.ComboBox();
            this.merekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dibumilaptopDataSet = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSet();
            this.tipe_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deskripsi_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.processor_textBox2 = new System.Windows.Forms.TextBox();
            this.ram_textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.penyimpanan_textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ukuran_layar_textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lokasi_gudang_comboBox2 = new System.Windows.Forms.ComboBox();
            this.gudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.kondisi_comboBox3 = new System.Windows.Forms.ComboBox();
            this.kondisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tanggal_ditambahkan_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.garansi_expired_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.jenis_garansi_comboBox4 = new System.Windows.Forms.ComboBox();
            this.garansiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.merekTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.merekTableAdapter();
            this.gudangTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.gudangTableAdapter();
            this.kondisiTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.kondisiTableAdapter();
            this.garansiTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.garansiTableAdapter();
            this.simpan_button1 = new System.Windows.Forms.Button();
            this.delete_button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stok_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.harga_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ItemdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garansiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipe";
            // 
            // merek_comboBox1
            // 
            this.merek_comboBox1.DataSource = this.merekBindingSource;
            this.merek_comboBox1.DisplayMember = "nama";
            this.merek_comboBox1.FormattingEnabled = true;
            this.merek_comboBox1.Location = new System.Drawing.Point(141, 47);
            this.merek_comboBox1.Name = "merek_comboBox1";
            this.merek_comboBox1.Size = new System.Drawing.Size(199, 21);
            this.merek_comboBox1.TabIndex = 2;
            this.merek_comboBox1.ValueMember = "id";
            // 
            // merekBindingSource
            // 
            this.merekBindingSource.DataMember = "merek";
            this.merekBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // dibumilaptopDataSet
            // 
            this.dibumilaptopDataSet.DataSetName = "dibumilaptopDataSet";
            this.dibumilaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipe_textBox1
            // 
            this.tipe_textBox1.Location = new System.Drawing.Point(141, 77);
            this.tipe_textBox1.Name = "tipe_textBox1";
            this.tipe_textBox1.Size = new System.Drawing.Size(199, 20);
            this.tipe_textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deskripsi";
            // 
            // deskripsi_richTextBox1
            // 
            this.deskripsi_richTextBox1.Location = new System.Drawing.Point(141, 111);
            this.deskripsi_richTextBox1.Name = "deskripsi_richTextBox1";
            this.deskripsi_richTextBox1.Size = new System.Drawing.Size(199, 96);
            this.deskripsi_richTextBox1.TabIndex = 5;
            this.deskripsi_richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Processor";
            // 
            // processor_textBox2
            // 
            this.processor_textBox2.Location = new System.Drawing.Point(141, 221);
            this.processor_textBox2.Name = "processor_textBox2";
            this.processor_textBox2.Size = new System.Drawing.Size(199, 20);
            this.processor_textBox2.TabIndex = 7;
            // 
            // ram_textBox3
            // 
            this.ram_textBox3.Location = new System.Drawing.Point(141, 247);
            this.ram_textBox3.Name = "ram_textBox3";
            this.ram_textBox3.Size = new System.Drawing.Size(199, 20);
            this.ram_textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ram";
            // 
            // penyimpanan_textBox4
            // 
            this.penyimpanan_textBox4.Location = new System.Drawing.Point(528, 44);
            this.penyimpanan_textBox4.Name = "penyimpanan_textBox4";
            this.penyimpanan_textBox4.Size = new System.Drawing.Size(199, 20);
            this.penyimpanan_textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Penyimpanan";
            // 
            // ukuran_layar_textBox5
            // 
            this.ukuran_layar_textBox5.Location = new System.Drawing.Point(528, 70);
            this.ukuran_layar_textBox5.Name = "ukuran_layar_textBox5";
            this.ukuran_layar_textBox5.Size = new System.Drawing.Size(199, 20);
            this.ukuran_layar_textBox5.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ukuran Layar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Stok";
            // 
            // lokasi_gudang_comboBox2
            // 
            this.lokasi_gudang_comboBox2.DataSource = this.gudangBindingSource;
            this.lokasi_gudang_comboBox2.DisplayMember = "nama";
            this.lokasi_gudang_comboBox2.FormattingEnabled = true;
            this.lokasi_gudang_comboBox2.Location = new System.Drawing.Point(528, 122);
            this.lokasi_gudang_comboBox2.Name = "lokasi_gudang_comboBox2";
            this.lokasi_gudang_comboBox2.Size = new System.Drawing.Size(199, 21);
            this.lokasi_gudang_comboBox2.TabIndex = 17;
            this.lokasi_gudang_comboBox2.ValueMember = "id";
            // 
            // gudangBindingSource
            // 
            this.gudangBindingSource.DataMember = "gudang";
            this.gudangBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lokasi Gudang";
            // 
            // kondisi_comboBox3
            // 
            this.kondisi_comboBox3.DataSource = this.kondisiBindingSource;
            this.kondisi_comboBox3.DisplayMember = "nama";
            this.kondisi_comboBox3.FormattingEnabled = true;
            this.kondisi_comboBox3.Location = new System.Drawing.Point(528, 149);
            this.kondisi_comboBox3.Name = "kondisi_comboBox3";
            this.kondisi_comboBox3.Size = new System.Drawing.Size(199, 21);
            this.kondisi_comboBox3.TabIndex = 19;
            this.kondisi_comboBox3.ValueMember = "id";
            // 
            // kondisiBindingSource
            // 
            this.kondisiBindingSource.DataMember = "kondisi";
            this.kondisiBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kondisi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tanggal Ditambahkan";
            // 
            // tanggal_ditambahkan_dateTimePicker1
            // 
            this.tanggal_ditambahkan_dateTimePicker1.Location = new System.Drawing.Point(528, 176);
            this.tanggal_ditambahkan_dateTimePicker1.Name = "tanggal_ditambahkan_dateTimePicker1";
            this.tanggal_ditambahkan_dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.tanggal_ditambahkan_dateTimePicker1.TabIndex = 21;
            // 
            // garansi_expired_dateTimePicker2
            // 
            this.garansi_expired_dateTimePicker2.Location = new System.Drawing.Point(528, 229);
            this.garansi_expired_dateTimePicker2.Name = "garansi_expired_dateTimePicker2";
            this.garansi_expired_dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.garansi_expired_dateTimePicker2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(413, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Garansi Expired";
            // 
            // jenis_garansi_comboBox4
            // 
            this.jenis_garansi_comboBox4.DataSource = this.garansiBindingSource;
            this.jenis_garansi_comboBox4.DisplayMember = "nama";
            this.jenis_garansi_comboBox4.FormattingEnabled = true;
            this.jenis_garansi_comboBox4.Location = new System.Drawing.Point(528, 202);
            this.jenis_garansi_comboBox4.Name = "jenis_garansi_comboBox4";
            this.jenis_garansi_comboBox4.Size = new System.Drawing.Size(199, 21);
            this.jenis_garansi_comboBox4.TabIndex = 25;
            this.jenis_garansi_comboBox4.ValueMember = "id";
            // 
            // garansiBindingSource
            // 
            this.garansiBindingSource.DataMember = "garansi";
            this.garansiBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Jenis Garansi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(413, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Harga";
            // 
            // merekTableAdapter
            // 
            this.merekTableAdapter.ClearBeforeFill = true;
            // 
            // gudangTableAdapter
            // 
            this.gudangTableAdapter.ClearBeforeFill = true;
            // 
            // kondisiTableAdapter
            // 
            this.kondisiTableAdapter.ClearBeforeFill = true;
            // 
            // garansiTableAdapter
            // 
            this.garansiTableAdapter.ClearBeforeFill = true;
            // 
            // simpan_button1
            // 
            this.simpan_button1.Location = new System.Drawing.Point(31, 318);
            this.simpan_button1.Name = "simpan_button1";
            this.simpan_button1.Size = new System.Drawing.Size(109, 23);
            this.simpan_button1.TabIndex = 28;
            this.simpan_button1.Text = "SIMPAN DATA";
            this.simpan_button1.UseVisualStyleBackColor = true;
            this.simpan_button1.Click += new System.EventHandler(this.simpan_button1_Click);
            // 
            // delete_button1
            // 
            this.delete_button1.Location = new System.Drawing.Point(156, 318);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(123, 23);
            this.delete_button1.TabIndex = 29;
            this.delete_button1.Text = "Delete";
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Click += new System.EventHandler(this.delete_button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stok_numericUpDown1
            // 
            this.stok_numericUpDown1.Location = new System.Drawing.Point(528, 97);
            this.stok_numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stok_numericUpDown1.Name = "stok_numericUpDown1";
            this.stok_numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.stok_numericUpDown1.TabIndex = 31;
            // 
            // harga_numericUpDown1
            // 
            this.harga_numericUpDown1.Location = new System.Drawing.Point(528, 258);
            this.harga_numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.harga_numericUpDown1.Name = "harga_numericUpDown1";
            this.harga_numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.harga_numericUpDown1.TabIndex = 32;
            // 
            // ItemdataGridView1
            // 
            this.ItemdataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.ItemdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemdataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemdataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ItemdataGridView1.Location = new System.Drawing.Point(0, 503);
            this.ItemdataGridView1.Name = "ItemdataGridView1";
            this.ItemdataGridView1.Size = new System.Drawing.Size(974, 246);
            this.ItemdataGridView1.TabIndex = 33;
            this.ItemdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemdataGridView1_CellContentClick);
            this.ItemdataGridView1.DoubleClick += new System.EventHandler(this.ItemdataGridView1_DoubleClick);
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(974, 749);
            this.Controls.Add(this.ItemdataGridView1);
            this.Controls.Add(this.harga_numericUpDown1);
            this.Controls.Add(this.stok_numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.delete_button1);
            this.Controls.Add(this.simpan_button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.jenis_garansi_comboBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.garansi_expired_dateTimePicker2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tanggal_ditambahkan_dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.kondisi_comboBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lokasi_gudang_comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ukuran_layar_textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.penyimpanan_textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ram_textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.processor_textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deskripsi_richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tipe_textBox1);
            this.Controls.Add(this.merek_comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormItem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gudangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garansiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harga_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox merek_comboBox1;
        private System.Windows.Forms.TextBox tipe_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox deskripsi_richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processor_textBox2;
        private System.Windows.Forms.TextBox ram_textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox penyimpanan_textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ukuran_layar_textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox lokasi_gudang_comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox kondisi_comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tanggal_ditambahkan_dateTimePicker1;
        private System.Windows.Forms.DateTimePicker garansi_expired_dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox jenis_garansi_comboBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private dibumilaptopDataSet dibumilaptopDataSet;
        private System.Windows.Forms.BindingSource merekBindingSource;
        private dibumilaptopDataSetTableAdapters.merekTableAdapter merekTableAdapter;
        private System.Windows.Forms.BindingSource gudangBindingSource;
        private dibumilaptopDataSetTableAdapters.gudangTableAdapter gudangTableAdapter;
        private System.Windows.Forms.BindingSource kondisiBindingSource;
        private dibumilaptopDataSetTableAdapters.kondisiTableAdapter kondisiTableAdapter;
        private System.Windows.Forms.BindingSource garansiBindingSource;
        private dibumilaptopDataSetTableAdapters.garansiTableAdapter garansiTableAdapter;
        private System.Windows.Forms.Button simpan_button1;
        private System.Windows.Forms.Button delete_button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown stok_numericUpDown1;
        private System.Windows.Forms.NumericUpDown harga_numericUpDown1;
        private System.Windows.Forms.DataGridView ItemdataGridView1;
    }
}