namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    partial class FormStokBarang
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
            this.stok_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.simpan_button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ukuran_layar_textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.penyimpanan_textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ram_textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.processor_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deskripsi_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.merek_comboBox1 = new System.Windows.Forms.ComboBox();
            this.merekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dibumilaptopDataSet = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tipe_comboBox1 = new System.Windows.Forms.ComboBox();
            this.tambah_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.tambah_stok_textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.garansi_expired_textBox2 = new System.Windows.Forms.TextBox();
            this.tanggal_ditambahkan_textBox3 = new System.Windows.Forms.TextBox();
            this.harga_textBox4 = new System.Windows.Forms.TextBox();
            this.merekTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.merekTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stok_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambah_numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "STOK BARANG";
            // 
            // stok_numericUpDown1
            // 
            this.stok_numericUpDown1.Location = new System.Drawing.Point(151, 248);
            this.stok_numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stok_numericUpDown1.Name = "stok_numericUpDown1";
            this.stok_numericUpDown1.ReadOnly = true;
            this.stok_numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.stok_numericUpDown1.TabIndex = 114;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(432, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 37);
            this.button2.TabIndex = 113;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // simpan_button1
            // 
            this.simpan_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_button1.Location = new System.Drawing.Point(39, 372);
            this.simpan_button1.Name = "simpan_button1";
            this.simpan_button1.Size = new System.Drawing.Size(311, 37);
            this.simpan_button1.TabIndex = 111;
            this.simpan_button1.Text = "SIMPAN DATA";
            this.simpan_button1.UseVisualStyleBackColor = true;
            this.simpan_button1.Click += new System.EventHandler(this.simpan_button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 110;
            this.label14.Text = "Harga";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = "Garansi Expired";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(426, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Tanggal Ditambahkan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Jumlah Stok Sekarang";
            // 
            // ukuran_layar_textBox5
            // 
            this.ukuran_layar_textBox5.Location = new System.Drawing.Point(544, 155);
            this.ukuran_layar_textBox5.Name = "ukuran_layar_textBox5";
            this.ukuran_layar_textBox5.ReadOnly = true;
            this.ukuran_layar_textBox5.Size = new System.Drawing.Size(199, 20);
            this.ukuran_layar_textBox5.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Ukuran Layar";
            // 
            // penyimpanan_textBox4
            // 
            this.penyimpanan_textBox4.Location = new System.Drawing.Point(544, 129);
            this.penyimpanan_textBox4.Name = "penyimpanan_textBox4";
            this.penyimpanan_textBox4.ReadOnly = true;
            this.penyimpanan_textBox4.Size = new System.Drawing.Size(199, 20);
            this.penyimpanan_textBox4.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Penyimpanan";
            // 
            // ram_textBox3
            // 
            this.ram_textBox3.Location = new System.Drawing.Point(544, 99);
            this.ram_textBox3.Name = "ram_textBox3";
            this.ram_textBox3.ReadOnly = true;
            this.ram_textBox3.Size = new System.Drawing.Size(199, 20);
            this.ram_textBox3.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "Ram";
            // 
            // processor_textBox2
            // 
            this.processor_textBox2.Location = new System.Drawing.Point(544, 73);
            this.processor_textBox2.Name = "processor_textBox2";
            this.processor_textBox2.ReadOnly = true;
            this.processor_textBox2.Size = new System.Drawing.Size(199, 20);
            this.processor_textBox2.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Processor";
            // 
            // deskripsi_richTextBox1
            // 
            this.deskripsi_richTextBox1.Location = new System.Drawing.Point(151, 139);
            this.deskripsi_richTextBox1.Name = "deskripsi_richTextBox1";
            this.deskripsi_richTextBox1.ReadOnly = true;
            this.deskripsi_richTextBox1.Size = new System.Drawing.Size(199, 96);
            this.deskripsi_richTextBox1.TabIndex = 90;
            this.deskripsi_richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Deskripsi";
            // 
            // merek_comboBox1
            // 
            this.merek_comboBox1.DataSource = this.merekBindingSource;
            this.merek_comboBox1.DisplayMember = "nama";
            this.merek_comboBox1.FormattingEnabled = true;
            this.merek_comboBox1.Location = new System.Drawing.Point(151, 75);
            this.merek_comboBox1.Name = "merek_comboBox1";
            this.merek_comboBox1.Size = new System.Drawing.Size(199, 21);
            this.merek_comboBox1.TabIndex = 87;
            this.merek_comboBox1.ValueMember = "id";
            this.merek_comboBox1.SelectionChangeCommitted += new System.EventHandler(this.merek_comboBox1_SelectionChangeCommitted);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tipe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 85;
            this.label15.Text = "Merek";
            // 
            // tipe_comboBox1
            // 
            this.tipe_comboBox1.FormattingEnabled = true;
            this.tipe_comboBox1.Location = new System.Drawing.Point(151, 105);
            this.tipe_comboBox1.Name = "tipe_comboBox1";
            this.tipe_comboBox1.Size = new System.Drawing.Size(199, 21);
            this.tipe_comboBox1.TabIndex = 116;
            this.tipe_comboBox1.SelectionChangeCommitted += new System.EventHandler(this.tipe_comboBox1_SelectionChangeCommitted);
            // 
            // tambah_numericUpDown1
            // 
            this.tambah_numericUpDown1.Location = new System.Drawing.Point(151, 274);
            this.tambah_numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tambah_numericUpDown1.Name = "tambah_numericUpDown1";
            this.tambah_numericUpDown1.Size = new System.Drawing.Size(199, 20);
            this.tambah_numericUpDown1.TabIndex = 118;
            this.tambah_numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 117;
            this.label16.Text = "Tambah Stok Sejumlah";
            // 
            // tambah_stok_textBox1
            // 
            this.tambah_stok_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah_stok_textBox1.Location = new System.Drawing.Point(40, 324);
            this.tambah_stok_textBox1.Name = "tambah_stok_textBox1";
            this.tambah_stok_textBox1.Size = new System.Drawing.Size(310, 26);
            this.tambah_stok_textBox1.TabIndex = 119;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 301);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 120;
            this.label17.Text = "Stok Menjadi";
            // 
            // garansi_expired_textBox2
            // 
            this.garansi_expired_textBox2.Location = new System.Drawing.Point(544, 218);
            this.garansi_expired_textBox2.Name = "garansi_expired_textBox2";
            this.garansi_expired_textBox2.ReadOnly = true;
            this.garansi_expired_textBox2.Size = new System.Drawing.Size(199, 20);
            this.garansi_expired_textBox2.TabIndex = 121;
            // 
            // tanggal_ditambahkan_textBox3
            // 
            this.tanggal_ditambahkan_textBox3.Location = new System.Drawing.Point(544, 186);
            this.tanggal_ditambahkan_textBox3.Name = "tanggal_ditambahkan_textBox3";
            this.tanggal_ditambahkan_textBox3.ReadOnly = true;
            this.tanggal_ditambahkan_textBox3.Size = new System.Drawing.Size(199, 20);
            this.tanggal_ditambahkan_textBox3.TabIndex = 122;
            // 
            // harga_textBox4
            // 
            this.harga_textBox4.Location = new System.Drawing.Point(544, 249);
            this.harga_textBox4.Name = "harga_textBox4";
            this.harga_textBox4.ReadOnly = true;
            this.harga_textBox4.Size = new System.Drawing.Size(199, 20);
            this.harga_textBox4.TabIndex = 123;
            // 
            // merekTableAdapter
            // 
            this.merekTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(789, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 321);
            this.dataGridView1.TabIndex = 124;
            // 
            // FormStokBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.harga_textBox4);
            this.Controls.Add(this.tanggal_ditambahkan_textBox3);
            this.Controls.Add(this.garansi_expired_textBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tambah_stok_textBox1);
            this.Controls.Add(this.tambah_numericUpDown1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tipe_comboBox1);
            this.Controls.Add(this.stok_numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.simpan_button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.merek_comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Name = "FormStokBarang";
            this.Text = "FormStokBarang";
            this.Load += new System.EventHandler(this.FormStokBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stok_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambah_numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stok_numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button simpan_button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ukuran_layar_textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox penyimpanan_textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ram_textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox processor_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox deskripsi_richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox merek_comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox tipe_comboBox1;
        private System.Windows.Forms.NumericUpDown tambah_numericUpDown1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tambah_stok_textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox garansi_expired_textBox2;
        private System.Windows.Forms.TextBox tanggal_ditambahkan_textBox3;
        private System.Windows.Forms.TextBox harga_textBox4;
        private dibumilaptopDataSet dibumilaptopDataSet;
        private System.Windows.Forms.BindingSource merekBindingSource;
        private dibumilaptopDataSetTableAdapters.merekTableAdapter merekTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}