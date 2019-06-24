namespace FastFoodDemo
{
    partial class UserControl7
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationmontantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocomptedestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new FastFoodDemo.bankDataSet1();
            this.bankDataSet = new FastFoodDemo.bankDataSet();
            this.banqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banqueTableAdapter = new FastFoodDemo.bankDataSetTableAdapters.banqueTableAdapter();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter = new FastFoodDemo.bankDataSetTableAdapters.operationTableAdapter();
            this.operationTableAdapter1 = new FastFoodDemo.bankDataSet1TableAdapters.operationTableAdapter();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(46, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Historique";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(-9, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 5);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationdateDataGridViewTextBoxColumn,
            this.operationtypeDataGridViewTextBoxColumn,
            this.operationmontantDataGridViewTextBoxColumn,
            this.numerocomptedestDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 205);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // operationdateDataGridViewTextBoxColumn
            // 
            this.operationdateDataGridViewTextBoxColumn.DataPropertyName = "operation_date";
            this.operationdateDataGridViewTextBoxColumn.HeaderText = "La date";
            this.operationdateDataGridViewTextBoxColumn.Name = "operationdateDataGridViewTextBoxColumn";
            // 
            // operationtypeDataGridViewTextBoxColumn
            // 
            this.operationtypeDataGridViewTextBoxColumn.DataPropertyName = "operation_type";
            this.operationtypeDataGridViewTextBoxColumn.HeaderText = " Type d\'opération";
            this.operationtypeDataGridViewTextBoxColumn.Name = "operationtypeDataGridViewTextBoxColumn";
            // 
            // operationmontantDataGridViewTextBoxColumn
            // 
            this.operationmontantDataGridViewTextBoxColumn.DataPropertyName = "operation_montant";
            this.operationmontantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.operationmontantDataGridViewTextBoxColumn.Name = "operationmontantDataGridViewTextBoxColumn";
            // 
            // numerocomptedestDataGridViewTextBoxColumn
            // 
            this.numerocomptedestDataGridViewTextBoxColumn.DataPropertyName = "numero_comptedest";
            this.numerocomptedestDataGridViewTextBoxColumn.HeaderText = "Compte bénéficiaire";
            this.numerocomptedestDataGridViewTextBoxColumn.Name = "numerocomptedestDataGridViewTextBoxColumn";
            // 
            // operationBindingSource1
            // 
            this.operationBindingSource1.DataMember = "operation";
            this.operationBindingSource1.DataSource = this.bankDataSet1;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "bankDataSet1";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banqueBindingSource
            // 
            this.banqueBindingSource.DataMember = "banque";
            this.banqueBindingSource.DataSource = this.bankDataSet;
            // 
            // banqueTableAdapter
            // 
            this.banqueTableAdapter.ClearBeforeFill = true;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "operation";
            this.operationBindingSource.DataSource = this.bankDataSet;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // operationTableAdapter1
            // 
            this.operationTableAdapter1.ClearBeforeFill = true;
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.SteelBlue;
            this.metroTile2.CustomBackground = true;
            this.metroTile2.CustomForeColor = true;
            this.metroTile2.Location = new System.Drawing.Point(187, 273);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(82, 26);
            this.metroTile2.TabIndex = 43;
            this.metroTile2.Text = "Exit";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FastFoodDemo.Properties.Resources.Credit_Card_40px;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserControl7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl7";
            this.Size = new System.Drawing.Size(501, 312);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource operationBindingSource1;
        private bankDataSet1 bankDataSet1;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource banqueBindingSource;
        private bankDataSetTableAdapters.banqueTableAdapter banqueTableAdapter;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private bankDataSetTableAdapters.operationTableAdapter operationTableAdapter;
        private bankDataSet1TableAdapters.operationTableAdapter operationTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationmontantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocomptedestDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}
