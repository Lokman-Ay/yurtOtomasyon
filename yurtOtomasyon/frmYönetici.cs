using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yurtOtomasyon
{
    public partial class frmYönetici : Form
    {
        public frmYönetici()
        {
            InitializeComponent();
        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtKAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatü_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Yönetici_Ekle()
        {

            if (txtadsoyad.Text != "" && TxtKAd.Text != "" && txtSifre.Text != "" && cmbStatü.Text!="")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Yönetici Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("insert into Kullanicilar (YoneticiAd,YoneticiSifre,YoneticiStatü,YoneticiAdSoy) values (@b1,@b2,@b3,@b4)", girisekranı.Baglanti);
                        komut3.Parameters.AddWithValue("@b1", TxtKAd.Text);
                        komut3.Parameters.AddWithValue("@b2", txtSifre.Text);
                        komut3.Parameters.AddWithValue("@b3", cmbStatü.Text);
                        komut3.Parameters.AddWithValue("@b4", txtadsoyad.Text);

                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("Gider Eklendi");
                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString() + "Gider Eklerken bir sorun oluştu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }

        }
        private void temizle()
        {

            TxtKAd.Text = "";
            txtSifre.Text = "";
            cmbStatü.Text = "";
            txtadsoyad.Text = "";

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Yönetici_Ekle();
            Yönetici_listele();
        }
        public void Yönetici_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kullanicilar", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataogrenci.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
      

        private void dataogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtKAd.Text = dataogrenci.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dataogrenci.CurrentRow.Cells[2].Value.ToString();
            cmbStatü.Text = dataogrenci.CurrentRow.Cells[3].Value.ToString();
            txtadsoyad.Text = dataogrenci.CurrentRow.Cells[4].Value.ToString();
        }
      
        private void frmYönetici_Load(object sender, EventArgs e)
        {
            Yönetici_listele();
            if (girisekranı.rutbe!="Yönetici")
            {
                btnEkle.Enabled = false;
                btnSil.Enabled = false;
                cmbStatü.Enabled = false;


                girisekranı.BaglantiAc();
                SqlDataAdapter da = new SqlDataAdapter("select * from kullanicilar where YoneticiId=" + girisekranı.ıd, girisekranı.Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataogrenci.DataSource = dt;
                girisekranı.Baglanti.Close();
            }
        }

        public void Yönetici_Degistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();

                    string Sorgu = "Update Kullanicilar Set YoneticiAd=@YoneticiAd,YoneticiSifre=@YoneticiSifre,YoneticiStatü=@YoneticiStatü,YoneticiAdSoy=@YoneticiAdSoy where YoneticiId=@YoneticiId";
                    SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                    DegistirKomut.Parameters.AddWithValue("@YoneticiAd", TxtKAd.Text);
                    DegistirKomut.Parameters.AddWithValue("@YoneticiSifre", txtSifre.Text);
                    DegistirKomut.Parameters.AddWithValue("@YoneticiStatü", cmbStatü.Text);
                    DegistirKomut.Parameters.AddWithValue("@YoneticiAdSoy", txtadsoyad.Text);
                    DegistirKomut.Parameters.AddWithValue("@YoneticiId", dataogrenci.CurrentRow.Cells[0].Value.ToString());

                    if (DegistirKomut.ExecuteNonQuery() > 0)
                        MessageBox.Show("Kayıt değiştirildi");
                    girisekranı.Baglanti.Close();

                }
                catch (Exception Hata)
                {
                    MessageBox.Show(Hata.Message, "Kayıt Değiştir Hata Penceresi");
                }


            }


        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text == "" || TxtKAd.Text == "" || txtSifre.Text == "" || cmbStatü.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                Yönetici_Degistir();

                Yönetici_listele();

            }
        }
        public void KayitSil()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kaydı Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();
                    string Sorgu = "Delete from Kullanicilar where YoneticiId=" + dataogrenci.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand SilKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                    if (SilKomut.ExecuteNonQuery() == 1)
                        MessageBox.Show("Kayıt silindi.");
                    girisekranı.Baglanti.Close();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show(Hata.Message, "Kayıt Sil Hata Penceresi");
                }
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
            Yönetici_listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
