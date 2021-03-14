
namespace ORS_App
{
    partial class BusinessList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.randevuSisDataSet = new ORS_App.RandevuSisDataSet();
            this.workPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workPlaceTableAdapter = new ORS_App.RandevuSisDataSetTableAdapters.workPlaceTableAdapter();
            this.isYeriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isYeriTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuSisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPlaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isYeriIDDataGridViewTextBoxColumn,
            this.isYeriAdiDataGridViewTextBoxColumn,
            this.isYeriAdresDataGridViewTextBoxColumn,
            this.isYeriTelefonDataGridViewTextBoxColumn,
            this.isYeriTuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workPlaceBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // randevuSisDataSet
            // 
            this.randevuSisDataSet.DataSetName = "RandevuSisDataSet";
            this.randevuSisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workPlaceBindingSource
            // 
            this.workPlaceBindingSource.DataMember = "workPlace";
            this.workPlaceBindingSource.DataSource = this.randevuSisDataSet;
            // 
            // workPlaceTableAdapter
            // 
            this.workPlaceTableAdapter.ClearBeforeFill = true;
            // 
            // isYeriIDDataGridViewTextBoxColumn
            // 
            this.isYeriIDDataGridViewTextBoxColumn.DataPropertyName = "isYeriID";
            this.isYeriIDDataGridViewTextBoxColumn.HeaderText = "isYeriID";
            this.isYeriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isYeriIDDataGridViewTextBoxColumn.Name = "isYeriIDDataGridViewTextBoxColumn";
            this.isYeriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.isYeriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // isYeriAdiDataGridViewTextBoxColumn
            // 
            this.isYeriAdiDataGridViewTextBoxColumn.DataPropertyName = "isYeriAdi";
            this.isYeriAdiDataGridViewTextBoxColumn.HeaderText = "isYeriAdi";
            this.isYeriAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isYeriAdiDataGridViewTextBoxColumn.Name = "isYeriAdiDataGridViewTextBoxColumn";
            this.isYeriAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // isYeriAdresDataGridViewTextBoxColumn
            // 
            this.isYeriAdresDataGridViewTextBoxColumn.DataPropertyName = "isYeriAdres";
            this.isYeriAdresDataGridViewTextBoxColumn.HeaderText = "isYeriAdres";
            this.isYeriAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isYeriAdresDataGridViewTextBoxColumn.Name = "isYeriAdresDataGridViewTextBoxColumn";
            this.isYeriAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // isYeriTelefonDataGridViewTextBoxColumn
            // 
            this.isYeriTelefonDataGridViewTextBoxColumn.DataPropertyName = "isYeriTelefon";
            this.isYeriTelefonDataGridViewTextBoxColumn.HeaderText = "isYeriTelefon";
            this.isYeriTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isYeriTelefonDataGridViewTextBoxColumn.Name = "isYeriTelefonDataGridViewTextBoxColumn";
            this.isYeriTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // isYeriTuruDataGridViewTextBoxColumn
            // 
            this.isYeriTuruDataGridViewTextBoxColumn.DataPropertyName = "isYeriTuru";
            this.isYeriTuruDataGridViewTextBoxColumn.HeaderText = "isYeriTuru";
            this.isYeriTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isYeriTuruDataGridViewTextBoxColumn.Name = "isYeriTuruDataGridViewTextBoxColumn";
            this.isYeriTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // BusinessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BusinessList";
            this.Text = "BusinessList";
            this.Load += new System.EventHandler(this.BusinessList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuSisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workPlaceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RandevuSisDataSet randevuSisDataSet;
        private System.Windows.Forms.BindingSource workPlaceBindingSource;
        private RandevuSisDataSetTableAdapters.workPlaceTableAdapter workPlaceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isYeriTuruDataGridViewTextBoxColumn;
    }
}