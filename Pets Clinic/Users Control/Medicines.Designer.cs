namespace Pets_Clinic.Users_Control
{
    partial class Medicines
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicines));
            this.mupdate = new System.Windows.Forms.Button();
            this.minsert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mp = new System.Windows.Forms.TextBox();
            this.mlp = new System.Windows.Forms.Label();
            this.mbtn = new System.Windows.Forms.Button();
            this.mlts = new System.Windows.Forms.Label();
            this.mts = new System.Windows.Forms.TextBox();
            this.ms = new System.Windows.Forms.TextBox();
            this.mls = new System.Windows.Forms.Label();
            this.mq = new System.Windows.Forms.TextBox();
            this.mlq = new System.Windows.Forms.Label();
            this.mn = new System.Windows.Forms.ComboBox();
            this.mln = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pets_ClinicDataSet = new Pets_Clinic.Pets_ClinicDataSet();
            this.mDCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDCNTableAdapter = new Pets_Clinic.Pets_ClinicDataSetTableAdapters.MDCNTableAdapter();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_ClinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDCNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mupdate
            // 
            this.mupdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mupdate.BackColor = System.Drawing.Color.Teal;
            this.mupdate.FlatAppearance.BorderSize = 0;
            this.mupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.mupdate.ForeColor = System.Drawing.Color.Black;
            this.mupdate.Image = ((System.Drawing.Image)(resources.GetObject("mupdate.Image")));
            this.mupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mupdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mupdate.Location = new System.Drawing.Point(621, 0);
            this.mupdate.Name = "mupdate";
            this.mupdate.Size = new System.Drawing.Size(178, 30);
            this.mupdate.TabIndex = 2;
            this.mupdate.Text = "Search / Update";
            this.mupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mupdate.UseVisualStyleBackColor = false;
            this.mupdate.Click += new System.EventHandler(this.mupdate_Click);
            // 
            // minsert
            // 
            this.minsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.minsert.BackColor = System.Drawing.Color.SeaGreen;
            this.minsert.FlatAppearance.BorderSize = 0;
            this.minsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minsert.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.minsert.ForeColor = System.Drawing.Color.Black;
            this.minsert.Image = ((System.Drawing.Image)(resources.GetObject("minsert.Image")));
            this.minsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minsert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minsert.Location = new System.Drawing.Point(219, 0);
            this.minsert.Name = "minsert";
            this.minsert.Size = new System.Drawing.Size(158, 30);
            this.minsert.TabIndex = 1;
            this.minsert.Text = "Insert New Rec";
            this.minsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minsert.UseVisualStyleBackColor = false;
            this.minsert.Click += new System.EventHandler(this.sinsert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.mp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlp, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mbtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.mlts, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mts, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ms, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mls, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mq, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlq, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mln, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Visible = false;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mp
            // 
            this.mp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mp.Location = new System.Drawing.Point(204, 147);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(195, 24);
            this.mp.TabIndex = 5;
            // 
            // mlp
            // 
            this.mlp.AutoSize = true;
            this.mlp.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlp.ForeColor = System.Drawing.Color.Black;
            this.mlp.Location = new System.Drawing.Point(3, 144);
            this.mlp.Name = "mlp";
            this.mlp.Size = new System.Drawing.Size(46, 72);
            this.mlp.TabIndex = 17;
            this.mlp.Text = "Price:";
            // 
            // mbtn
            // 
            this.mbtn.BackColor = System.Drawing.Color.SpringGreen;
            this.mbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.mbtn.FlatAppearance.BorderSize = 0;
            this.mbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.mbtn.ForeColor = System.Drawing.Color.Black;
            this.mbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mbtn.Location = new System.Drawing.Point(714, 147);
            this.mbtn.MaximumSize = new System.Drawing.Size(80, 31);
            this.mbtn.MinimumSize = new System.Drawing.Size(88, 31);
            this.mbtn.Name = "mbtn";
            this.mbtn.Size = new System.Drawing.Size(88, 31);
            this.mbtn.TabIndex = 8;
            this.mbtn.Text = "Save";
            this.mbtn.UseVisualStyleBackColor = false;
            this.mbtn.Click += new System.EventHandler(this.mbtn_Click);
            // 
            // mlts
            // 
            this.mlts.AutoSize = true;
            this.mlts.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlts.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlts.ForeColor = System.Drawing.Color.Black;
            this.mlts.Location = new System.Drawing.Point(405, 72);
            this.mlts.Name = "mlts";
            this.mlts.Size = new System.Drawing.Size(195, 72);
            this.mlts.TabIndex = 10;
            this.mlts.Text = "Telephone Number Source:";
            // 
            // mts
            // 
            this.mts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mts.Location = new System.Drawing.Point(606, 75);
            this.mts.Name = "mts";
            this.mts.Size = new System.Drawing.Size(196, 24);
            this.mts.TabIndex = 7;
            // 
            // ms
            // 
            this.ms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ms.Location = new System.Drawing.Point(204, 75);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(195, 24);
            this.ms.TabIndex = 4;
            // 
            // mls
            // 
            this.mls.AutoSize = true;
            this.mls.Dock = System.Windows.Forms.DockStyle.Left;
            this.mls.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mls.ForeColor = System.Drawing.Color.Black;
            this.mls.Location = new System.Drawing.Point(3, 72);
            this.mls.Name = "mls";
            this.mls.Size = new System.Drawing.Size(60, 72);
            this.mls.TabIndex = 8;
            this.mls.Text = "Source:";
            // 
            // mq
            // 
            this.mq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mq.Location = new System.Drawing.Point(606, 3);
            this.mq.Name = "mq";
            this.mq.Size = new System.Drawing.Size(196, 24);
            this.mq.TabIndex = 6;
            // 
            // mlq
            // 
            this.mlq.AutoSize = true;
            this.mlq.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlq.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlq.ForeColor = System.Drawing.Color.Black;
            this.mlq.Location = new System.Drawing.Point(405, 0);
            this.mlq.Name = "mlq";
            this.mlq.Size = new System.Drawing.Size(79, 72);
            this.mlq.TabIndex = 6;
            this.mlq.Text = "Quantitty:";
            // 
            // mn
            // 
            this.mn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mn.FormattingEnabled = true;
            this.mn.Location = new System.Drawing.Point(204, 3);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(195, 24);
            this.mn.TabIndex = 3;
            // 
            // mln
            // 
            this.mln.AutoSize = true;
            this.mln.Dock = System.Windows.Forms.DockStyle.Left;
            this.mln.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mln.ForeColor = System.Drawing.Color.Black;
            this.mln.Location = new System.Drawing.Point(3, 0);
            this.mln.Name = "mln";
            this.mln.Size = new System.Drawing.Size(55, 72);
            this.mln.TabIndex = 4;
            this.mln.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.qDataGridViewTextBoxColumn,
            this.tNDataGridViewTextBoxColumn,
            this.dATDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 4);
            this.dataGridView1.DataSource = this.mDCNBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(799, 140);
            this.dataGridView1.TabIndex = 9;
            // 
            // pets_ClinicDataSet
            // 
            this.pets_ClinicDataSet.DataSetName = "Pets_ClinicDataSet";
            this.pets_ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mDCNBindingSource
            // 
            this.mDCNBindingSource.DataMember = "MDCN";
            this.mDCNBindingSource.DataSource = this.pets_ClinicDataSet;
            // 
            // mDCNTableAdapter
            // 
            this.mDCNTableAdapter.ClearBeforeFill = true;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            // 
            // qDataGridViewTextBoxColumn
            // 
            this.qDataGridViewTextBoxColumn.DataPropertyName = "Q";
            this.qDataGridViewTextBoxColumn.HeaderText = "Q";
            this.qDataGridViewTextBoxColumn.Name = "qDataGridViewTextBoxColumn";
            // 
            // tNDataGridViewTextBoxColumn
            // 
            this.tNDataGridViewTextBoxColumn.DataPropertyName = "TN";
            this.tNDataGridViewTextBoxColumn.HeaderText = "TN";
            this.tNDataGridViewTextBoxColumn.Name = "tNDataGridViewTextBoxColumn";
            // 
            // dATDataGridViewTextBoxColumn
            // 
            this.dATDataGridViewTextBoxColumn.DataPropertyName = "DAT";
            this.dATDataGridViewTextBoxColumn.HeaderText = "DAT";
            this.dATDataGridViewTextBoxColumn.Name = "dATDataGridViewTextBoxColumn";
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mupdate);
            this.Controls.Add(this.minsert);
            this.Name = "Medicines";
            this.Size = new System.Drawing.Size(1044, 538);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_ClinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDCNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mupdate;
        private System.Windows.Forms.Button minsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label mln;
        private System.Windows.Forms.ComboBox mn;
        private System.Windows.Forms.Label mlq;
        private System.Windows.Forms.TextBox mq;
        private System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.Label mls;
        private System.Windows.Forms.Label mlts;
        private System.Windows.Forms.TextBox mts;
        private System.Windows.Forms.Button mbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox mp;
        private System.Windows.Forms.Label mlp;
        private System.Windows.Forms.BindingSource mDCNBindingSource;
        private Pets_ClinicDataSet pets_ClinicDataSet;
        private Pets_ClinicDataSetTableAdapters.MDCNTableAdapter mDCNTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATDataGridViewTextBoxColumn;
    }
}
