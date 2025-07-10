using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form_Laporan: Form
    {
        public Form_Laporan()
        {
            InitializeComponent();
        }

        private DataClassesDataContext db = new DataClassesDataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            printDocument.PrintPage += (s, ev) =>
            {
                Bitmap bmp = new Bitmap(dgLAPORAN.Width, dgLAPORAN.Height);
                dgLAPORAN.DrawToBitmap(bmp, new Rectangle(0, 0, dgLAPORAN.Width, dgLAPORAN.Height));
                ev.Graphics.DrawImage(bmp, 0, 0);
            };

            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();
        }

        private void dgLAPORAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Laporan_Load(object sender, EventArgs e)
        {
            TampilLaporan();
        }

        private void textBoxFILTER_TextChanged(object sender, EventArgs e)
        {
            TampilLaporan(txtFilter.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TampilLaporan(string filterNama = "")
        {
            var query = from bayar in db.Pembayarans
                        join penghuni in db.Penghunis on bayar.ID_Penghuni equals penghuni.ID_Penghuni
                        join kamar in db.Kamars on penghuni.ID_Kamar equals kamar.ID_Kamar
                        where penghuni.Nama.Contains(filterNama)
                        select new
                        {
                            bayar.ID_Pembayaran,
                            NamaPenghuni = penghuni.Nama,
                            NomorKamar = kamar.NomorKamar,
                            bayar.TanggalBayar,
                            bayar.Jumlah,
                            bayar.Keterangan
                        };

            dgLAPORAN.DataSource = query.ToList();
        }

        private void btDASBOARD_Click(object sender, EventArgs e)
        {
            home kamar = new home();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }

        private void btPENGHUNI_Click(object sender, EventArgs e)
        {
            Form_Penghuni kamar = new Form_Penghuni();
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

        private void btLOGOUT_Click(object sender, EventArgs e)
        {
            Login_Form kamar = new Login_Form();
            kamar.Show(); // Tampilkan halaman penghuni
            this.Hide();
        }
    }
}
