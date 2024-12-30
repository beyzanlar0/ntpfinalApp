using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntpfinalApp
{
    public partial class Form2 : Form
    {

        private string Ad;
        private string Soyad;
        private string Numara;
        private string SinifAdi;
        public Form2(string Ad, string Soyad, string Numara, string SinifAdi)
        {
            InitializeComponent();
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Numara = Numara;
            this.SinifAdi = SinifAdi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblOgrBilgi.Text = $"Ad Soyad: {Ad} {Soyad}\n" +
                       $"Numara: {Numara}\n" +
                       $"Sınıf: {SinifAdi}";


            using (var context = new ProjectDbContext())
            {
                var Dersler = context.Dersler.ToList();

                dataGridView1.DataSource = Dersler;
            }


            dataGridView1.Columns["DersKod"].HeaderText = "Ders Kod";
            dataGridView1.Columns["DersAd"].HeaderText = "Ders Ad";

            dataGridView1.Columns["DersId"].Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int dersAdIndex = dataGridView1.Columns["DersAd"].Index;
                int dersKodIndex = dataGridView1.Columns["DersKod"].Index;

                string dersAd = selectedRow.Cells[dersAdIndex].Value?.ToString() ?? "Veri yok";
                string dersKod = selectedRow.Cells[dersKodIndex].Value?.ToString() ?? "Veri yok";

                lblSecilenDers.Text = $"Ders Adı: {dersAd}, Ders Kodu: {dersKod}";
                string ogrenciNumarasi = this.Numara;

                using (var context = new ProjectDbContext())
                {

                    var ogrenci = context.Ogrenciler.FirstOrDefault(o => o.Numara == ogrenciNumarasi);

                    if (ogrenci != null)
                    {

                        var ders = context.Dersler.FirstOrDefault(d => d.DersKod == dersKod);

                        if (ders != null)
                        {

                            var ogrenciDers = new OgrenciDers
                            {
                                OgrenciId = ogrenci.OgrenciId,
                                DersId = ders.DersId
                            };


                            context.OgrenciDers.Add(ogrenciDers);
                            context.SaveChanges();

                            MessageBox.Show("Ders başarıyla kaydedildi.");
                        }
                        else
                        {
                            MessageBox.Show("Ders bulunamadı.");
                        }
                    }
                    else
                    {
                        lblSecilenDers.Text = "Lütfen bir satır seçin.";
                    }
                }

            }
        }
    }
}
