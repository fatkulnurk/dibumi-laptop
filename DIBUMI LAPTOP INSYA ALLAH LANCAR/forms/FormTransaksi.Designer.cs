namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    partial class FormTransaksi
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
            this.merekTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.merekTableAdapter();
            this.tipe_laptop_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tanggal_transaksi_label4 = new System.Windows.Forms.Label();
            this.tanggal_transaksi_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.qty_label5 = new System.Windows.Forms.Label();
            this.qty_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.harga_satuan_label6 = new System.Windows.Forms.Label();
            this.harga_satuan_textBox1 = new System.Windows.Forms.TextBox();
            this.harga_total_textbox = new System.Windows.Forms.TextBox();
            this.harga_total_label7 = new System.Windows.Forms.Label();
            this.keterangan_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.keterangan_label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggaltransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasatuantempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaksiTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.transaksiTableAdapter();
            this.ukuran_layar_textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.penyimpanan_textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ram_textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.processor_textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deskripsi_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tipe_textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.stok_disable_textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.harga_peritem_disable_textBox4 = new System.Windows.Forms.TextBox();
            this.harga_satuan_per_item_label18 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.itemTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAMBAH TRANSAKSI BARU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih Merek";
            // 
            // merek_comboBox1
            // 
            this.merek_comboBox1.DataSource = this.merekBindingSource;
            this.merek_comboBox1.DisplayMember = "nama";
            this.merek_comboBox1.FormattingEnabled = true;
            this.merek_comboBox1.Location = new System.Drawing.Point(154, 105);
            this.merek_comboBox1.Name = "merek_comboBox1";
            this.merek_comboBox1.Size = new System.Drawing.Size(201, 21);
            this.merek_comboBox1.TabIndex = 3;
            this.merek_comboBox1.ValueMember = "id";
            this.merek_comboBox1.SelectionChangeCommitted += new System.EventHandler(this.merek_comboBox1_SelectionChangeCommitted);
            this.merek_comboBox1.SelectedValueChanged += new System.EventHandler(this.merek_comboBox1_SelectedValueChanged);
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
            // merekTableAdapter
            // 
            this.merekTableAdapter.ClearBeforeFill = true;
            // 
            // tipe_laptop_comboBox1
            // 
            this.tipe_laptop_comboBox1.DisplayMember = "id";
            this.tipe_laptop_comboBox1.FormattingEnabled = true;
            this.tipe_laptop_comboBox1.Location = new System.Drawing.Point(154, 144);
            this.tipe_laptop_comboBox1.Name = "tipe_laptop_comboBox1";
            this.tipe_laptop_comboBox1.Size = new System.Drawing.Size(201, 21);
            this.tipe_laptop_comboBox1.TabIndex = 5;
            this.tipe_laptop_comboBox1.ValueMember = "id";
            this.tipe_laptop_comboBox1.SelectionChangeCommitted += new System.EventHandler(this.tipe_laptop_comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pilih Tipe Laptop";
            // 
            // tanggal_transaksi_label4
            // 
            this.tanggal_transaksi_label4.AutoSize = true;
            this.tanggal_transaksi_label4.Location = new System.Drawing.Point(42, 179);
            this.tanggal_transaksi_label4.Name = "tanggal_transaksi_label4";
            this.tanggal_transaksi_label4.Size = new System.Drawing.Size(95, 13);
            this.tanggal_transaksi_label4.TabIndex = 6;
            this.tanggal_transaksi_label4.Text = "Tanggal Transaksi";
            // 
            // tanggal_transaksi_dateTimePicker1
            // 
            this.tanggal_transaksi_dateTimePicker1.Location = new System.Drawing.Point(154, 179);
            this.tanggal_transaksi_dateTimePicker1.Name = "tanggal_transaksi_dateTimePicker1";
            this.tanggal_transaksi_dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.tanggal_transaksi_dateTimePicker1.TabIndex = 7;
            // 
            // qty_label5
            // 
            this.qty_label5.AutoSize = true;
            this.qty_label5.Location = new System.Drawing.Point(42, 212);
            this.qty_label5.Name = "qty_label5";
            this.qty_label5.Size = new System.Drawing.Size(23, 13);
            this.qty_label5.TabIndex = 8;
            this.qty_label5.Text = "Qty";
            // 
            // qty_numericUpDown1
            // 
            this.qty_numericUpDown1.Location = new System.Drawing.Point(154, 212);
            this.qty_numericUpDown1.Name = "qty_numericUpDown1";
            this.qty_numericUpDown1.Size = new System.Drawing.Size(201, 20);
            this.qty_numericUpDown1.TabIndex = 9;
            this.qty_numericUpDown1.ValueChanged += new System.EventHandler(this.qty_numericUpDown1_ValueChanged);
            // 
            // harga_satuan_label6
            // 
            this.harga_satuan_label6.AutoSize = true;
            this.harga_satuan_label6.Location = new System.Drawing.Point(42, 246);
            this.harga_satuan_label6.Name = "harga_satuan_label6";
            this.harga_satuan_label6.Size = new System.Drawing.Size(73, 13);
            this.harga_satuan_label6.TabIndex = 10;
            this.harga_satuan_label6.Text = "Harga Satuan";
            // 
            // harga_satuan_textBox1
            // 
            this.harga_satuan_textBox1.Location = new System.Drawing.Point(154, 243);
            this.harga_satuan_textBox1.Name = "harga_satuan_textBox1";
            this.harga_satuan_textBox1.ReadOnly = true;
            this.harga_satuan_textBox1.Size = new System.Drawing.Size(200, 20);
            this.harga_satuan_textBox1.TabIndex = 11;
            // 
            // harga_total_textbox
            // 
            this.harga_total_textbox.Location = new System.Drawing.Point(155, 278);
            this.harga_total_textbox.Name = "harga_total_textbox";
            this.harga_total_textbox.ReadOnly = true;
            this.harga_total_textbox.Size = new System.Drawing.Size(200, 20);
            this.harga_total_textbox.TabIndex = 13;
            // 
            // harga_total_label7
            // 
            this.harga_total_label7.AutoSize = true;
            this.harga_total_label7.Location = new System.Drawing.Point(43, 281);
            this.harga_total_label7.Name = "harga_total_label7";
            this.harga_total_label7.Size = new System.Drawing.Size(63, 13);
            this.harga_total_label7.TabIndex = 12;
            this.harga_total_label7.Text = "Harga Total";
            // 
            // keterangan_richTextBox1
            // 
            this.keterangan_richTextBox1.Location = new System.Drawing.Point(155, 314);
            this.keterangan_richTextBox1.Name = "keterangan_richTextBox1";
            this.keterangan_richTextBox1.Size = new System.Drawing.Size(200, 96);
            this.keterangan_richTextBox1.TabIndex = 14;
            this.keterangan_richTextBox1.Text = "";
            // 
            // keterangan_label7
            // 
            this.keterangan_label7.AutoSize = true;
            this.keterangan_label7.Location = new System.Drawing.Point(45, 314);
            this.keterangan_label7.Name = "keterangan_label7";
            this.keterangan_label7.Size = new System.Drawing.Size(62, 13);
            this.keterangan_label7.TabIndex = 15;
            this.keterangan_label7.Text = "Keterangan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tambah Transaksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.tanggaltransaksiDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.hargasatuantempDataGridViewTextBoxColumn,
            this.totalhargaDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transaksiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1159, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // tanggaltransaksiDataGridViewTextBoxColumn
            // 
            this.tanggaltransaksiDataGridViewTextBoxColumn.DataPropertyName = "tanggal_transaksi";
            this.tanggaltransaksiDataGridViewTextBoxColumn.HeaderText = "tanggal_transaksi";
            this.tanggaltransaksiDataGridViewTextBoxColumn.Name = "tanggaltransaksiDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // hargasatuantempDataGridViewTextBoxColumn
            // 
            this.hargasatuantempDataGridViewTextBoxColumn.DataPropertyName = "harga_satuan_temp";
            this.hargasatuantempDataGridViewTextBoxColumn.HeaderText = "harga_satuan_temp";
            this.hargasatuantempDataGridViewTextBoxColumn.Name = "hargasatuantempDataGridViewTextBoxColumn";
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            // 
            // transaksiBindingSource
            // 
            this.transaksiBindingSource.DataMember = "transaksi";
            this.transaksiBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // transaksiTableAdapter
            // 
            this.transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // ukuran_layar_textBox5
            // 
            this.ukuran_layar_textBox5.Location = new System.Drawing.Point(549, 327);
            this.ukuran_layar_textBox5.Name = "ukuran_layar_textBox5";
            this.ukuran_layar_textBox5.ReadOnly = true;
            this.ukuran_layar_textBox5.Size = new System.Drawing.Size(199, 20);
            this.ukuran_layar_textBox5.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ukuran Layar";
            // 
            // penyimpanan_textBox4
            // 
            this.penyimpanan_textBox4.Location = new System.Drawing.Point(549, 301);
            this.penyimpanan_textBox4.Name = "penyimpanan_textBox4";
            this.penyimpanan_textBox4.ReadOnly = true;
            this.penyimpanan_textBox4.Size = new System.Drawing.Size(199, 20);
            this.penyimpanan_textBox4.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Penyimpanan";
            // 
            // ram_textBox3
            // 
            this.ram_textBox3.Location = new System.Drawing.Point(549, 275);
            this.ram_textBox3.Name = "ram_textBox3";
            this.ram_textBox3.ReadOnly = true;
            this.ram_textBox3.Size = new System.Drawing.Size(199, 20);
            this.ram_textBox3.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ram";
            // 
            // processor_textBox2
            // 
            this.processor_textBox2.Location = new System.Drawing.Point(549, 249);
            this.processor_textBox2.Name = "processor_textBox2";
            this.processor_textBox2.ReadOnly = true;
            this.processor_textBox2.Size = new System.Drawing.Size(199, 20);
            this.processor_textBox2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Processor";
            // 
            // deskripsi_richTextBox1
            // 
            this.deskripsi_richTextBox1.Location = new System.Drawing.Point(549, 139);
            this.deskripsi_richTextBox1.Name = "deskripsi_richTextBox1";
            this.deskripsi_richTextBox1.ReadOnly = true;
            this.deskripsi_richTextBox1.Size = new System.Drawing.Size(199, 96);
            this.deskripsi_richTextBox1.TabIndex = 21;
            this.deskripsi_richTextBox1.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Deskripsi";
            // 
            // tipe_textBox1
            // 
            this.tipe_textBox1.Location = new System.Drawing.Point(549, 105);
            this.tipe_textBox1.Name = "tipe_textBox1";
            this.tipe_textBox1.ReadOnly = true;
            this.tipe_textBox1.Size = new System.Drawing.Size(199, 20);
            this.tipe_textBox1.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(434, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Tipe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(432, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 26);
            this.label14.TabIndex = 30;
            this.label14.Text = "Keterangan Laptop";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 26);
            this.label15.TabIndex = 31;
            this.label15.Text = "Detail Transaksi";
            // 
            // stok_disable_textBox1
            // 
            this.stok_disable_textBox1.Location = new System.Drawing.Point(549, 353);
            this.stok_disable_textBox1.Name = "stok_disable_textBox1";
            this.stok_disable_textBox1.ReadOnly = true;
            this.stok_disable_textBox1.Size = new System.Drawing.Size(199, 20);
            this.stok_disable_textBox1.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 356);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Stok Tersedia";
            // 
            // harga_peritem_disable_textBox4
            // 
            this.harga_peritem_disable_textBox4.Location = new System.Drawing.Point(549, 379);
            this.harga_peritem_disable_textBox4.Name = "harga_peritem_disable_textBox4";
            this.harga_peritem_disable_textBox4.ReadOnly = true;
            this.harga_peritem_disable_textBox4.Size = new System.Drawing.Size(199, 20);
            this.harga_peritem_disable_textBox4.TabIndex = 37;
            // 
            // harga_satuan_per_item_label18
            // 
            this.harga_satuan_per_item_label18.AutoSize = true;
            this.harga_satuan_per_item_label18.Location = new System.Drawing.Point(434, 382);
            this.harga_satuan_per_item_label18.Name = "harga_satuan_per_item_label18";
            this.harga_satuan_per_item_label18.Size = new System.Drawing.Size(78, 13);
            this.harga_satuan_per_item_label18.TabIndex = 36;
            this.harga_satuan_per_item_label18.Text = "Harga Per Item";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "item";
            this.itemBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Tidak Jadi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1176, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.harga_peritem_disable_textBox4);
            this.Controls.Add(this.harga_satuan_per_item_label18);
            this.Controls.Add(this.stok_disable_textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ukuran_layar_textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.penyimpanan_textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ram_textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.processor_textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.deskripsi_richTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tipe_textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keterangan_label7);
            this.Controls.Add(this.keterangan_richTextBox1);
            this.Controls.Add(this.harga_total_textbox);
            this.Controls.Add(this.harga_total_label7);
            this.Controls.Add(this.harga_satuan_textBox1);
            this.Controls.Add(this.harga_satuan_label6);
            this.Controls.Add(this.qty_numericUpDown1);
            this.Controls.Add(this.qty_label5);
            this.Controls.Add(this.tanggal_transaksi_dateTimePicker1);
            this.Controls.Add(this.tanggal_transaksi_label4);
            this.Controls.Add(this.tipe_laptop_comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.merek_comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox merek_comboBox1;
        private dibumilaptopDataSet dibumilaptopDataSet;
        private System.Windows.Forms.BindingSource merekBindingSource;
        private dibumilaptopDataSetTableAdapters.merekTableAdapter merekTableAdapter;
        private System.Windows.Forms.ComboBox tipe_laptop_comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tanggal_transaksi_label4;
        private System.Windows.Forms.DateTimePicker tanggal_transaksi_dateTimePicker1;
        private System.Windows.Forms.Label qty_label5;
        private System.Windows.Forms.NumericUpDown qty_numericUpDown1;
        private System.Windows.Forms.Label harga_satuan_label6;
        private System.Windows.Forms.TextBox harga_satuan_textBox1;
        private System.Windows.Forms.TextBox harga_total_textbox;
        private System.Windows.Forms.Label harga_total_label7;
        private System.Windows.Forms.RichTextBox keterangan_richTextBox1;
        private System.Windows.Forms.Label keterangan_label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource transaksiBindingSource;
        private dibumilaptopDataSetTableAdapters.transaksiTableAdapter transaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggaltransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasatuantempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ukuran_layar_textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox penyimpanan_textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ram_textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox processor_textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox deskripsi_richTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tipe_textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox stok_disable_textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox harga_peritem_disable_textBox4;
        private System.Windows.Forms.Label harga_satuan_per_item_label18;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private dibumilaptopDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}