namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.forms
{
    partial class FormKondisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label deskripsiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKondisi));
            this.dibumilaptopDataSet = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSet();
            this.kondisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kondisiTableAdapter = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.kondisiTableAdapter();
            this.tableAdapterManager = new DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.TableAdapterManager();
            this.kondisiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kondisiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.deskripsiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.kondisiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            namaLabel = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingNavigator)).BeginInit();
            this.kondisiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(26, 54);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(36, 13);
            namaLabel.TabIndex = 1;
            namaLabel.Text = "nama:";
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(26, 80);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(51, 13);
            deskripsiLabel.TabIndex = 3;
            deskripsiLabel.Text = "deskripsi:";
            // 
            // dibumilaptopDataSet
            // 
            this.dibumilaptopDataSet.DataSetName = "dibumilaptopDataSet";
            this.dibumilaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kondisiBindingSource
            // 
            this.kondisiBindingSource.DataMember = "kondisi";
            this.kondisiBindingSource.DataSource = this.dibumilaptopDataSet;
            // 
            // kondisiTableAdapter
            // 
            this.kondisiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.garansiTableAdapter = null;
            this.tableAdapterManager.gudangTableAdapter = null;
            this.tableAdapterManager.itemTableAdapter = null;
            this.tableAdapterManager.kondisiTableAdapter = this.kondisiTableAdapter;
            this.tableAdapterManager.merekTableAdapter = null;
            this.tableAdapterManager.returnTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR.dibumilaptopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kondisiBindingNavigator
            // 
            this.kondisiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kondisiBindingNavigator.BindingSource = this.kondisiBindingSource;
            this.kondisiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kondisiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kondisiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kondisiBindingNavigatorSaveItem});
            this.kondisiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kondisiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kondisiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kondisiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kondisiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kondisiBindingNavigator.Name = "kondisiBindingNavigator";
            this.kondisiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kondisiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.kondisiBindingNavigator.TabIndex = 0;
            this.kondisiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kondisiBindingNavigatorSaveItem
            // 
            this.kondisiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kondisiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kondisiBindingNavigatorSaveItem.Image")));
            this.kondisiBindingNavigatorSaveItem.Name = "kondisiBindingNavigatorSaveItem";
            this.kondisiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kondisiBindingNavigatorSaveItem.Text = "Save Data";
            this.kondisiBindingNavigatorSaveItem.Click += new System.EventHandler(this.kondisiBindingNavigatorSaveItem_Click);
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kondisiBindingSource, "nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(83, 51);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(226, 20);
            this.namaTextBox.TabIndex = 2;
            // 
            // deskripsiRichTextBox
            // 
            this.deskripsiRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kondisiBindingSource, "deskripsi", true));
            this.deskripsiRichTextBox.Location = new System.Drawing.Point(83, 77);
            this.deskripsiRichTextBox.Name = "deskripsiRichTextBox";
            this.deskripsiRichTextBox.Size = new System.Drawing.Size(226, 96);
            this.deskripsiRichTextBox.TabIndex = 4;
            this.deskripsiRichTextBox.Text = "";
            // 
            // kondisiDataGridView
            // 
            this.kondisiDataGridView.AutoGenerateColumns = false;
            this.kondisiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kondisiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.kondisiDataGridView.DataSource = this.kondisiBindingSource;
            this.kondisiDataGridView.Location = new System.Drawing.Point(29, 230);
            this.kondisiDataGridView.Name = "kondisiDataGridView";
            this.kondisiDataGridView.Size = new System.Drawing.Size(771, 220);
            this.kondisiDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "deskripsi";
            this.dataGridViewTextBoxColumn3.HeaderText = "deskripsi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormKondisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kondisiDataGridView);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiRichTextBox);
            this.Controls.Add(this.kondisiBindingNavigator);
            this.Name = "FormKondisi";
            this.Text = "FormKondisi";
            this.Load += new System.EventHandler(this.FormKondisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dibumilaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiBindingNavigator)).EndInit();
            this.kondisiBindingNavigator.ResumeLayout(false);
            this.kondisiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kondisiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dibumilaptopDataSet dibumilaptopDataSet;
        private System.Windows.Forms.BindingSource kondisiBindingSource;
        private dibumilaptopDataSetTableAdapters.kondisiTableAdapter kondisiTableAdapter;
        private dibumilaptopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kondisiBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kondisiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.RichTextBox deskripsiRichTextBox;
        private System.Windows.Forms.DataGridView kondisiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}