namespace LupaFiyatHesaplama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isBasBox = new System.Windows.Forms.MaskedTextBox();
            this.isBitBox = new System.Windows.Forms.MaskedTextBox();
            this.isTurBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fisTutarBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fisTuruBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.calisanComboX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.calisanEkleBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBasTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTurussDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamAlacakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hesapDataSet1 = new LupaFiyatHesaplama.hesapDataSet1();
            this.hesapDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapDataSet = new LupaFiyatHesaplama.hesapDataSet();
            this.hesapDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tablo1TableAdapter = new LupaFiyatHesaplama.hesapDataSet1TableAdapters.Tablo1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İş Başlangıç Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İş Bitiş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İş Türü:";
            // 
            // isBasBox
            // 
            this.isBasBox.Location = new System.Drawing.Point(163, 23);
            this.isBasBox.Mask = "00/00/0000 90:00";
            this.isBasBox.Name = "isBasBox";
            this.isBasBox.Size = new System.Drawing.Size(121, 22);
            this.isBasBox.TabIndex = 3;
            this.isBasBox.ValidatingType = typeof(System.DateTime);
            // 
            // isBitBox
            // 
            this.isBitBox.Location = new System.Drawing.Point(163, 58);
            this.isBitBox.Mask = "00/00/0000 90:00";
            this.isBitBox.Name = "isBitBox";
            this.isBitBox.Size = new System.Drawing.Size(121, 22);
            this.isBitBox.TabIndex = 4;
            this.isBitBox.ValidatingType = typeof(System.DateTime);
            // 
            // isTurBox
            // 
            this.isTurBox.FormattingEnabled = true;
            this.isTurBox.Items.AddRange(new object[] {
            "Birinci Grup İşleri",
            "İkinci Grup İşleri",
            "Stand"});
            this.isTurBox.Location = new System.Drawing.Point(163, 93);
            this.isTurBox.Name = "isTurBox";
            this.isTurBox.Size = new System.Drawing.Size(121, 24);
            this.isTurBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(163, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla ve Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(722, 332);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(66, 84);
            this.listBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ekstra Harcama Yaptınız mı?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(603, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "(Evet ise işaretleyin)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(403, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fiş Tutarı:";
            // 
            // fisTutarBox
            // 
            this.fisTutarBox.Enabled = false;
            this.fisTutarBox.Location = new System.Drawing.Point(481, 55);
            this.fisTutarBox.Mask = "000000";
            this.fisTutarBox.Name = "fisTutarBox";
            this.fisTutarBox.Size = new System.Drawing.Size(100, 22);
            this.fisTutarBox.TabIndex = 16;
            this.fisTutarBox.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(403, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fiş Türü:";
            // 
            // fisTuruBox
            // 
            this.fisTuruBox.Enabled = false;
            this.fisTuruBox.FormattingEnabled = true;
            this.fisTuruBox.Items.AddRange(new object[] {
            "YEMEK",
            "YIKAMA",
            "İKRAM",
            "ARAÇ MALZEME (PİL VS.)",
            "YAKIT",
            "TAKSİ",
            "OTOPARK/VALE",
            "KIRTASİYE"});
            this.fisTuruBox.Location = new System.Drawing.Point(481, 90);
            this.fisTuruBox.Name = "fisTuruBox";
            this.fisTuruBox.Size = new System.Drawing.Size(121, 24);
            this.fisTuruBox.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(481, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Fiş Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Çalışan Adı Soyadı: ";
            // 
            // calisanComboX
            // 
            this.calisanComboX.FormattingEnabled = true;
            this.calisanComboX.Items.AddRange(new object[] {
            "Mahmud Asaf Erkovan"});
            this.calisanComboX.Location = new System.Drawing.Point(163, 132);
            this.calisanComboX.Name = "calisanComboX";
            this.calisanComboX.Size = new System.Drawing.Size(121, 24);
            this.calisanComboX.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Çalışan Ekle (Ad Soyad): ";
            // 
            // calisanEkleBox
            // 
            this.calisanEkleBox.Location = new System.Drawing.Point(568, 188);
            this.calisanEkleBox.Name = "calisanEkleBox";
            this.calisanEkleBox.Size = new System.Drawing.Size(100, 22);
            this.calisanEkleBox.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(674, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 26);
            this.button3.TabIndex = 25;
            this.button3.Text = "Çalışan Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(577, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 26);
            this.button4.TabIndex = 26;
            this.button4.Text = "Çalışan Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Çalışanı Silmek İçin Önce Seçin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.isBasTarihiDataGridViewTextBoxColumn,
            this.isBitTarihiDataGridViewTextBoxColumn,
            this.isTürüDataGridViewTextBoxColumn,
            this.fisTutDataGridViewTextBoxColumn,
            this.fisTurussDataGridViewTextBoxColumn,
            this.toplamAlacakDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablo1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(676, 132);
            this.dataGridView1.TabIndex = 28;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "Ad_Soyad";
            this.adSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // isBasTarihiDataGridViewTextBoxColumn
            // 
            this.isBasTarihiDataGridViewTextBoxColumn.DataPropertyName = "isBasTarihi";
            this.isBasTarihiDataGridViewTextBoxColumn.HeaderText = "isBasTarihi";
            this.isBasTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isBasTarihiDataGridViewTextBoxColumn.Name = "isBasTarihiDataGridViewTextBoxColumn";
            this.isBasTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // isBitTarihiDataGridViewTextBoxColumn
            // 
            this.isBitTarihiDataGridViewTextBoxColumn.DataPropertyName = "isBitTarihi";
            this.isBitTarihiDataGridViewTextBoxColumn.HeaderText = "isBitTarihi";
            this.isBitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isBitTarihiDataGridViewTextBoxColumn.Name = "isBitTarihiDataGridViewTextBoxColumn";
            this.isBitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // isTürüDataGridViewTextBoxColumn
            // 
            this.isTürüDataGridViewTextBoxColumn.DataPropertyName = "isTürü";
            this.isTürüDataGridViewTextBoxColumn.HeaderText = "isTürü";
            this.isTürüDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isTürüDataGridViewTextBoxColumn.Name = "isTürüDataGridViewTextBoxColumn";
            this.isTürüDataGridViewTextBoxColumn.Width = 125;
            // 
            // fisTutDataGridViewTextBoxColumn
            // 
            this.fisTutDataGridViewTextBoxColumn.DataPropertyName = "fisTut";
            this.fisTutDataGridViewTextBoxColumn.HeaderText = "fisTut";
            this.fisTutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fisTutDataGridViewTextBoxColumn.Name = "fisTutDataGridViewTextBoxColumn";
            this.fisTutDataGridViewTextBoxColumn.Width = 125;
            // 
            // fisTurussDataGridViewTextBoxColumn
            // 
            this.fisTurussDataGridViewTextBoxColumn.DataPropertyName = "fisTuruss";
            this.fisTurussDataGridViewTextBoxColumn.HeaderText = "fisTuruss";
            this.fisTurussDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fisTurussDataGridViewTextBoxColumn.Name = "fisTurussDataGridViewTextBoxColumn";
            this.fisTurussDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamAlacakDataGridViewTextBoxColumn
            // 
            this.toplamAlacakDataGridViewTextBoxColumn.DataPropertyName = "toplamAlacak";
            this.toplamAlacakDataGridViewTextBoxColumn.HeaderText = "toplamAlacak";
            this.toplamAlacakDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamAlacakDataGridViewTextBoxColumn.Name = "toplamAlacakDataGridViewTextBoxColumn";
            this.toplamAlacakDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablo1BindingSource
            // 
            this.tablo1BindingSource.DataMember = "Tablo1";
            this.tablo1BindingSource.DataSource = this.hesapDataSet1;
            // 
            // hesapDataSet1
            // 
            this.hesapDataSet1.DataSetName = "hesapDataSet1";
            this.hesapDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapDataSetBindingSource1
            // 
            this.hesapDataSetBindingSource1.DataSource = this.hesapDataSet;
            this.hesapDataSetBindingSource1.Position = 0;
            // 
            // hesapDataSet
            // 
            this.hesapDataSet.DataSetName = "hesapDataSet";
            this.hesapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hesapDataSetBindingSource
            // 
            this.hesapDataSetBindingSource.DataSource = this.hesapDataSet;
            this.hesapDataSetBindingSource.Position = 0;
            // 
            // tablo1TableAdapter
            // 
            this.tablo1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.calisanEkleBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calisanComboX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fisTuruBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fisTutarBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isTurBox);
            this.Controls.Add(this.isBitBox);
            this.Controls.Add(this.isBasBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hesapDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox isBasBox;
        private System.Windows.Forms.MaskedTextBox isBitBox;
        private System.Windows.Forms.ComboBox isTurBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox fisTutarBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fisTuruBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox calisanComboX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox calisanEkleBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hesapDataSetBindingSource;
        private hesapDataSet hesapDataSet;
        private System.Windows.Forms.BindingSource hesapDataSetBindingSource1;
        private hesapDataSet1 hesapDataSet1;
        private System.Windows.Forms.BindingSource tablo1BindingSource;
        private hesapDataSet1TableAdapters.Tablo1TableAdapter tablo1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBasTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isBitTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTurussDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamAlacakDataGridViewTextBoxColumn;
    }
}

