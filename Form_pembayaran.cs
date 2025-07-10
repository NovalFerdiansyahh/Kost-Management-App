using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_pembayaran: Form
    {
        public Form_pembayaran()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_PENGGUNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void buttonSIMPAN_Click(object sender, EventArgs e)
        //{
        //    string info = $"ID: {textBoxID_Pembayaran.Text}\n" +
        //       $"Penghuni: {textBoxID_Penghuni.Text}\n" +
        //       $"Tanggal: {textBoxTanggalBayar.Text}\n" +
        //       $"Jumlah: {textBoxJumlah.Text}\n" +
        //       $"Keterangan: {textBoxKeterangan.Text}";

        //    MessageBox.Show("Data Disimpan:\n\n" + info, "Simpan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void buttonBATAL_Click(object sender, EventArgs e)
        //{
        //    textBoxID_Pembayaran.Clear();
        //    textBoxID_Penghuni.Clear();
        //    textBoxTanggalBayar.Clear();
        //    textBoxJumlah.Clear();
        //    textBoxKeterangan.Clear();

        //    MessageBox.Show("Form berhasil dikosongkan.", "Batal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void dgKAMAR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgPembayaran.Rows[e.RowIndex];

                textBoxID_Penghuni.Text = row.Cells["ID_Penghuni"].Value.ToString();
                dtTanggalBayar.Value = Convert.ToDateTime(row.Cells["TanggalBayar"].Value);
                textBoxJumlah.Text = row.Cells["Jumlah"].Value.ToString();
                textBoxKeterangan.Text = row.Cells["Keterangan"].Value?.ToString();
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            if (dgPembayaran.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.");
                return;
            }

            int idPembayaran = (int)dgPembayaran.CurrentRow.Cells["ID_Pembayaran"].Value;

            using (var db = new DataClassesDataContext())
            {
                var pembayaran = db.Pembayarans.SingleOrDefault(p => p.ID_Pembayaran == idPembayaran);
                if (pembayaran != null)
                {
                    pembayaran.ID_Penghuni = int.Parse(textBoxID_Penghuni.Text);
                    pembayaran.TanggalBayar = dtTanggalBayar.Value;
                    pembayaran.Jumlah = int.Parse(textBoxJumlah.Text);
                    pembayaran.Keterangan = textBoxKeterangan.Text;

                    db.SubmitChanges();
                }
            }

            MessageBox.Show("Data berhasil diperbarui.");
            TampilData();
            ClearForm();
        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttontambah_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (var db = new DataClassesDataContext())
            {
                var pembayaran = new Pembayaran
                {
                    ID_Penghuni = int.Parse(textBoxID_Penghuni.Text),
                    TanggalBayar = dtTanggalBayar.Value,
                    Jumlah = int.Parse(textBoxJumlah.Text),
                    Keterangan = textBoxKeterangan.Text
                };

                db.Pembayarans.InsertOnSubmit(pembayaran);
                db.SubmitChanges();
            }

            MessageBox.Show("Data berhasil ditambahkan.");
            TampilData();
            ClearForm();
        }

        private void Form_pembayaran_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            using (var db = new DataClassesDataContext())
            {
                dgPembayaran.DataSource = db.Pembayarans
                    .Select(p => new
                    {
                        p.ID_Pembayaran,
                        p.ID_Penghuni,
                        p.TanggalBayar,
                        p.Jumlah,
                        p.Keterangan
                    })
                    .ToList();
            }
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            if (dgPembayaran.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dari tabel terlebih dahulu.");
                return;
            }

            int idPembayaran = (int)dgPembayaran.CurrentRow.Cells["ID_Pembayaran"].Value;

            using (var db = new DataClassesDataContext())
            {
                var pembayaran = db.Pembayarans.SingleOrDefault(p => p.ID_Pembayaran == idPembayaran);
                if (pembayaran != null)
                {
                    db.Pembayarans.DeleteOnSubmit(pembayaran);
                    db.SubmitChanges();
                }
            }

            MessageBox.Show("Data berhasil dihapus.");
            TampilData();
            ClearForm();
        }

        private void ClearForm()
        {
            textBoxID_Pembayaran.Clear();
            textBoxID_Penghuni.Clear();
            dtTanggalBayar.Value = DateTime.Today;
            textBoxJumlah.Clear();
            textBoxKeterangan.Clear();
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxID_Penghuni.Text) ||
                string.IsNullOrWhiteSpace(textBoxJumlah.Text))
            {
                MessageBox.Show("ID Penghuni dan Jumlah wajib diisi.");
                return false;
            }

            if (!decimal.TryParse(textBoxJumlah.Text, out _))
            {
                MessageBox.Show("Jumlah harus berupa angka.");
                return false;
            }

            return true;
        }

        private void btDASBOARD_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show(); 
            this.Hide();
        }

        private void btPENGHUNI_Click(object sender, EventArgs e)
        {
            Form_Penghuni kamar = new Form_Penghuni();
            kamar.Show();
            this.Hide();
        }

        private void btKAMAR_Click(object sender, EventArgs e)
        {
            Form_kamar kamar = new Form_kamar();
            kamar.Show(); 
            this.Hide();
        }

        private void btLOGOUT_Click(object sender, EventArgs e)
        {
            Login_Form kamar = new Login_Form();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btLAPORAN_Click(object sender, EventArgs e)
        {
            Form_Laporan kamar = new Form_Laporan();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }
    }
}
