using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    public partial class FormItem : Form
    {
        item model = new item();
        public FormItem()
        {
            InitializeComponent();

        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
         
            PopulateDataGridView();
            //ItemdataGridView1.AutoResizeColumns();
            ItemdataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.garansi' table. You can move, or remove it, as needed.
            this.garansiTableAdapter.Fill(this.dibumilaptopDataSet.garansi);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.kondisi' table. You can move, or remove it, as needed.
            this.kondisiTableAdapter.Fill(this.dibumilaptopDataSet.kondisi);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.dibumilaptopDataSet.gudang);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.merek' table. You can move, or remove it, as needed.
            this.merekTableAdapter.Fill(this.dibumilaptopDataSet.merek);

        }

        void Clear()
        {
            merek_comboBox1.SelectedValue =
                jenis_garansi_comboBox4.SelectedValue =
                lokasi_gudang_comboBox2.SelectedValue =
                kondisi_comboBox3.SelectedValue = 0;

            stok_numericUpDown1.Value =
                harga_numericUpDown1.Value = 0;

            tipe_textBox1.Text =
                deskripsi_richTextBox1.Text =
                processor_textBox2.Text =
                ram_textBox3.Text =
                penyimpanan_textBox4.Text =
                ukuran_layar_textBox5.Text = "";

            delete_button1.Enabled = false;
            PopulateDataGridView();
        }

        private void simpan_button1_Click(object sender, EventArgs e)
        {
            model.merek_id = Convert.ToInt64(merek_comboBox1.SelectedValue);
            model.tipe = tipe_textBox1.Text;
            model.deskripsi = deskripsi_richTextBox1.Text;
            model.processor = processor_textBox2.Text;
            model.ram = ram_textBox3.Text;
            model.penyimpanan = penyimpanan_textBox4.Text;
            model.ukuran_layar = ukuran_layar_textBox5.Text;
            model.stok = Convert.ToInt32(stok_numericUpDown1.Value);
            model.gudang_id = Convert.ToInt64(lokasi_gudang_comboBox2.SelectedValue);
            model.kondisi_id = Convert.ToInt64(kondisi_comboBox3.SelectedValue);
            model.tanggal_ditambahkan = tanggal_ditambahkan_dateTimePicker1.Value;
            model.garansi_id = Convert.ToInt64(jenis_garansi_comboBox4.SelectedValue);
            model.garansi_expired = garansi_expired_dateTimePicker2.Value;
            model.harga = Convert.ToInt64(harga_numericUpDown1.Value);

           using(dibumilaptopEntities db = new dibumilaptopEntities())
            {
                if(model.id == 0)
                {
                    db.items.Add(model);

                    MessageBox.Show("Data berhasil ditambahkan");
                } else
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;

                    MessageBox.Show("Data berhasil diupdate");
                }
                db.SaveChanges();
            }
            Clear(); 
            PopulateDataGridView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            using(dibumilaptopEntities db = new dibumilaptopEntities())
            {
                ItemdataGridView1.DataSource = db.items.ToList<item>();
            }
        }


        private void ItemdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Anda yakin ingin menghapus data ini?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(dibumilaptopEntities db = new dibumilaptopEntities())
                {
                    var entry = db.Entry(model);
                    if(entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.items.Attach(model);
                    }

                    db.items.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Berhasil Menghapus.");
                }
            }
        }

        private void ItemdataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(ItemdataGridView1.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(ItemdataGridView1.CurrentRow.Cells["id"].Value);
                using(dibumilaptopEntities db = new dibumilaptopEntities())
                {
                    model = db.items.Where(x => x.id == model.id).FirstOrDefault();
                    
                    merek_comboBox1.SelectedValue = model.merek_id;
                    jenis_garansi_comboBox4.SelectedValue = model.garansi_id;
                    lokasi_gudang_comboBox2.SelectedValue = model.gudang_id;
                    kondisi_comboBox3.SelectedValue = model.kondisi_id;

                    stok_numericUpDown1.Value = Convert.ToInt32(model.stok);
                    harga_numericUpDown1.Value = Convert.ToInt32(model.harga);

                    tipe_textBox1.Text = model.tipe;
                    deskripsi_richTextBox1.Text = model.deskripsi;
                    processor_textBox2.Text = model.processor;
                    ram_textBox3.Text = model.ram;
                    penyimpanan_textBox4.Text = model.penyimpanan;
                    ukuran_layar_textBox5.Text = model.ukuran_layar;

                }

                simpan_button1.Text = "Update";
                delete_button1.Enabled = true;
            }
        }
    }
}
