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
    public partial class FormGudang : Form
    {
        public FormGudang()
        {
            InitializeComponent();
        }

        private void gudangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gudangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void FormGudang_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gudangDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.gudang' table. You can move, or remove it, as needed.
            this.gudangTableAdapter.Fill(this.dibumilaptopDataSet.gudang);

        }
    }
}
