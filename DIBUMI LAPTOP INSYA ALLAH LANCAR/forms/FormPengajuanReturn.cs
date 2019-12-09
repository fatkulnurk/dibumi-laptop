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
    public partial class FormPengajuanReturn : Form
    {
        item modelItem = new item();
        transaksi modelTransaksi = new transaksi();
        @return modelReturn = new @return();

        dibumilaptopEntities db = new dibumilaptopEntities();
               
        public FormPengajuanReturn()
        {
            InitializeComponent();
        }


        private void FormPengajuanReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dibumilaptopDataSet._return' table. You can move, or remove it, as needed.
            this.returnTableAdapter.Fill(this.dibumilaptopDataSet._return);
            WindowState = FormWindowState.Maximized;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            list_transaksi();

            status_return_comboBox1.Items.Add("Pending");
            status_return_comboBox1.Items.Add("Disetujui");

            PopulateDataGridView();
        }

        private void list_transaksi()
        {
            List<transaksi> transaksiData = db.transaksis.ToList();

            transaksi_comboBox1.DataSource = transaksiData;
            transaksi_comboBox1.DisplayMember = "id";
            transaksi_comboBox1.ValueMember = "id";

        }

        private void PopulateDataGridView()
        {
            dataGridView1.DataSource = db.returns.ToList<@return>();
        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            modelReturn.transaksi_id = modelTransaksi.id;
            modelReturn.item_id = modelItem.id;
            modelReturn.tanggal_return = tanggal_return_dateTimePicker1.Value;
            modelReturn.status_return = status_return_comboBox1.Text;
            modelReturn.keterangan = keterangan_inputan_richTextBox2.Text;
            modelReturn.alasan_return = alasan_return_richTextBox3.Text;
            modelReturn.qty = Convert.ToInt32(qty_numericUpDown1.Value);
            modelReturn.harga_satuan_temp = modelTransaksi.harga_satuan_temp;
            modelReturn.total_harga = modelTransaksi.total_harga;
            modelReturn.total_bayar_return = Convert.ToInt32(harga_total_inputan_textBox5.Text);

            db.returns.Add(modelReturn);
            db.SaveChanges();
            Clear();
            MessageBox.Show("Data Berhasil Ditambahkan.");

            PopulateDataGridView();
        }

        private void issetData()
        {
            // form keterangan
            item_id_textBox6.Text = modelItem.id.ToString();
            tipe_textBox1.Text = modelItem.tipe.ToString();
            deskripsi_richTextBox1.Text = modelItem.deskripsi.ToString();
            processor_textBox2.Text = modelItem.processor;
            ram_textBox3.Text = modelItem.ram;
            penyimpanan_textBox4.Text = modelItem.penyimpanan;
            ukuran_layar_textBox5.Text = modelItem.ukuran_layar;
            //stok_textBox1.Text = modelItem.stok.ToString();
            stok_textBox1.Text = modelItem.stok.ToString();
            harga_peritem_textBox4.Text = modelItem.harga.ToString();
            qty_max_textBox1.Text = "Maksimal " + modelTransaksi.qty + " item";

            harga_satuan_textBox1.Text = modelTransaksi.harga_satuan_temp.ToString();
            harga_total_pembelian_inputan_textBox2.Text = modelTransaksi.total_harga.ToString();

        }

        private void Clear()
        {
            // form keterangan
            item_id_textBox6.Text = "";
            tipe_textBox1.Text = "";
            deskripsi_richTextBox1.Text = "";
            processor_textBox2.Text = "";
            ram_textBox3.Text = "";
            penyimpanan_textBox4.Text = "";
            ukuran_layar_textBox5.Text = "";
            stok_textBox1.Text = "";
            harga_peritem_textBox4.Text = "";
            qty_max_textBox1.Text = "";

            harga_satuan_textBox1.Text = "";
            harga_total_pembelian_inputan_textBox2.Text = "";

        }

        private void transaksi_comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void transaksi_comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var modelTransaksiLokal = new transaksi();
            //MessageBox.Show(transaksi_comboBox1.SelectedValue.ToString());
            modelTransaksiLokal.id = Convert.ToInt32(transaksi_comboBox1.SelectedValue);
            modelTransaksiLokal = db.transaksis.Where(x => x.id == modelTransaksiLokal.id).FirstOrDefault();
            modelItem = db.items.Where(x => x.id == modelTransaksiLokal.item_id).FirstOrDefault();
            modelTransaksi = modelTransaksiLokal;
            issetData();
        }

        private void qty_numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(qty_numericUpDown1.Value > modelTransaksi.qty)
            {
                MessageBox.Show("Jumlah yang anda inputkan melebihi batas maksimum.");
                qty_numericUpDown1.Value = 0;
            }
        }
    }
}
