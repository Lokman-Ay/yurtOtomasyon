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
    public partial class Ariza : Form
    {
        public Ariza()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            TxtAd.Text = "";
            MskTc.Text = "";
            txtArizAd.Text = "";
            CmbOda.Text = "";
            rchAciklama.Text = "";
        }
        public void Odalistele()
        {
            CmbOda.Items.Clear();
            girisekranı.BaglantiAc();
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar ", girisekranı.Baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }

            girisekranı.Baglanti.Close();
        }
        public void Ariza_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ariza", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataAriza.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        private void Ariza_Load(object sender, EventArgs e)
        {
            Ariza_listele();
            Odalistele();
        }
        private void Ariza_Ekle()
        {

            if (MskTc.Text != "" && TxtAd.Text != "" && txtArizAd.Text != "" && rchAciklama.Text != "" && CmbOda.Text != "")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("İzin Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("insert into Ariza (OgrenciAd,OgrenciTc,ArizaAdi,ArizaOdaNo,ArizaAciklama,ArizaTar) values (@OgrenciAd,@OgrenciTc,@ArizaAdi,@ArizaOdaNo,@ArizaAciklama,@ArizaTar)", girisekranı.Baglanti);

                        komut3.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                        komut3.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                        komut3.Parameters.AddWithValue("@ArizaAdi", txtArizAd.Text);
                        komut3.Parameters.AddWithValue("@ArizaOdaNo", CmbOda.Text);
                        komut3.Parameters.AddWithValue("@ArizaAciklama", rchAciklama.Text);
                        komut3.Parameters.AddWithValue("@ArizaTar", DateAriza.Value);

                        //komut3.Parameters.AddWithValue("@İzinId", dataogrenci.CurrentRow.Cells[0].Value.ToString());
                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("Arıza Eklendi");
                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString() + "Arıza Eklerken bir sorun oluştu");
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
            Ariza_Ekle();
            Ariza_listele();
        }
        public void Ariza_Degistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();

                    string Sorgu = "Update Ariza Set OgrenciTc=@OgrenciTc,OgrenciAd=@OgrenciAd,ArizaAdi=@ArizaAdi,ArizaOdaNo=@ArizaOdaNo,ArizaAciklama=@ArizaAciklama,ArizaTar=@ArizaTar where Id=@Id";
                    SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);

                    DegistirKomut.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                    DegistirKomut.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                    DegistirKomut.Parameters.AddWithValue("@ArizaAdi", txtArizAd.Text);
                    DegistirKomut.Parameters.AddWithValue("@ArizaOdaNo", CmbOda.Text);
                    DegistirKomut.Parameters.AddWithValue("@ArizaAciklama", rchAciklama.Text);
                    DegistirKomut.Parameters.AddWithValue("@ArizaTar", DateAriza.Value);
                    DegistirKomut.Parameters.AddWithValue("@Id", dataAriza.CurrentRow.Cells[0].Value.ToString());
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
            if (MskTc.Text == "" || TxtAd.Text == "" || txtArizAd.Text == "" || rchAciklama.Text == "" || CmbOda.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                Ariza_Degistir();

                Ariza_listele();

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
                    string Sorgu = "Delete from Ariza where Id=" + dataAriza.CurrentRow.Cells[0].Value.ToString();
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
            Ariza_listele();
        }


        private void dataAriza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAd.Text = dataAriza.CurrentRow.Cells[1].Value.ToString();
            MskTc.Text = dataAriza.CurrentRow.Cells[2].Value.ToString();
            txtArizAd.Text = dataAriza.CurrentRow.Cells[3].Value.ToString();
            CmbOda.Text = dataAriza.CurrentRow.Cells[4].Value.ToString();
            rchAciklama.Text = dataAriza.CurrentRow.Cells[5].Value.ToString();
            DateAriza.Value = Convert.ToDateTime(dataAriza.CurrentRow.Cells[6].Value);
        }

        public void HizliAra()
        {

            try
            {
                girisekranı.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Ariza";

                string SorguTcNoİceren = "Select * from Ariza where OgrenciTc like '%" + MskTc.Text + "%'";
                string SorguAdİceren = "Select * from Ariza where OgrenciAd like '%" + TxtAd.Text + "%'";
                if (gunaSwitch1.Checked == true)
                {
                    SorguTum = SorguTcNoİceren;
                }
                else if (gunaSwitch2.Checked == true)
                {
                    SorguTum = SorguAdİceren;
                }


                SqlDataAdapter da = new SqlDataAdapter(SorguTum, girisekranı.Baglanti);
                da.Fill(ds, "Ogrenci");  //dataadapterın içini dolduruyor 
                dataAriza.DataSource = ds.Tables["Ogrenci"];
                girisekranı.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

            }

        }
        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked == true)
            {
                gunaSwitch2.Checked = false;
            }
        }

        private void gunaSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked == true)
            {
                gunaSwitch1.Checked = false;
            }
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            if (gunaSwitch2.Checked == true)
            {
                HizliAra();
            }
        }

        private void MskTc_TextChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true)
            {
                HizliAra();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
