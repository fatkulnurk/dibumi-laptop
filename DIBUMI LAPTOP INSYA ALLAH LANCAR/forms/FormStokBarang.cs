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
    public partial class FormStokBarang : Form
    {
        item modelItem = new item();
        merek modelMerek = new merek();
        
        dibumilaptopEntities db = new dibumilaptopEntities();

        public FormStokBarang()
        {
            InitializeComponent();
        }

        private void FormStokBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.merek' table. You can move, or remove it, as needed.
            this.merekTableAdapter.Fill(this.dibumilaptopDataSet.merek);
            WindowState = FormWindowState.Maximized;

            PopulateDataGridView();
        }

        private void simpan_button1_Click(object sender, EventArgs e)
        {
            modelItem.stok = Convert.ToInt32(tambah_numericUpDown1.Value);
            db.Entry(modelItem).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Stok berhasil ditambahkan sejumlah " + tambah_numericUpDown1.Value + " menjadi " + modelItem.stok);
            Clear();

            PopulateDataGridView();
        }

        private void merek_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            modelMerek.id = Convert.ToInt32(merek_comboBox1.SelectedValue);
            List<item> itemsData = db.items.Where(x => x.merek_id == modelMerek.id).ToList();

            // https://stackoverflow.com/questions/600869/how-to-bind-a-list-to-a-combobox
            tipe_comboBox1.DataSource = itemsData;
            tipe_comboBox1.DisplayMember = "tipe";
            tipe_comboBox1.ValueMember = "id";

        }

        private void tipe_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

            modelItem.id = Convert.ToInt64(tipe_comboBox1.SelectedValue);
            modelItem = db.items.Where(x => x.id == modelItem.id).FirstOrDefault();
            issetData();
        }

        private void issetData()
        {
            deskripsi_richTextBox1.Text = modelItem.deskripsi;
            stok_numericUpDown1.Value = Convert.ToInt32(modelItem.stok);
            processor_textBox2.Text = modelItem.processor.ToString();
            ram_textBox3.Text = modelItem.ram.ToString();
            penyimpanan_textBox4.Text = modelItem.penyimpanan.ToString();
            ukuran_layar_textBox5.Text = modelItem.ukuran_layar.ToString();
            tanggal_ditambahkan_textBox3.Text = modelItem.tanggal_ditambahkan.ToString();
            garansi_expired_textBox2.Text = modelItem.garansi_expired.ToString();
            harga_textBox4.Text = modelItem.harga.ToString();
        }

        private void Clear()
        {
            deskripsi_richTextBox1.Text = "";
            stok_numericUpDown1.Value = 0;
            processor_textBox2.Text = "";
            ram_textBox3.Text = "";
            penyimpanan_textBox4.Text = "";
            ukuran_layar_textBox5.Text = "";
            tanggal_ditambahkan_textBox3.Text = "";
            garansi_expired_textBox2.Text = "";
            harga_textBox4.Text = "";

            tambah_numericUpDown1.Value = 0;
            tambah_stok_textBox1.Text = "";

        }

        void PopulateDataGridView()
        {
            using (dibumilaptopEntities db = new dibumilaptopEntities())
            {
               dataGridView1.DataSource = db.items
                    .Select(x => new { x.id, x.tipe, x.stok })
                    .ToList();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tambah_stok_textBox1.Text = Convert.ToString((modelItem.stok + tambah_numericUpDown1.Value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
    }
}
