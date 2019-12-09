using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.ext;

namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    public partial class FormTransaksi : Form
    {
        item modelItem = new item();
        merek modelMerek = new merek();
        transaksi modelTransaksi = new transaksi();

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dibumilaptopDataSet.item);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.dibumilaptopDataSet.transaksi);
            WindowState = FormWindowState.Maximized;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.merek' table. You can move, or remove it, as needed.
            this.merekTableAdapter.Fill(this.dibumilaptopDataSet.merek);

        }
        void PopulateDataGridView()
        {
            using (dibumilaptopEntities db = new dibumilaptopEntities())
            {
                dataGridView1.DataSource = db.transaksis.ToList<transaksi>();
            }
        }
        void Clear()
        {
            //merek_comboBox1.SelectedIndex = 0;
            //tipe_laptop_comboBox1.SelectedItem = "";
            tanggal_transaksi_dateTimePicker1.Value = DateTime.Now;
            qty_numericUpDown1.Value = 0;
            harga_satuan_textBox1.Text = "";
            harga_total_textbox.Text = "";
            keterangan_richTextBox1.Text = "";

            // kolom info barang
            stok_disable_textBox1.Text = "";
            harga_peritem_disable_textBox4.Text = "";
            tipe_textBox1.Text = "";
            deskripsi_richTextBox1.Text = "";
            processor_textBox2.Text = "";
            ram_textBox3.Text = "";
            penyimpanan_textBox4.Text = "";
            ukuran_layar_textBox5.Text = "";

            PopulateDataGridView();
        }

        private void merek_comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(merek_comboBox1.SelectedValue));
        }

        private void merek_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            // MessageBox.Show(Convert.ToString(merek_comboBox1.SelectedValue));
            modelMerek.id = Convert.ToInt32(merek_comboBox1.SelectedValue);
            // tipe_laptop_comboBox1.Items.Clear();
            using (dibumilaptopEntities db = new dibumilaptopEntities())
            {
                List<item> itemsData = db.items.Where(x => x.merek_id == modelMerek.id).ToList();

                // https://stackoverflow.com/questions/600869/how-to-bind-a-list-to-a-combobox
                tipe_laptop_comboBox1.DataSource = itemsData;
                tipe_laptop_comboBox1.DisplayMember = "tipe";
                tipe_laptop_comboBox1.ValueMember = "id";

                /*
                ClassComboboxItem cbItem = new ClassComboboxItem();
                cbItem.Text = "tes";
                cbItem.Value = 1;
                tipe_laptop_comboBox1.Items.Add(cbItem);

                foreach (item data in itemsData)
                    {
                        cbItem.Text = data.tipe;
                        cbItem.Value = data.id;
                        tipe_laptop_comboBox1.Items.Add(cbItem);
                    }
                */
            }
        }

        private void tipe_laptop_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modelItem.id = Convert.ToInt64(tipe_laptop_comboBox1.SelectedValue);

            using (dibumilaptopEntities db = new dibumilaptopEntities())
            {
                modelItem = db.items.Where(x => x.id == modelItem.id).FirstOrDefault();

                //merek_comboBox1.SelectedValue = modelItem.merek_id;

                stok_disable_textBox1.Text = Convert.ToString(modelItem.stok);
                harga_peritem_disable_textBox4.Text = Convert.ToString(modelItem.harga);

                tipe_textBox1.Text = modelItem.tipe;
                deskripsi_richTextBox1.Text = modelItem.deskripsi;
                processor_textBox2.Text = modelItem.processor;
                ram_textBox3.Text = modelItem.ram;
                penyimpanan_textBox4.Text = modelItem.penyimpanan;
                ukuran_layar_textBox5.Text = modelItem.ukuran_layar;

            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void qty_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (qty_numericUpDown1.Value > modelItem.stok)
            {
                MessageBox.Show("Jumlah yang anda masukan salah.");
                qty_numericUpDown1.Value = 0;
            }

            harga_satuan_textBox1.Text = Convert.ToString(modelItem.harga);
            var tempQty = (Int32) qty_numericUpDown1.Value;
            harga_total_textbox.Text = Convert.ToString(tempQty * modelItem.harga);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelTransaksi.item_id = modelItem.id;
            modelTransaksi.tanggal_transaksi = tanggal_transaksi_dateTimePicker1.Value;
            modelTransaksi.qty = Convert.ToInt32(qty_numericUpDown1.Value);
            modelTransaksi.harga_satuan_temp = Convert.ToInt32(harga_satuan_textBox1.Text);
            modelTransaksi.total_harga = Convert.ToInt32(harga_total_textbox.Text);
            modelTransaksi.deskripsi = keterangan_richTextBox1.Text;

            using(dibumilaptopEntities db = new dibumilaptopEntities())
            {
                db.transaksis.Add(modelTransaksi);

                modelItem.stok = modelItem.stok - modelTransaksi.qty;
                db.Entry(modelItem).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
                MessageBox.Show("Transaksi Berhasil Ditambahkan");

                Clear();
            }
        }
    }
}
