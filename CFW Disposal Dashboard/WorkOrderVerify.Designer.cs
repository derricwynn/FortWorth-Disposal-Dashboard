namespace CFW_Disposal_Dashboard
{
    partial class WorkOrderVerify
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disposalDashboardDatabaseDataSet3 = new CFW_Disposal_Dashboard.DisposalDashboardDatabaseDataSet3();
            this.workOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workOrderTableAdapter = new CFW_Disposal_Dashboard.DisposalDashboardDatabaseDataSet3TableAdapters.WorkOrderTableAdapter();
            this.workOrderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manifestNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalDashboardDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(962, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workOrderIdDataGridViewTextBoxColumn,
            this.manifestNumberDataGridViewTextBoxColumn,
            this.contractorDataGridViewTextBoxColumn,
            this.dOSDataGridViewTextBoxColumn,
            this.pickUpDateDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.workOrderStatusDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(930, 403);
            this.dataGridView1.TabIndex = 2;
            // 
            // disposalDashboardDatabaseDataSet3
            // 
            this.disposalDashboardDatabaseDataSet3.DataSetName = "DisposalDashboardDatabaseDataSet3";
            this.disposalDashboardDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workOrderBindingSource
            // 
            this.workOrderBindingSource.DataMember = "WorkOrder";
            this.workOrderBindingSource.DataSource = this.disposalDashboardDatabaseDataSet3;
            // 
            // workOrderTableAdapter
            // 
            this.workOrderTableAdapter.ClearBeforeFill = true;
            // 
            // workOrderIdDataGridViewTextBoxColumn
            // 
            this.workOrderIdDataGridViewTextBoxColumn.DataPropertyName = "WorkOrderId";
            this.workOrderIdDataGridViewTextBoxColumn.HeaderText = "WorkOrderId";
            this.workOrderIdDataGridViewTextBoxColumn.Name = "workOrderIdDataGridViewTextBoxColumn";
            this.workOrderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manifestNumberDataGridViewTextBoxColumn
            // 
            this.manifestNumberDataGridViewTextBoxColumn.DataPropertyName = "ManifestNumber";
            this.manifestNumberDataGridViewTextBoxColumn.HeaderText = "ManifestNumber";
            this.manifestNumberDataGridViewTextBoxColumn.Name = "manifestNumberDataGridViewTextBoxColumn";
            // 
            // contractorDataGridViewTextBoxColumn
            // 
            this.contractorDataGridViewTextBoxColumn.DataPropertyName = "Contractor";
            this.contractorDataGridViewTextBoxColumn.HeaderText = "Contractor";
            this.contractorDataGridViewTextBoxColumn.Name = "contractorDataGridViewTextBoxColumn";
            // 
            // dOSDataGridViewTextBoxColumn
            // 
            this.dOSDataGridViewTextBoxColumn.DataPropertyName = "DOS";
            this.dOSDataGridViewTextBoxColumn.HeaderText = "DOS";
            this.dOSDataGridViewTextBoxColumn.Name = "dOSDataGridViewTextBoxColumn";
            // 
            // pickUpDateDataGridViewTextBoxColumn
            // 
            this.pickUpDateDataGridViewTextBoxColumn.DataPropertyName = "PickUpDate";
            this.pickUpDateDataGridViewTextBoxColumn.HeaderText = "PickUpDate";
            this.pickUpDateDataGridViewTextBoxColumn.Name = "pickUpDateDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // workOrderStatusDataGridViewTextBoxColumn
            // 
            this.workOrderStatusDataGridViewTextBoxColumn.DataPropertyName = "WorkOrderStatus";
            this.workOrderStatusDataGridViewTextBoxColumn.HeaderText = "WorkOrderStatus";
            this.workOrderStatusDataGridViewTextBoxColumn.Name = "workOrderStatusDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // WorkOrderVerify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "WorkOrderVerify";
            this.Text = "WorkOrderVerify";
            this.Load += new System.EventHandler(this.WorkOrderVerify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalDashboardDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DisposalDashboardDatabaseDataSet3 disposalDashboardDatabaseDataSet3;
        private System.Windows.Forms.BindingSource workOrderBindingSource;
        private DisposalDashboardDatabaseDataSet3TableAdapters.WorkOrderTableAdapter workOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manifestNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickUpDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
    }
}