using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms;

namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gudangForm = new FormGudang();
            gudangForm.MdiParent = this;
            gudangForm.Show();
        }

        private void merekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var merekForm = new FormMerek();
            merekForm.MdiParent = this;
            merekForm.Show();
        }

        private void kondisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kondisiForm = new FormKondisi();
            kondisiForm.MdiParent = this;
            kondisiForm.Show();
        }

        private void garansiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var garansiForm = new FormGaransi();
            garansiForm.MdiParent = this;
            garansiForm.Show();
        }

        private void tambahBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemForm = new FormItem();
            //var itemForm = new FormBarangItem();
            itemForm.MdiParent = this;
            itemForm.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tambahTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tambahTransaksiForm = new FormTransaksi();
            tambahTransaksiForm.MdiParent = this;
            tambahTransaksiForm.Show();
        }

        private void pengajuanReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pengajuanReturnForm = new FormPengajuanReturn();
            pengajuanReturnForm.MdiParent = this;
            pengajuanReturnForm.Show();
        }

        private void stokBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stokBarangForm = new FormStokBarang();
            stokBarangForm.MdiParent = this;
            stokBarangForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportForm = new FormReport();
            reportForm.MdiParent = this;
            reportForm.Show();
        }

        private void bantuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kamu bingung? sama saya juga, coba hubungi rudi@dibumi.com biar sama sama bingung.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
