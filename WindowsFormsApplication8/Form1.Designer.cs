namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.mesajTahtasiDataSet = new WindowsFormsApplication8.MesajTahtasiDataSet();
            this.mesajTahtasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mesajTahtasiTableAdapter = new WindowsFormsApplication8.MesajTahtasiDataSetTableAdapters.MesajTahtasiTableAdapter();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesajTahtasiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mesajTahtasiDataSet1 = new WindowsFormsApplication8.MesajTahtasiDataSet1();
            this.mesajTahtasiTableAdapter1 = new WindowsFormsApplication8.MesajTahtasiDataSet1TableAdapters.MesajTahtasiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mesajTahtasiDataSet
            // 
            this.mesajTahtasiDataSet.DataSetName = "MesajTahtasiDataSet";
            this.mesajTahtasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajTahtasiBindingSource
            // 
            this.mesajTahtasiBindingSource.DataMember = "MesajTahtasi";
            this.mesajTahtasiBindingSource.DataSource = this.mesajTahtasiDataSet;
            // 
            // mesajTahtasiTableAdapter
            // 
            this.mesajTahtasiTableAdapter.ClearBeforeFill = true;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(430, 41);
            this.txtMesaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(193, 62);
            this.txtMesaj.TabIndex = 1;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(430, 18);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(193, 20);
            this.txtIsim.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(457, 144);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(56, 19);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(544, 144);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(56, 19);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.mesajDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mesajTahtasiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(257, 251);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // mesajDataGridViewTextBoxColumn
            // 
            this.mesajDataGridViewTextBoxColumn.DataPropertyName = "mesaj";
            this.mesajDataGridViewTextBoxColumn.HeaderText = "mesaj";
            this.mesajDataGridViewTextBoxColumn.Name = "mesajDataGridViewTextBoxColumn";
            // 
            // mesajTahtasiBindingSource1
            // 
            this.mesajTahtasiBindingSource1.DataMember = "MesajTahtasi";
            this.mesajTahtasiBindingSource1.DataSource = this.mesajTahtasiDataSet1;
            // 
            // mesajTahtasiDataSet1
            // 
            this.mesajTahtasiDataSet1.DataSetName = "MesajTahtasiDataSet1";
            this.mesajTahtasiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mesajTahtasiTableAdapter1
            // 
            this.mesajTahtasiTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mesaj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtMesaj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesajTahtasiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MesajTahtasiDataSet mesajTahtasiDataSet;
        private System.Windows.Forms.BindingSource mesajTahtasiBindingSource;
        private MesajTahtasiDataSetTableAdapters.MesajTahtasiTableAdapter mesajTahtasiTableAdapter;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MesajTahtasiDataSet1 mesajTahtasiDataSet1;
        private System.Windows.Forms.BindingSource mesajTahtasiBindingSource1;
        private MesajTahtasiDataSet1TableAdapters.MesajTahtasiTableAdapter mesajTahtasiTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesajDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

