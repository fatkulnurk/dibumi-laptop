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
    public partial class FormReport : Form
    {
        dibumilaptopEntities db = new dibumilaptopEntities();

        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = db.transaksis.ToList<transaksi>();
            merekLoad();
        }

        void merekLoad()
        {
            /*
            List<merek> itemMerek = db.mereks.ToList<merek>();

            merek_comboBox1.DataSource = itemMerek;
            merek_comboBox1.DisplayMember = "nama";
            merek_comboBox1.ValueMember = "id";
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var merek = merek_comboBox1.SelectedValue;
            var start_date = start_dateTimePicker1.Value;
            var finish_date = finish_dateTimePicker2.Value;

            var query = db.transaksis;

            if ((start_date != null) && (finish_date != null))
            {
                dataGridView1.DataSource = query
                    .Where(t => t.tanggal_transaksi >= start_date && t.tanggal_transaksi <= finish_date)
                    .ToList<transaksi>();
            }
            else 
            {
                MessageBox.Show("Pilih berdasarkan tangal");
            }
        }
    }
}
