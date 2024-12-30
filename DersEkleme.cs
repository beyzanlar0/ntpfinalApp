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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDersAdi.Text.Trim() == string.Empty && txtDersKodu.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tüm alanlar zorunludur.");
                return;
            }
            string DersAdi = txtDersAdi.Text;
            string DersKodu = txtDersKodu.Text;

            using (var context = new ProjectDbContext())
            {
                try
                {
                    var drs = new Ders();
                    drs.DersAd = DersAdi;
                    drs.DersKod = DersKodu;

                    context.Dersler.Add(drs);
                    context.SaveChanges();

                    MessageBox.Show("Ders başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

