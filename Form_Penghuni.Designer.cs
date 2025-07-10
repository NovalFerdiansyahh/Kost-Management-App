namespace WindowsFormsApp1
{
    partial class Form_Penghuni
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
            this.iDPenghuniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKamarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penghuniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplikasi_KOMADataSet = new WindowsFormsApp1.Aplikasi_KOMADataSet();
            this.btPENGHUNI = new System.Windows.Forms.Button();
            this.btDASBOARD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btLOGOUT = new System.Windows.Forms.Button();
            this.btBACKUP = new System.Windows.Forms.Button();
            this.btLAPORAN = new System.Windows.Forms.Button();
            this.btPEMBAYARAN = new System.Windows.Forms.Button();
            this.btKAMAR = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.penghuniTableAdapter = new WindowsFormsApp1.Aplikasi_KOMADataSetTableAdapters.PenghuniTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDkamar = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNOHP = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghuniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikasi_KOMADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPenghuniDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.noHPDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.iDKamarDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.penghuniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(168, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 172);
            this.dataGridView1.TabIndex = 54;
            // 
            // iDPenghuniDataGridViewTextBoxColumn
            // 
            this.iDPenghuniDataGridViewTextBoxColumn.DataPropertyName = "ID_Penghuni";
            this.iDPenghuniDataGridViewTextBoxColumn.HeaderText = "ID_Penghuni";
            this.iDPenghuniDataGridViewTextBoxColumn.Name = "iDPenghuniDataGridViewTextBoxColumn";
            this.iDPenghuniDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // noHPDataGridViewTextBoxColumn
            // 
            this.noHPDataGridViewTextBoxColumn.DataPropertyName = "NoHP";
            this.noHPDataGridViewTextBoxColumn.HeaderText = "NoHP";
            this.noHPDataGridViewTextBoxColumn.Name = "noHPDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // iDKamarDataGridViewTextBoxColumn
            // 
            this.iDKamarDataGridViewTextBoxColumn.DataPropertyName = "ID_Kamar";
            this.iDKamarDataGridViewTextBoxColumn.HeaderText = "ID_Kamar";
            this.iDKamarDataGridViewTextBoxColumn.Name = "iDKamarDataGridViewTextBoxColumn";
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "TanggalMasuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "TanggalMasuk";
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            // 
            // penghuniBindingSource
            // 
            this.penghuniBindingSource.DataMember = "Penghuni";
            this.penghuniBindingSource.DataSource = this.aplikasi_KOMADataSet;
            // 
            // aplikasi_KOMADataSet
            // 
            this.aplikasi_KOMADataSet.DataSetName = "Aplikasi_KOMADataSet";
            this.aplikasi_KOMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btPENGHUNI
            // 
            this.btPENGHUNI.Location = new System.Drawing.Point(24, 128);
            this.btPENGHUNI.Name = "btPENGHUNI";
            this.btPENGHUNI.Size = new System.Drawing.Size(75, 39);
            this.btPENGHUNI.TabIndex = 44;
            this.btPENGHUNI.Text = "Penghuni";
            this.btPENGHUNI.UseVisualStyleBackColor = true;
            // 
            // btDASBOARD
            // 
            this.btDASBOARD.Location = new System.Drawing.Point(24, 79);
            this.btDASBOARD.Name = "btDASBOARD";
            this.btDASBOARD.Size = new System.Drawing.Size(75, 32);
            this.btDASBOARD.TabIndex = 43;
            this.btDASBOARD.Text = "Dasboard";
            this.btDASBOARD.UseVisualStyleBackColor = true;
            this.btDASBOARD.Click += new System.EventHandler(this.btDASBOARD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "KOMA APP";
            // 
            // btLOGOUT
            // 
            this.btLOGOUT.BackColor = System.Drawing.Color.Red;
            this.btLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLOGOUT.Location = new System.Drawing.Point(24, 393);
            this.btLOGOUT.Name = "btLOGOUT";
            this.btLOGOUT.Size = new System.Drawing.Size(75, 40);
            this.btLOGOUT.TabIndex = 49;
            this.btLOGOUT.Text = "Log Out";
            this.btLOGOUT.UseVisualStyleBackColor = false;
            this.btLOGOUT.Click += new System.EventHandler(this.btLOGOUT_Click);
            // 
            // btBACKUP
            // 
            this.btBACKUP.Location = new System.Drawing.Point(24, 312);
            this.btBACKUP.Name = "btBACKUP";
            this.btBACKUP.Size = new System.Drawing.Size(75, 38);
            this.btBACKUP.TabIndex = 48;
            this.btBACKUP.Text = "Backup";
            this.btBACKUP.UseVisualStyleBackColor = true;
            // 
            // btLAPORAN
            // 
            this.btLAPORAN.Location = new System.Drawing.Point(24, 265);
            this.btLAPORAN.Name = "btLAPORAN";
            this.btLAPORAN.Size = new System.Drawing.Size(75, 33);
            this.btLAPORAN.TabIndex = 47;
            this.btLAPORAN.Text = "Laporan";
            this.btLAPORAN.UseVisualStyleBackColor = true;
            this.btLAPORAN.Click += new System.EventHandler(this.btLAPORAN_Click);
            // 
            // btPEMBAYARAN
            // 
            this.btPEMBAYARAN.Location = new System.Drawing.Point(24, 220);
            this.btPEMBAYARAN.Name = "btPEMBAYARAN";
            this.btPEMBAYARAN.Size = new System.Drawing.Size(75, 36);
            this.btPEMBAYARAN.TabIndex = 46;
            this.btPEMBAYARAN.Text = "Pembayaran";
            this.btPEMBAYARAN.UseVisualStyleBackColor = true;
            this.btPEMBAYARAN.Click += new System.EventHandler(this.btPEMBAYARAN_Click);
            // 
            // btKAMAR
            // 
            this.btKAMAR.Location = new System.Drawing.Point(24, 180);
            this.btKAMAR.Name = "btKAMAR";
            this.btKAMAR.Size = new System.Drawing.Size(75, 32);
            this.btKAMAR.TabIndex = 45;
            this.btKAMAR.Text = "Kamar";
            this.btKAMAR.UseVisualStyleBackColor = true;
            this.btKAMAR.Click += new System.EventHandler(this.btKAMAR_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(125, 448);
            this.splitter1.TabIndex = 42;
            this.splitter1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Penghuni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 38);
            this.textBox2.TabIndex = 59;
            // 
            // penghuniTableAdapter
            // 
            this.penghuniTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 26);
            this.button1.TabIndex = 66;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 26);
            this.button2.TabIndex = 66;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 26);
            this.button3.TabIndex = 66;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 68;
            // 
            // textBoxIDkamar
            // 
            this.textBoxIDkamar.Location = new System.Drawing.Point(280, 199);
            this.textBoxIDkamar.Multiline = true;
            this.textBoxIDkamar.Name = "textBoxIDkamar";
            this.textBoxIDkamar.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDkamar.TabIndex = 10;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(280, 168);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlamat.TabIndex = 9;
            // 
            // textBoxNOHP
            // 
            this.textBoxNOHP.Location = new System.Drawing.Point(280, 135);
            this.textBoxNOHP.Multiline = true;
            this.textBoxNOHP.Name = "textBoxNOHP";
            this.textBoxNOHP.Size = new System.Drawing.Size(100, 20);
            this.textBoxNOHP.TabIndex = 8;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(280, 102);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(100, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(184, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "TanggalMasuk";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(183, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Nomor Kamar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(183, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Alamat";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(183, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "NoHP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(183, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nama";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(183, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "ID Penghuni";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(280, 66);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            this.textBoxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(722, 232);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(67, 26);
            this.btn_Clear.TabIndex = 69;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Form_Penghuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIDkamar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNOHP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btPENGHUNI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btDASBOARD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btLOGOUT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btBACKUP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btLAPORAN);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btPEMBAYARAN);
            this.Controls.Add(this.btKAMAR);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Penghuni";
            this.Text = "Form_Penghuni";
            this.Load += new System.EventHandler(this.Form_Penghuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penghuniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikasi_KOMADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btPENGHUNI;
        private System.Windows.Forms.Button btDASBOARD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLOGOUT;
        private System.Windows.Forms.Button btBACKUP;
        private System.Windows.Forms.Button btLAPORAN;
        private System.Windows.Forms.Button btPEMBAYARAN;
        private System.Windows.Forms.Button btKAMAR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private Aplikasi_KOMADataSet aplikasi_KOMADataSet;
        private System.Windows.Forms.BindingSource penghuniBindingSource;
        private Aplikasi_KOMADataSetTableAdapters.PenghuniTableAdapter penghuniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPenghuniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKamarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxIDkamar;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNOHP;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btn_Clear;
    }
}