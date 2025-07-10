using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class home: Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_kamar kamar = new Form_kamar();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btPENGHUNI_Click(object sender, EventArgs e)
        {
            Form_Penghuni penghuni = new Form_Penghuni();
            penghuni.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btPEMBAYARAN_Click(object sender, EventArgs e)
        {
            Form_pembayaran pembayaran = new Form_pembayaran();
            pembayaran.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btLAPORAN_Click(object sender, EventArgs e)
        {
            Form_Laporan pembayaran = new Form_Laporan();
            pembayaran.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btBACKUP_Click(object sender, EventArgs e)
        {
            BackupDatabase();
        }

        private void BackupDatabase()
        {
            try
            {
                string backupFolder = @"D:\BackupKosan";
                string dbName = "Aplikasi_KOMA";
                string backupFile = Path.Combine(backupFolder, $"{dbName}_{DateTime.Now:yyyyMMdd_HHmmss}.bak");

                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                string connectionString = "Data Source=PANG\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = $@"BACKUP DATABASE [{dbName}] TO DISK = N'{backupFile}'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Backup berhasil disimpan di:\n" + backupFile, "Backup Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal melakukan backup:\n" + ex.Message, "Backup Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TampilStatistik()
        {
            using (var db = new DataClassesDataContext())
            {
                int jumlahPenghuni = db.Penghunis.Count();
                int jumlahKamar = db.Kamars.Count();
                int jumlahPembayaran = db.Pembayarans.Count();

                lbJumlahPenghuni.Text = jumlahPenghuni.ToString();
                lbJumlahKamar.Text = jumlahKamar.ToString();
                lbJumlahPembayaran.Text = jumlahPembayaran.ToString();
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            TampilStatistik();
        }

        private void btLOGOUT_Click(object sender, EventArgs e)
        {
            Login_Form kamar = new Login_Form();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }
    }
}
