using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form_Penghuni: Form
    {
        public Form_Penghuni()
        {
            InitializeComponent();
        }

        private void Form_Penghuni_Load(object sender, EventArgs e)
        {
            TampilData();
            TampilkanIDBaru();
        }

        private void btTAMBAH_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (var dt = new DataClassesDataContext())
            {
                // 1. Tambah penghuni baru
                var penghuni = new Penghuni
                {
                    Nama = textBoxNama.Text,
                    NoHP = textBoxNOHP.Text,
                    Alamat = textBoxAlamat.Text,
                    TanggalMasuk = dateTimePicker1.Value,
                    ID_Kamar = int.Parse(textBoxIDkamar.Text)
                };

                dt.Penghunis.InsertOnSubmit(penghuni);
                dt.SubmitChanges(); // Menyimpan untuk mendapatkan ID_Penghuni

                // 2. Tambah pembayaran otomatis
                var pembayaran = new Pembayaran
                {
                    ID_Penghuni = penghuni.ID_Penghuni,
                    TanggalBayar = DateTime.Now,
                    Jumlah = 500000, // Ganti sesuai tarif kamar jika perlu
                    Keterangan = "Belum Lunas"
                };

                dt.Pembayarans.InsertOnSubmit(pembayaran);
                dt.SubmitChanges();

                // 3. Tampilkan ID
                textBoxID.Text = penghuni.ID_Penghuni.ToString();

                MessageBox.Show("Data penghuni berhasil ditambahkan. Pembayaran otomatis terbuat");
                TampilData();
            }
        }

        private void buttonSIMPAN_Click(object sender, EventArgs e)
        {
            

        }

        

        void TampilData()
        {
            using (var dt = new DataClassesDataContext())
            {
                dataGridView1.DataSource = dt.Penghunis.ToList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!ValidasiInput()) return;

            using (var dt = new DataClassesDataContext())
            {
                int id = int.Parse(textBoxID.Text);
                var penghuni = dt.Penghunis.SingleOrDefault(p => p.ID_Penghuni == id);
                if (penghuni != null)
                {
                    penghuni.Nama = textBoxNama.Text;
                    penghuni.NoHP = textBoxNOHP.Text;
                    penghuni.Alamat = textBoxAlamat.Text;
                    penghuni.TanggalMasuk = dateTimePicker1.Value;
                    penghuni.ID_Kamar = int.Parse(textBoxIDkamar.Text);

                    dt.SubmitChanges();
                    MessageBox.Show("Data berhasil diperbarui.");
                    TampilData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data penghuni tidak ditemukan.");
                }
            }
        }

        private void btnBatalEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxID_PENGGUNA_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text) ||
                string.IsNullOrWhiteSpace(textBoxNama.Text) ||
                string.IsNullOrWhiteSpace(textBoxNOHP.Text) ||
                string.IsNullOrWhiteSpace(textBoxAlamat.Text) ||
                string.IsNullOrWhiteSpace(textBoxIDkamar.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            textBoxNama.Clear();
            textBoxNOHP.Clear();
            textBoxAlamat.Clear();
            textBoxIDkamar.Clear();
            dateTimePicker1.Value = DateTime.Today;
            TampilkanIDBaru();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (var dt = new DataClassesDataContext())
                {
                    int id = int.Parse(textBoxID.Text);
                    var penghuni = dt.Penghunis.SingleOrDefault(p => p.ID_Penghuni == id);
                    if (penghuni != null)
                    {
                        textBoxNama.Text = penghuni.Nama;
                        textBoxNOHP.Text = penghuni.NoHP;
                        textBoxAlamat.Text = penghuni.Alamat;
                        dateTimePicker1.Value = penghuni.TanggalMasuk;
                        textBoxIDkamar.Text = penghuni.ID_Kamar.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var dt = new DataClassesDataContext())
            {
                int id = int.Parse(textBoxID.Text);
                var penghuni = dt.Penghunis.SingleOrDefault(p => p.ID_Penghuni == id);

                if (penghuni != null)
                {
                    // Hapus semua pembayaran yang terkait dengan penghuni ini
                    var pembayaranTerkait = dt.Pembayarans.Where(p => p.ID_Penghuni == id);
                    dt.Pembayarans.DeleteAllOnSubmit(pembayaranTerkait);

                    // Hapus penghuni
                    dt.Penghunis.DeleteOnSubmit(penghuni);

                    dt.SubmitChanges();

                    MessageBox.Show("Data berhasil dihapus.");
                    TampilData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan.");
                }
            }


        }

        private void TampilkanIDBaru()
        {
            using (var dt = new DataClassesDataContext())
            {
                int idBaru = (dt.Penghunis.Any()) ? dt.Penghunis.Max(p => p.ID_Penghuni) + 1 : 1;
                textBoxID.Text = idBaru.ToString();
            }
        }

        private void btDASBOARD_Click(object sender, EventArgs e)
        {
            home kamar = new home();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btKAMAR_Click(object sender, EventArgs e)
        {
            Form_kamar kamar = new Form_kamar();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btPEMBAYARAN_Click(object sender, EventArgs e)
        {
            Form_pembayaran kamar = new Form_pembayaran();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btLAPORAN_Click(object sender, EventArgs e)
        {
            Form_Laporan kamar = new Form_Laporan();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btLOGOUT_Click(object sender, EventArgs e)
        {
            Login_Form kamar = new Login_Form();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }
    }
}
