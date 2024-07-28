namespace Mazot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.newplate = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GoExcel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newPlateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oncekiKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonrakiKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mazotDataSet = new Mazot.MazotDataSet();
            this.carsTableAdapter = new Mazot.MazotDataSetTableAdapters.CarsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Excel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazotDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // newplate
            // 
            this.newplate.ImageList = this.ımageList1;
            this.newplate.Location = new System.Drawing.Point(879, 393);
            this.newplate.Name = "newplate";
            this.newplate.Size = new System.Drawing.Size(125, 25);
            this.newplate.TabIndex = 0;
            this.newplate.Text = "Plaka Ekle";
            this.newplate.UseVisualStyleBackColor = true;
            this.newplate.Click += new System.EventHandler(this.newplate_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "excel_office_4658.ico");
            this.ımageList1.Images.SetKeyName(1, "circle_customer_help_info_information_service_support_icon_123208.ico");
            this.ımageList1.Images.SetKeyName(2, "record_operations_icon_216630.ico");
            this.ımageList1.Images.SetKeyName(3, "back_112351.ico");
            this.ımageList1.Images.SetKeyName(4, "file_move_outline_icon_139595.ico");
            this.ımageList1.Images.SetKeyName(5, "turn-off.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "circle_customer_help_info_information_service_support_icon_123208.ico";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 35);
            this.button2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button2, "İşlemler");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(863, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Durum:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(854, 336);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 24);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1405, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(891, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bilgiler Girişi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(909, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1051, 448);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1176, 448);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(108, 21);
            this.textBox3.TabIndex = 9;
            // 
            // GoExcel
            // 
            this.GoExcel.FlatAppearance.BorderSize = 0;
            this.GoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoExcel.ImageKey = "excel_office_4658.ico";
            this.GoExcel.ImageList = this.ımageList1;
            this.GoExcel.Location = new System.Drawing.Point(54, 3);
            this.GoExcel.Name = "GoExcel";
            this.GoExcel.Size = new System.Drawing.Size(43, 35);
            this.GoExcel.TabIndex = 11;
            this.GoExcel.UseVisualStyleBackColor = true;
            this.GoExcel.Click += new System.EventHandler(this.GoExcel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(700, 449);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1101, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Plaka Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newPlateDataGridViewTextBoxColumn,
            this.tripDataGridViewTextBoxColumn,
            this.oncekiKmDataGridViewTextBoxColumn,
            this.sonrakiKmDataGridViewTextBoxColumn,
            this.entryDateDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(767, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 328);
            this.dataGridView1.TabIndex = 15;
            // 
            // newPlateDataGridViewTextBoxColumn
            // 
            this.newPlateDataGridViewTextBoxColumn.DataPropertyName = "NewPlate";
            this.newPlateDataGridViewTextBoxColumn.HeaderText = "NewPlate";
            this.newPlateDataGridViewTextBoxColumn.Name = "newPlateDataGridViewTextBoxColumn";
            // 
            // tripDataGridViewTextBoxColumn
            // 
            this.tripDataGridViewTextBoxColumn.DataPropertyName = "Trip";
            this.tripDataGridViewTextBoxColumn.HeaderText = "Trip";
            this.tripDataGridViewTextBoxColumn.Name = "tripDataGridViewTextBoxColumn";
            // 
            // oncekiKmDataGridViewTextBoxColumn
            // 
            this.oncekiKmDataGridViewTextBoxColumn.DataPropertyName = "Onceki_Km";
            this.oncekiKmDataGridViewTextBoxColumn.HeaderText = "Onceki_Km";
            this.oncekiKmDataGridViewTextBoxColumn.Name = "oncekiKmDataGridViewTextBoxColumn";
            // 
            // sonrakiKmDataGridViewTextBoxColumn
            // 
            this.sonrakiKmDataGridViewTextBoxColumn.DataPropertyName = "Sonraki_Km";
            this.sonrakiKmDataGridViewTextBoxColumn.HeaderText = "Sonraki_Km";
            this.sonrakiKmDataGridViewTextBoxColumn.Name = "sonrakiKmDataGridViewTextBoxColumn";
            // 
            // entryDateDataGridViewTextBoxColumn
            // 
            this.entryDateDataGridViewTextBoxColumn.DataPropertyName = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.HeaderText = "EntryDate";
            this.entryDateDataGridViewTextBoxColumn.Name = "entryDateDataGridViewTextBoxColumn";
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.mazotDataSet;
            // 
            // mazotDataSet
            // 
            this.mazotDataSet.DataSetName = "MazotDataSet";
            this.mazotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.GoExcel);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Excel);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 1041);
            this.panel2.TabIndex = 18;
            // 
            // Excel
            // 
            this.Excel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Excel.Location = new System.Drawing.Point(997, 334);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(75, 23);
            this.Excel.TabIndex = 24;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = false;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(828, 457);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 289);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1184, 242);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(207, 20);
            this.textBox4.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(866, 242);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(1209, 334);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 26);
            this.button7.TabIndex = 19;
            this.button7.Text = "Bilgileri Getir";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageIndex = 3;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 35);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1298, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Litre";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1301, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageKey = "file_move_outline_icon_139595.ico";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(110, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 35);
            this.button5.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button5, "Bugünün Tarihinden Önce Girmiş Olduğunuz veriler için");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1173, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sonraki Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(1049, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Önceki Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(906, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plaka Seç";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Beige;
            this.button4.ImageKey = "back_112351.ico";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 35);
            this.button4.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button4, "Bir Önceki Sayfa");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.ImageKey = "turn-off.png";
            this.Logout.ImageList = this.ımageList1;
            this.Logout.Location = new System.Drawing.Point(1866, 9);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(26, 29);
            this.Logout.TabIndex = 21;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newplate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mazot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazotDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newplate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button GoExcel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MazotDataSet mazotDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private MazotDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn newPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oncekiKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonrakiKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Logout;
    }
}

