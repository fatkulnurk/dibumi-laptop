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
    public partial class FormBarangItem : Form
    {
        public FormBarangItem()
        {
            InitializeComponent();
        }

        private void itemBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void FormBarangItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.garansi' table. You can move, or remove it, as needed.
            this.garansiTableAdapter.Fill(this.dibumilaptopDataSet.garansi);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.kondisi' table. You can move, or remove it, as needed.
            this.kondisiTableAdapter.Fill(this.dibumilaptopDataSet.kondisi);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.dibumilaptopDataSet.gudang);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.merek' table. You can move, or remove it, as needed.
            this.merekTableAdapter.Fill(this.dibumilaptopDataSet.merek);
            // TODO: This line of code loads data into the 'dibumilaptopDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dibumilaptopDataSet.item);

        }

        private void gudang_idComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
