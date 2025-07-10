namespace WindowsFormsApp1
{
    partial class Form_kamar
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btPENGHUNI = new System.Windows.Forms.Button();
            this.btKAMAR = new System.Windows.Forms.Button();
            this.btPEMBAYARAN = new System.Windows.Forms.Button();
            this.btLAPORAN = new System.Windows.Forms.Button();
            this.btBACKUP = new System.Windows.Forms.Button();
            this.btLOGOUT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btDASBOARD = new System.Windows.Forms.Button();
            this.dgKAMAR = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonEDIT = new System.Windows.Forms.Button();
            this.buttonTAMBAH = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.textBoxID_Kamar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomorKamar = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKAMAR)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(127, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // btPENGHUNI
            // 
            this.btPENGHUNI.Location = new System.Drawing.Point(23, 128);
            this.btPENGHUNI.Name = "btPENGHUNI";
            this.btPENGHUNI.Size = new System.Drawing.Size(75, 39);
            this.btPENGHUNI.TabIndex = 27;
            this.btPENGHUNI.Text = "Penghuni";
            this.btPENGHUNI.UseVisualStyleBackColor = true;
            this.btPENGHUNI.Click += new System.EventHandler(this.button2_Click);
            // 
            // btKAMAR
            // 
            this.btKAMAR.Location = new System.Drawing.Point(23, 180);
            this.btKAMAR.Name = "btKAMAR";
            this.btKAMAR.Size = new System.Drawing.Size(75, 32);
            this.btKAMAR.TabIndex = 28;
            this.btKAMAR.Text = "Kamar";
            this.btKAMAR.UseVisualStyleBackColor = true;
            this.btKAMAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // btPEMBAYARAN
            // 
            this.btPEMBAYARAN.Location = new System.Drawing.Point(23, 220);
            this.btPEMBAYARAN.Name = "btPEMBAYARAN";
            this.btPEMBAYARAN.Size = new System.Drawing.Size(75, 36);
            this.btPEMBAYARAN.TabIndex = 29;
            this.btPEMBAYARAN.Text = "Pembayaran";
            this.btPEMBAYARAN.UseVisualStyleBackColor = true;
            this.btPEMBAYARAN.Click += new System.EventHandler(this.button4_Click);
            // 
            // btLAPORAN
            // 
            this.btLAPORAN.Location = new System.Drawing.Point(23, 265);
            this.btLAPORAN.Name = "btLAPORAN";
            this.btLAPORAN.Size = new System.Drawing.Size(75, 33);
            this.btLAPORAN.TabIndex = 30;
            this.btLAPORAN.Text = "Laporan";
            this.btLAPORAN.UseVisualStyleBackColor = true;
            this.btLAPORAN.Click += new System.EventHandler(this.button5_Click);
            // 
            // btBACKUP
            // 
            this.btBACKUP.Location = new System.Drawing.Point(23, 312);
            this.btBACKUP.Name = "btBACKUP";
            this.btBACKUP.Size = new System.Drawing.Size(75, 38);
            this.btBACKUP.TabIndex = 31;
            this.btBACKUP.Text = "Backup";
            this.btBACKUP.UseVisualStyleBackColor = true;
            this.btBACKUP.Click += new System.EventHandler(this.button6_Click);
            // 
            // btLOGOUT
            // 
            this.btLOGOUT.BackColor = System.Drawing.Color.Red;
            this.btLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLOGOUT.Location = new System.Drawing.Point(23, 393);
            this.btLOGOUT.Name = "btLOGOUT";
            this.btLOGOUT.Size = new System.Drawing.Size(75, 40);
            this.btLOGOUT.TabIndex = 32;
            this.btLOGOUT.Text = "Log Out";
            this.btLOGOUT.UseVisualStyleBackColor = false;
            this.btLOGOUT.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "KOMA APP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btDASBOARD
            // 
            this.btDASBOARD.Location = new System.Drawing.Point(23, 79);
            this.btDASBOARD.Name = "btDASBOARD";
            this.btDASBOARD.Size = new System.Drawing.Size(75, 32);
            this.btDASBOARD.TabIndex = 26;
            this.btDASBOARD.Text = "Dasboard";
            this.btDASBOARD.UseVisualStyleBackColor = true;
            this.btDASBOARD.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgKAMAR
            // 
            this.dgKAMAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKAMAR.Location = new System.Drawing.Point(169, 220);
            this.dgKAMAR.Name = "dgKAMAR";
            this.dgKAMAR.Size = new System.Drawing.Size(605, 218);
            this.dgKAMAR.TabIndex = 37;
            this.dgKAMAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKAMAR_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "Kamar";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 38);
            this.textBox2.TabIndex = 42;
            // 
            // buttonEDIT
            // 
            this.buttonEDIT.Location = new System.Drawing.Point(544, 188);
            this.buttonEDIT.Name = "buttonEDIT";
            this.buttonEDIT.Size = new System.Drawing.Size(67, 26);
            this.buttonEDIT.TabIndex = 66;
            this.buttonEDIT.Text = "Edit";
            this.buttonEDIT.UseVisualStyleBackColor = true;
            this.buttonEDIT.Click += new System.EventHandler(this.buttonEDIT_Click);
            // 
            // buttonTAMBAH
            // 
            this.buttonTAMBAH.Location = new System.Drawing.Point(471, 188);
            this.buttonTAMBAH.Name = "buttonTAMBAH";
            this.buttonTAMBAH.Size = new System.Drawing.Size(67, 26);
            this.buttonTAMBAH.TabIndex = 66;
            this.buttonTAMBAH.Text = "Tambah";
            this.buttonTAMBAH.UseVisualStyleBackColor = true;
            this.buttonTAMBAH.Click += new System.EventHandler(this.buttonTAMBAH_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(617, 188);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(67, 26);
            this.buttonDELETE.TabIndex = 66;
            this.buttonDELETE.Text = "Delete";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // textBoxID_Kamar
            // 
            this.textBoxID_Kamar.Location = new System.Drawing.Point(267, 77);
            this.textBoxID_Kamar.Multiline = true;
            this.textBoxID_Kamar.Name = "textBoxID_Kamar";
            this.textBoxID_Kamar.Size = new System.Drawing.Size(100, 20);
            this.textBoxID_Kamar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(170, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_Kamar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(170, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NomorKamar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(170, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(172, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga";
            // 
            // textBoxNomorKamar
            // 
            this.textBoxNomorKamar.Location = new System.Drawing.Point(267, 113);
            this.textBoxNomorKamar.Multiline = true;
            this.textBoxNomorKamar.Name = "textBoxNomorKamar";
            this.textBoxNomorKamar.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomorKamar.TabIndex = 7;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(267, 146);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(100, 20);
            this.textBoxStatus.TabIndex = 8;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(267, 179);
            this.textBoxHarga.Multiline = true;
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.textBoxHarga.TabIndex = 9;
            // 
            // Form_kamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonTAMBAH);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.buttonEDIT);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.textBoxNomorKamar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID_Kamar);
            this.Controls.Add(this.dgKAMAR);
            this.Controls.Add(this.btPENGHUNI);
            this.Controls.Add(this.btDASBOARD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLOGOUT);
            this.Controls.Add(this.btBACKUP);
            this.Controls.Add(this.btLAPORAN);
            this.Controls.Add(this.btPEMBAYARAN);
            this.Controls.Add(this.btKAMAR);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_kamar";
            this.Text = "Form_kamar";
            this.Load += new System.EventHandler(this.Form_kamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKAMAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btPENGHUNI;
        private System.Windows.Forms.Button btKAMAR;
        private System.Windows.Forms.Button btPEMBAYARAN;
        private System.Windows.Forms.Button btLAPORAN;
        private System.Windows.Forms.Button btBACKUP;
        private System.Windows.Forms.Button btLOGOUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btDASBOARD;
        private System.Windows.Forms.DataGridView dgKAMAR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonEDIT;
        private System.Windows.Forms.Button buttonTAMBAH;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.TextBox textBoxID_Kamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNomorKamar;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxHarga;
    }
}