namespace WindowsFormsApp1
{
    partial class Form_Laporan
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
            this.dgLAPORAN = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLAPORAN)).BeginInit();
            this.SuspendLayout();
            // 
            // btPENGHUNI
            // 
            this.btPENGHUNI.Location = new System.Drawing.Point(25, 122);
            this.btPENGHUNI.Name = "btPENGHUNI";
            this.btPENGHUNI.Size = new System.Drawing.Size(75, 39);
            this.btPENGHUNI.TabIndex = 53;
            this.btPENGHUNI.Text = "Penghuni";
            this.btPENGHUNI.UseVisualStyleBackColor = true;
            this.btPENGHUNI.Click += new System.EventHandler(this.btPENGHUNI_Click);
            // 
            // btDASBOARD
            // 
            this.btDASBOARD.Location = new System.Drawing.Point(25, 73);
            this.btDASBOARD.Name = "btDASBOARD";
            this.btDASBOARD.Size = new System.Drawing.Size(75, 32);
            this.btDASBOARD.TabIndex = 52;
            this.btDASBOARD.Text = "Dasboard";
            this.btDASBOARD.UseVisualStyleBackColor = true;
            this.btDASBOARD.Click += new System.EventHandler(this.btDASBOARD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "KOMA APP";
            // 
            // btLOGOUT
            // 
            this.btLOGOUT.BackColor = System.Drawing.Color.Red;
            this.btLOGOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLOGOUT.Location = new System.Drawing.Point(25, 387);
            this.btLOGOUT.Name = "btLOGOUT";
            this.btLOGOUT.Size = new System.Drawing.Size(75, 40);
            this.btLOGOUT.TabIndex = 58;
            this.btLOGOUT.Text = "Log Out";
            this.btLOGOUT.UseVisualStyleBackColor = false;
            this.btLOGOUT.Click += new System.EventHandler(this.btLOGOUT_Click);
            // 
            // btBACKUP
            // 
            this.btBACKUP.Location = new System.Drawing.Point(25, 306);
            this.btBACKUP.Name = "btBACKUP";
            this.btBACKUP.Size = new System.Drawing.Size(75, 38);
            this.btBACKUP.TabIndex = 57;
            this.btBACKUP.Text = "Backup";
            this.btBACKUP.UseVisualStyleBackColor = true;
            // 
            // btLAPORAN
            // 
            this.btLAPORAN.Location = new System.Drawing.Point(25, 259);
            this.btLAPORAN.Name = "btLAPORAN";
            this.btLAPORAN.Size = new System.Drawing.Size(75, 33);
            this.btLAPORAN.TabIndex = 56;
            this.btLAPORAN.Text = "Laporan";
            this.btLAPORAN.UseVisualStyleBackColor = true;
            // 
            // btPEMBAYARAN
            // 
            this.btPEMBAYARAN.Location = new System.Drawing.Point(25, 214);
            this.btPEMBAYARAN.Name = "btPEMBAYARAN";
            this.btPEMBAYARAN.Size = new System.Drawing.Size(75, 36);
            this.btPEMBAYARAN.TabIndex = 55;
            this.btPEMBAYARAN.Text = "Pembayaran";
            this.btPEMBAYARAN.UseVisualStyleBackColor = true;
            this.btPEMBAYARAN.Click += new System.EventHandler(this.btPEMBAYARAN_Click);
            // 
            // btKAMAR
            // 
            this.btKAMAR.Location = new System.Drawing.Point(25, 174);
            this.btKAMAR.Name = "btKAMAR";
            this.btKAMAR.Size = new System.Drawing.Size(75, 32);
            this.btKAMAR.TabIndex = 54;
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
            this.splitter1.TabIndex = 51;
            this.splitter1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(191, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Laporan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 38);
            this.textBox2.TabIndex = 62;
            // 
            // dgLAPORAN
            // 
            this.dgLAPORAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLAPORAN.Location = new System.Drawing.Point(181, 147);
            this.dgLAPORAN.Name = "dgLAPORAN";
            this.dgLAPORAN.Size = new System.Drawing.Size(598, 280);
            this.dgLAPORAN.TabIndex = 65;
            this.dgLAPORAN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLAPORAN_CellContentClick);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(365, 96);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(117, 29);
            this.btnCetak.TabIndex = 68;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(223, 98);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 27);
            this.txtFilter.TabIndex = 60;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBoxFILTER_TextChanged);
            // 
            // Form_Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dgLAPORAN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btPENGHUNI);
            this.Controls.Add(this.btDASBOARD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btLOGOUT);
            this.Controls.Add(this.btBACKUP);
            this.Controls.Add(this.btLAPORAN);
            this.Controls.Add(this.btPEMBAYARAN);
            this.Controls.Add(this.btKAMAR);
            this.Controls.Add(this.splitter1);
            this.Name = "Form_Laporan";
            this.Text = "Form_Laporan";
            this.Load += new System.EventHandler(this.Form_Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLAPORAN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgLAPORAN;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
    }
}