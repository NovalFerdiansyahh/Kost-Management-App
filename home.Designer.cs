namespace WindowsFormsApp1
{
    partial class home
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
            this.btDASHBOARD = new System.Windows.Forms.Button();
            this.btPENGHUNI = new System.Windows.Forms.Button();
            this.btKAMAR = new System.Windows.Forms.Button();
            this.btPEMBAYARAN = new System.Windows.Forms.Button();
            this.btLAPORAN = new System.Windows.Forms.Button();
            this.btBACKUP = new System.Windows.Forms.Button();
            this.btLOGOUT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbJumlahPenghuni = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbJumlahKamar = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbJumlahPembayaran = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btDASHBOARD
            // 
            this.btDASHBOARD.Location = new System.Drawing.Point(20, 81);
            this.btDASHBOARD.Name = "btDASHBOARD";
            this.btDASHBOARD.Size = new System.Drawing.Size(75, 32);
            this.btDASHBOARD.TabIndex = 0;
            this.btDASHBOARD.Text = "Dasboard";
            this.btDASHBOARD.UseVisualStyleBackColor = true;
            // 
            // btPENGHUNI
            // 
            this.btPENGHUNI.Location = new System.Drawing.Point(20, 130);
            this.btPENGHUNI.Name = "btPENGHUNI";
            this.btPENGHUNI.Size = new System.Drawing.Size(75, 39);
            this.btPENGHUNI.TabIndex = 1;
            this.btPENGHUNI.Text = "Penghuni";
            this.btPENGHUNI.UseVisualStyleBackColor = true;
            this.btPENGHUNI.Click += new System.EventHandler(this.btPENGHUNI_Click);
            // 
            // btKAMAR
            // 
            this.btKAMAR.Location = new System.Drawing.Point(20, 182);
            this.btKAMAR.Name = "btKAMAR";
            this.btKAMAR.Size = new System.Drawing.Size(75, 32);
            this.btKAMAR.TabIndex = 2;
            this.btKAMAR.Text = "Kamar";
            this.btKAMAR.UseVisualStyleBackColor = true;
            this.btKAMAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // btPEMBAYARAN
            // 
            this.btPEMBAYARAN.Location = new System.Drawing.Point(20, 222);
            this.btPEMBAYARAN.Name = "btPEMBAYARAN";
            this.btPEMBAYARAN.Size = new System.Drawing.Size(75, 36);
            this.btPEMBAYARAN.TabIndex = 3;
            this.btPEMBAYARAN.Text = "Pembayaran";
            this.btPEMBAYARAN.UseVisualStyleBackColor = true;
            this.btPEMBAYARAN.Click += new System.EventHandler(this.btPEMBAYARAN_Click);
            // 
            // btLAPORAN
            // 
            this.btLAPORAN.Location = new System.Drawing.Point(20, 267);
            this.btLAPORAN.Name = "btLAPORAN";
            this.btLAPORAN.Size = new System.Drawing.Size(75, 33);
            this.btLAPORAN.TabIndex = 4;
            this.btLAPORAN.Text = "Laporan";
            this.btLAPORAN.UseVisualStyleBackColor = true;
            this.btLAPORAN.Click += new System.EventHandler(this.btLAPORAN_Click);
            // 
            // btBACKUP
            // 
            this.btBACKUP.Location = new System.Drawing.Point(20, 314);
            this.btBACKUP.Name = "btBACKUP";
            this.btBACKUP.Size = new System.Drawing.Size(75, 38);
            this.btBACKUP.TabIndex = 5;
            this.btBACKUP.Text = "Backup";
            this.btBACKUP.UseVisualStyleBackColor = true;
            this.btBACKUP.Click += new System.EventHandler(this.btBACKUP_Click);
            // 
            // btLOGOUT
            // 
            this.btLOGOUT.BackColor = System.Drawing.Color.Red;
            this.btLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLOGOUT.Location = new System.Drawing.Point(20, 395);
            this.btLOGOUT.Name = "btLOGOUT";
            this.btLOGOUT.Size = new System.Drawing.Size(75, 40);
            this.btLOGOUT.TabIndex = 16;
            this.btLOGOUT.Text = "Log Out";
            this.btLOGOUT.UseVisualStyleBackColor = false;
            this.btLOGOUT.Click += new System.EventHandler(this.btLOGOUT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "KOMA APP";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(118, 450);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 38);
            this.textBox2.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(163, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbJumlahPenghuni);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(160, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 206);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jumlah Penghuni";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(39, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbJumlahPenghuni
            // 
            this.lbJumlahPenghuni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJumlahPenghuni.AutoSize = true;
            this.lbJumlahPenghuni.BackColor = System.Drawing.Color.Lavender;
            this.lbJumlahPenghuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahPenghuni.ForeColor = System.Drawing.Color.Red;
            this.lbJumlahPenghuni.Location = new System.Drawing.Point(59, 145);
            this.lbJumlahPenghuni.Name = "lbJumlahPenghuni";
            this.lbJumlahPenghuni.Size = new System.Drawing.Size(32, 33);
            this.lbJumlahPenghuni.TabIndex = 0;
            this.lbJumlahPenghuni.Text = "0";
            this.lbJumlahPenghuni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.lbJumlahKamar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(337, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 206);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jumlah Kamar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.bed;
            this.pictureBox2.Location = new System.Drawing.Point(40, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbJumlahKamar
            // 
            this.lbJumlahKamar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJumlahKamar.AutoSize = true;
            this.lbJumlahKamar.BackColor = System.Drawing.Color.Lavender;
            this.lbJumlahKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahKamar.ForeColor = System.Drawing.Color.Red;
            this.lbJumlahKamar.Location = new System.Drawing.Point(60, 145);
            this.lbJumlahKamar.Name = "lbJumlahKamar";
            this.lbJumlahKamar.Size = new System.Drawing.Size(32, 33);
            this.lbJumlahKamar.TabIndex = 1;
            this.lbJumlahKamar.Text = "0";
            this.lbJumlahKamar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.lbJumlahPembayaran);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(512, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 206);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jumlah Pembayaran";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.transaction;
            this.pictureBox3.Location = new System.Drawing.Point(36, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lbJumlahPembayaran
            // 
            this.lbJumlahPembayaran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbJumlahPembayaran.AutoSize = true;
            this.lbJumlahPembayaran.BackColor = System.Drawing.Color.Lavender;
            this.lbJumlahPembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJumlahPembayaran.ForeColor = System.Drawing.Color.Red;
            this.lbJumlahPembayaran.Location = new System.Drawing.Point(57, 145);
            this.lbJumlahPembayaran.Name = "lbJumlahPembayaran";
            this.lbJumlahPembayaran.Size = new System.Drawing.Size(32, 33);
            this.lbJumlahPembayaran.TabIndex = 2;
            this.lbJumlahPembayaran.Text = "0";
            this.lbJumlahPembayaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btPENGHUNI);
            this.Controls.Add(this.btDASHBOARD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLOGOUT);
            this.Controls.Add(this.btBACKUP);
            this.Controls.Add(this.btLAPORAN);
            this.Controls.Add(this.btPEMBAYARAN);
            this.Controls.Add(this.btKAMAR);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.textBox2);
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDASHBOARD;
        private System.Windows.Forms.Button btPENGHUNI;
        private System.Windows.Forms.Button btKAMAR;
        private System.Windows.Forms.Button btPEMBAYARAN;
        private System.Windows.Forms.Button btLAPORAN;
        private System.Windows.Forms.Button btBACKUP;
        private System.Windows.Forms.Button btLOGOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbJumlahPenghuni;
        private System.Windows.Forms.Label lbJumlahKamar;
        private System.Windows.Forms.Label lbJumlahPembayaran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}