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
    public partial class FormMerek : Form
    {
        public FormMerek()
        {
            InitializeComponent();
        }

        private void merekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.merekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void merekBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.merekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void FormMerek_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            merekDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.merek' table. You can move, or remove it, as needed.
            this.merekTableAdapter.Fill(this.dibumilaptopDataSet.merek);

        }
    }
}
