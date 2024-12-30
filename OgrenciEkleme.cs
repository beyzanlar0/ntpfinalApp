using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;

namespace ntpfinalApp
{
    public partial class Form1 : Form
    {
        private ProjectDbContext dbContext;
        Ogrenci Ogrenci { get; set; }
        public Form1()
        {
            InitializeComponent();
            dbContext = new ProjectDbContext();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new ProjectDbContext())
            {
                try
                {
                    var siniflar = dbContext.Siniflar
                                                    .Select(s => new Sinif
                                                    {
                                                        SinifId = s.SinifId,
                                                        SinifAd = s.SinifAd
                                                    })
                                                    .ToList();

                    comboBox1.DataSource = siniflar;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Numara = txtNumara.Text;
            var seciliSnf = (Sinif)comboBox1.SelectedItem;
            int seciliSinifId = seciliSnf.SinifId;

            using (var context = new ProjectDbContext())
            {
                if (!int.TryParse(Numara, out _))
                {
                    MessageBox.Show("Lütfen tamsayý girin");
                }
                try
                {
                    if (doluMu(seciliSinifId) && txtAd.Text.Trim() != string.Empty && txtNumara.Text.Trim() != string.Empty && txtSoyad.Text.Trim() != string.Empty)
                    {
                        var ogr = new Ogrenci();
                        ogr.Ad = Ad;
                        ogr.Soyad = Soyad;
                        ogr.Numara = Numara;
                        ogr.SinifId = seciliSinifId;
                        context.Ogrenciler.Add(ogr);
                        context.SaveChanges();
                        Ogrenci = ogr;

                        MessageBox.Show("kullanýcý kaydedildi");
                    }
                    else{
                        MessageBox.Show("Tüm alanlarý doldurun- kontenjan dolu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new ProjectDbContext())
            {
                var ogr = Ogrenci;

                var seciliSnf = (Sinif)comboBox1.SelectedItem;
                int seciliSinifId = seciliSnf.SinifId;
                if (doluMu(seciliSinifId) && ogr != null)
                {
                    ogr.Ad = txtAd.Text.Trim();
                    ogr.Soyad = txtSoyad.Text.Trim();
                    ogr.Numara = txtNumara.Text.Trim();

                }
                ctx.Entry(ogr).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "güncelleme baþarýlý" : "güncelleme baþarýsýz");
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            using (var ctx = new ProjectDbContext())
            {
                string ogrNum = txtNumara.Text.Trim();
                try
                {
                    var ogr = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == ogrNum);
                    if (ogr != null)
                    {
                        Ogrenci = ogr;
                        txtAd.Text = ogr.Ad;
                        txtSoyad.Text = ogr.Soyad;

                    }
                    else
                    {
                        MessageBox.Show("Öðrenci bulunamadý");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Numara = txtNumara.Text;
            string SinifAdi = comboBox1.SelectedItem.ToString();
            Form2 dersSecme = new Form2 (Ad , Soyad , Numara , SinifAdi);
            dersSecme.Show();
           
        }
        private bool doluMu(int sinifId)
        {
            using (var context = new ProjectDbContext())
            {
                var sinif = context.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                var kontenjanDoluluk = context.Ogrenciler.Count(o => o.SinifId == sinifId);

                return kontenjanDoluluk >= int.Parse(sinif.SinifKontenjan);
            }

        }
    }
}
