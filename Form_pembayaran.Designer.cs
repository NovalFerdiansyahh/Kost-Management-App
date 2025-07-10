namespace WindowsFormsApp1
{
    partial class Form_pembayaran
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
            this.textBoxKeterangan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxID_Penghuni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID_Pembayaran = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgPembayaran = new System.Windows.Forms.DataGridView();
            this.btPENGHUNI = new System.Windows.Forms.Button();
            this.btDASBOARD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btLOGOUT = new System.Windows.Forms.Button();
            this.btBACKUP = new System.Windows.Forms.Button();
            this.btLAPORAN = new System.Windows.Forms.Button();
            this.btPEMBAYARAN = new System.Windows.Forms.Button();
            this.btKAMAR = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttontambah = new System.Windows.Forms.Button();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.dtTanggalBayar = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgPembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxKeterangan
            // 
            this.textBoxKeterangan.Location = new System.Drawing.Point(270, 198);
            this.textBoxKeterangan.Multiline = true;
            this.textBoxKeterangan.Name = "textBoxKeterangan";
            this.textBoxKeterangan.Size = new System.Drawing.Size(100, 20);
            this.textBoxKeterangan.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(179, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Keterangan";
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(270, 165);
            this.textBoxJumlah.Multiline = true;
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(100, 20);
            this.textBoxJumlah.TabIndex = 9;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            // 
            // textBoxID_Penghuni
            // 
            this.textBoxID_Penghuni.Location = new System.Drawing.Point(270, 91);
            this.textBoxID_Penghuni.Multiline = true;
            this.textBoxID_Penghuni.Name = "textBoxID_Penghuni";
            this.textBoxID_Penghuni.Size = new System.Drawing.Size(100, 20);
            this.textBoxID_Penghuni.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(179, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(179, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TanggalBayar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(179, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID_Penghuni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(458, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_Pembayaran";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxID_Pembayaran
            // 
            this.textBoxID_Pembayaran.Location = new System.Drawing.Point(560, -28);
            this.textBoxID_Pembayaran.Multiline = true;
            this.textBoxID_Pembayaran.Name = "textBoxID_Pembayaran";
            this.textBoxID_Pembayaran.Size = new System.Drawing.Size(100, 20);
            this.textBoxID_Pembayaran.TabIndex = 0;
            this.textBoxID_Pembayaran.TextChanged += new System.EventHandler(this.textBoxID_PENGGUNA_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 81;
            this.label8.Text = "Pembayaran";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 80;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 38);
            this.textBox2.TabIndex = 79;
            // 
            // dgPembayaran
            // 
            this.dgPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPembayaran.Location = new System.Drawing.Point(182, 255);
            this.dgPembayaran.Name = "dgPembayaran";
            this.dgPembayaran.Size = new System.Drawing.Size(605, 183);
            this.dgPembayaran.TabIndex = 74;
            this.dgPembayaran.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKAMAR_CellContentClick);
            // 
            // btPENGHUNI
            // 
            this.btPENGHUNI.Location = new System.Drawing.Point(36, 128);
            this.btPENGHUNI.Name = "btPENGHUNI";
            this.btPENGHUNI.Size = new System.Drawing.Size(75, 39);
            this.btPENGHUNI.TabIndex = 66;
            this.btPENGHUNI.Text = "Penghuni";
            this.btPENGHUNI.UseVisualStyleBackColor = true;
            this.btPENGHUNI.Click += new System.EventHandler(this.btPENGHUNI_Click);
            // 
            // btDASBOARD
            // 
            this.btDASBOARD.Location = new System.Drawing.Point(36, 79);
            this.btDASBOARD.Name = "btDASBOARD";
            this.btDASBOARD.Size = new System.Drawing.Size(75, 32);
            this.btDASBOARD.TabIndex = 65;
            this.btDASBOARD.Text = "Dasboard";
            this.btDASBOARD.UseVisualStyleBackColor = true;
            this.btDASBOARD.Click += new System.EventHandler(this.btDASBOARD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "KOMA APP";
            // 
            // btLOGOUT
            // 
            this.btLOGOUT.BackColor = System.Drawing.Color.Red;
            this.btLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLOGOUT.Location = new System.Drawing.Point(36, 393);
            this.btLOGOUT.Name = "btLOGOUT";
            this.btLOGOUT.Size = new System.Drawing.Size(75, 40);
            this.btLOGOUT.TabIndex = 71;
            this.btLOGOUT.Text = "Log Out";
            this.btLOGOUT.UseVisualStyleBackColor = false;
            this.btLOGOUT.Click += new System.EventHandler(this.btLOGOUT_Click);
            // 
            // btBACKUP
            // 
            this.btBACKUP.Location = new System.Drawing.Point(36, 312);
            this.btBACKUP.Name = "btBACKUP";
            this.btBACKUP.Size = new System.Drawing.Size(75, 38);
            this.btBACKUP.TabIndex = 70;
            this.btBACKUP.Text = "Backup";
            this.btBACKUP.UseVisualStyleBackColor = true;
            // 
            // btLAPORAN
            // 
            this.btLAPORAN.Location = new System.Drawing.Point(36, 265);
            this.btLAPORAN.Name = "btLAPORAN";
            this.btLAPORAN.Size = new System.Drawing.Size(75, 33);
            this.btLAPORAN.TabIndex = 69;
            this.btLAPORAN.Text = "Laporan";
            this.btLAPORAN.UseVisualStyleBackColor = true;
            this.btLAPORAN.Click += new System.EventHandler(this.btLAPORAN_Click);
            // 
            // btPEMBAYARAN
            // 
            this.btPEMBAYARAN.Location = new System.Drawing.Point(36, 220);
            this.btPEMBAYARAN.Name = "btPEMBAYARAN";
            this.btPEMBAYARAN.Size = new System.Drawing.Size(75, 36);
            this.btPEMBAYARAN.TabIndex = 68;
            this.btPEMBAYARAN.Text = "Pembayaran";
            this.btPEMBAYARAN.UseVisualStyleBackColor = true;
            // 
            // btKAMAR
            // 
            this.btKAMAR.Location = new System.Drawing.Point(36, 180);
            this.btKAMAR.Name = "btKAMAR";
            this.btKAMAR.Size = new System.Drawing.Size(75, 32);
            this.btKAMAR.TabIndex = 67;
            this.btKAMAR.Text = "Kamar";
            this.btKAMAR.UseVisualStyleBackColor = true;
            this.btKAMAR.Click += new System.EventHandler(this.btKAMAR_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(127, 450);
            this.splitter1.TabIndex = 64;
            this.splitter1.TabStop = false;
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(624, 220);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(67, 26);
            this.buttonDELETE.TabIndex = 83;
            this.buttonDELETE.Text = "Delete";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // buttontambah
            // 
            this.buttontambah.Location = new System.Drawing.Point(478, 220);
            this.buttontambah.Name = "buttontambah";
            this.buttontambah.Size = new System.Drawing.Size(67, 26);
            this.buttontambah.TabIndex = 84;
            this.buttontambah.Text = "Tambah";
            this.buttontambah.UseVisualStyleBackColor = true;
            this.buttontambah.Click += new System.EventHandler(this.buttontambah_Click);
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(551, 220);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(67, 26);
            this.buttonEDIT.TabIndex = 85;
            this.buttonEDIT.Text = "Edit";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // dtTanggalBayar
            // 
            this.dtTanggalBayar.Location = new System.Drawing.Point(270, 126);
            this.dtTanggalBayar.Name = "dtTanggalBayar";
            this.dtTanggalBayar.Size = new System.Drawing.Size(200, 20);
            this.dtTanggalBayar.TabIndex = 86;
            // 
            // Form_pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtTanggalBayar);
            this.Controls.Add(this.textBoxKeterangan);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttontambah);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxID_Penghuni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID_Pembayaran);
            this.Controls.Add(this.dgPembayaran);
            this.Controls.Add(this.btPENGHUNI);
            this.Controls.Add(this.btDASBOARD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLOGOUT);
            this.Controls.Add(this.btBACKUP);
            this.Controls.Add(this.btLAPORAN);
            this.Controls.Add(this.btPEMBAYARAN);
            this.Controls.Add(this.btKAMAR);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_pembayaran";
            this.Text = "Form_pembayaran";
            this.Load += new System.EventHandler(this.Form_pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPembayaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxID_Penghuni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID_Pembayaran;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgPembayaran;
        private System.Windows.Forms.Button btPENGHUNI;
        private System.Windows.Forms.Button btDASBOARD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btLOGOUT;
        private System.Windows.Forms.Button btBACKUP;
        private System.Windows.Forms.Button btLAPORAN;
        private System.Windows.Forms.Button btPEMBAYARAN;
        private System.Windows.Forms.Button btKAMAR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttontambah;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.TextBox textBoxKeterangan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTanggalBayar;
    }
}