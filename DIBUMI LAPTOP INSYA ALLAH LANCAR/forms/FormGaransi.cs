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
    public partial class FormGaransi : Form
    {
        public FormGaransi()
        {
            InitializeComponent();
        }

        private void garansiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.garansiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dibumilaptopDataSet);

        }

        private void FormGaransi_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            garansiDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // TODO: This line of code loads data into the 'dibumilaptopDataSet.garansi' table. You can move, or remove it, as needed.
            this.garansiTableAdapter.Fill(this.dibumilaptopDataSet.garansi);

        }
    }
}
