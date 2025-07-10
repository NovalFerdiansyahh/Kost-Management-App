using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form_kamar: Form
    {
        public Form_kamar()
        {
            InitializeComponent();
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home kamar = new home();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login_Form kamar = new Login_Form();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Laporan kamar = new Form_Laporan();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_pembayaran kamar = new Form_pembayaran();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Penghuni kamar = new Form_Penghuni();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_kamar_Load(object sender, EventArgs e)
        {
            TampilData();
            TampilkanIDBaru();
        }

        private void TampilData()
        {
            using (var db = new DataClassesDataContext())
            {
                dgKAMAR.DataSource = db.Kamars
                    .Select(k => new
                    {
                        k.ID_Kamar,
                        k.NomorKamar,
                        k.Status,
                        k.Harga
                    }).ToList();
            }
        }

        private void TampilkanIDBaru()
        {
            using (var dt = new DataClassesDataContext())
            {
                int idBaru = (dt.Kamars.Any()) ? dt.Kamars.Max(p => p.ID_Kamar) + 1 : 1;
                textBoxID_Kamar.Text = idBaru.ToString();
            }
        }

        private void ClearForm()
        {
            textBoxID_Kamar.Clear();
            textBoxNomorKamar.Clear();
            textBoxStatus.Clear();
            textBoxHarga.Clear();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNomorKamar.Text) ||
                string.IsNullOrWhiteSpace(textBoxStatus.Text) ||
                string.IsNullOrWhiteSpace(textBoxHarga.Text))
            {
                MessageBox.Show("Semua field wajib diisi.");
                return false;
            }

            if (!decimal.TryParse(textBoxHarga.Text, out _))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return false;
            }

            return true;
        }

        private void buttonTAMBAH_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (var db = new DataClassesDataContext())
            {
                var kamar = new Kamar
                {
                    NomorKamar = textBoxNomorKamar.Text,
                    Status = textBoxStatus.Text,
                    Harga = decimal.Parse(textBoxHarga.Text)
                };

                db.Kamars.InsertOnSubmit(kamar);
                db.SubmitChanges();
            }

            MessageBox.Show("Data kamar berhasil ditambahkan.");
            TampilData();
            ClearForm();
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            if (dgKAMAR.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.");
                return;
            }

            int idKamar = (int)dgKAMAR.CurrentRow.Cells["ID_Kamar"].Value;

            using (var db = new DataClassesDataContext())
            {
                var kamar = db.Kamars.SingleOrDefault(k => k.ID_Kamar == idKamar);
                if (kamar != null)
                {
                    kamar.NomorKamar = textBoxNomorKamar.Text;
                    kamar.Status = textBoxStatus.Text;
                    kamar.Harga = decimal.Parse(textBoxHarga.Text);
                    db.SubmitChanges();
                }
            }

            MessageBox.Show("Data kamar berhasil diperbarui.");
            TampilData();
            ClearForm();
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dgKAMAR.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.");
                return;
            }

            int idKamar = (int)dgKAMAR.CurrentRow.Cells["ID_Kamar"].Value;

            var result = MessageBox.Show(
                "Menghapus kamar ini juga akan menghapus semua penghuni dan data pembayaran yang terkait. Anda yakin?",
                "Konfirmasi Hapus Data",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (var db = new DataClassesDataContext())
                {
                    var penghuniList = db.Penghunis.Where(p => p.ID_Kamar == idKamar).ToList();

                    foreach (var penghuni in penghuniList)
                    {
                        var pembayaranList = db.Pembayarans.Where(pb => pb.ID_Penghuni == penghuni.ID_Penghuni);
                        db.Pembayarans.DeleteAllOnSubmit(pembayaranList);

                        db.Penghunis.DeleteOnSubmit(penghuni);
                    }

                    var kamar = db.Kamars.SingleOrDefault(k => k.ID_Kamar == idKamar);
                    if (kamar != null)
                    {
                        db.Kamars.DeleteOnSubmit(kamar);
                    }

                    db.SubmitChanges();

                    MessageBox.Show("Data kamar dan semua data terkait berhasil dihapus.");
                    TampilData();
                    ClearForm();
                }
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan.");
            }

        }

        private void dgKAMAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgKAMAR.Rows[e.RowIndex];

                textBoxID_Kamar.Text = row.Cells["ID_Kamar"].Value.ToString();
                textBoxNomorKamar.Text = row.Cells["NomorKamar"].Value.ToString();
                textBoxStatus.Text = row.Cells["Status"].Value.ToString();
                textBoxHarga.Text = row.Cells["Harga"].Value.ToString();
            }
        }
    }
}
