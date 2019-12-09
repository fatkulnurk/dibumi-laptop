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
    public partial class FormKondisi : Form
    {
        public FormKondisi()
        {
            InitializeComponent();
        }

        private void kondisiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kondisiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void FormKondisi_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            kondisiDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.kondisi' table. You can move, or remove it, as needed.
            this.kondisiTableAdapter.Fill(this.dibumilaptopDataSet.kondisi);

        }
    }
}
