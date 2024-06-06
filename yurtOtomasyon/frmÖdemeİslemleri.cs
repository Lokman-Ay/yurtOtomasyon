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
    public partial class frmÖdemeİslemleri : Form
    {
        public frmÖdemeİslemleri()
        {
            InitializeComponent();
        }
        public void borc_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Borclar", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataogrenci.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        private void frmÖdemeİslemleri_Load(object sender, EventArgs e)
        {
            borc_listele();
        }

        private void dataogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAd.Text = dataogrenci.CurrentRow.Cells[1].Value.ToString();
            MskTc.Text = dataogrenci.CurrentRow.Cells[3].Value.ToString();
            mskKalan.Text = dataogrenci.CurrentRow.Cells[2].Value.ToString();
            msktel.Text= dataogrenci.CurrentRow.Cells[4].Value.ToString();

        }
        private void ödeme()
        {

            if (MskTc.Text != "")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Borç Güncellemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        int kalanBorc, odenen, yeniBorc;
                        kalanBorc = Convert.ToInt32(mskKalan.Text);
                        odenen = Convert.ToInt32(TxtOdenen.Text);
                        if (odenen <= kalanBorc)
                        {
                            girisekranı.BaglantiAc();
                            yeniBorc = kalanBorc - odenen;
                            SqlCommand komut1 = new SqlCommand("Update Borclar set OgrenciKalanBorc=@p1 where OgrenciTc=@p2", girisekranı.Baglanti);
                            komut1.Parameters.AddWithValue("@p1", yeniBorc);
                            komut1.Parameters.AddWithValue("@p2", MskTc.Text);
                            komut1.ExecuteNonQuery();



                            SqlCommand komut3 = new SqlCommand("insert into Ödeme (Ödenen,TcNo,ÖTar) values (@b2,@b1,@b3)", girisekranı.Baglanti);
                            komut3.Parameters.AddWithValue("@b1", MskTc.Text);
                            komut3.Parameters.AddWithValue("@b2", TxtOdenen.Text);
                            komut3.Parameters.AddWithValue("@b3", dtOdeme.Value);

                            if (komut3.ExecuteNonQuery() > 0)
                                MessageBox.Show("Borç Güncellendi");


                            TxtAd.Text = "";
                            TxtOdenen.Text = "";
                            mskKalan.Text = "";
                            MskTc.Text = "";

                            girisekranı.Baglanti.Close();

                        }
                        else
                        {
                            MessageBox.Show("Mevcut Borcunuzdan daha fazla para ödeyemezsiniz");
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Ödeme Yapılamadı!!! Lütfen Borcunuzdan Fazla Tutar Girmeyiniz!!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kişi Seçtiğinize Emin Olunuz");
            }

        }

        private void Borc_Ekle()
        {

            if (mskKalan.Text != "" && TxtAd.Text != "" && msktel.Text != "" && MskTc.Text!="")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Borç Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {

                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("İnsert İnto Borclar (OgrenciAd,OgrenciKalanBorc,OgrenciTc,OgrenciTel) Values (@b1,@b3,@b2,@b4)", girisekranı.Baglanti);
                        komut3.Parameters.AddWithValue("@b1", TxtAd.Text);
                        komut3.Parameters.AddWithValue("@b2", MskTc.Text);
                        komut3.Parameters.AddWithValue("@b3", mskKalan.Text);
                        komut3.Parameters.AddWithValue("@b4", msktel.Text);
                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("Borc Eklendi");

                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString() + "Borc Eklerken bir sorun oluştu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Borc_Ekle();
            borc_listele();
        }
        public void Borc_Degistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();
                    SqlCommand komut3 = new SqlCommand("Update Borclar set OgrenciAd=@b1,OgrenciKalanBorc=@b3,OgrenciTc=@b2,OgrenciTel=@b4 where OgrId=@b5", girisekranı.Baglanti);
                    komut3.Parameters.AddWithValue("@b1", TxtAd.Text);
                    komut3.Parameters.AddWithValue("@b2", MskTc.Text);
                    komut3.Parameters.AddWithValue("@b3", mskKalan.Text);
                    komut3.Parameters.AddWithValue("@b4", msktel.Text);
                    komut3.Parameters.AddWithValue("@b5", dataogrenci.CurrentRow.Cells[0].Value.ToString());
                    if (komut3.ExecuteNonQuery() > 0)
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
            
            if (TxtAd.Text == "" || TxtOdenen.Text == "" || mskKalan.Text == "" || MskTc.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                Borc_Degistir();
                borc_listele();

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
                    string Sorgu = "Delete from Borclar where Id=" + dataogrenci.CurrentRow.Cells[0].Value.ToString();
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
            borc_listele();
        }

        private void temizle()
        {
            TxtAd.Text = "";
            TxtOdenen.Text = "";
            mskKalan.Text = "";
            MskTc.Text = "";
            msktel.Text = "";

        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            ödeme();
            borc_listele();
        }
    }
}
