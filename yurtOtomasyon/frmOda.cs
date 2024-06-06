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
    public partial class frmOda : Form
    {
        public frmOda()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            OdaAktif.Text = "";
            OdaKapasite.Text = "";
            OdaNo.Text = "";
            OdaDurum.Checked = false;
        }
        public void Oda_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Odalar", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataOda.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        private void frmOda_Load(object sender, EventArgs e)
        {
            Oda_listele();
        }


        private void Oda_Ekle()
        {

            if (OdaNo.Text != "" && OdaKapasite.Text != "" && OdaKapasite.Text != "")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Yönetici Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("insert into Odalar (OdaNo,OdaKapasite,OdaAktif,OdaDurum) values (@b1,@b2,@b3,@b4)", girisekranı.Baglanti);
                        komut3.Parameters.AddWithValue("@b1", OdaNo.Text);
                        komut3.Parameters.AddWithValue("@b2", OdaKapasite.Text);
                        komut3.Parameters.AddWithValue("@b3", OdaAktif.Text);
                        komut3.Parameters.AddWithValue("@b4", OdaDurum.Checked);

                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("Oda Eklendi");
                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString() + "Oda Eklerken bir sorun oluştu");
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
            Oda_Ekle();
            Oda_listele();
        }


        public void Oda_Degistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();

                    string Sorgu = "Update Odalar Set OdaNo=@OdaNo,OdaKapasite=@OdaKapasite,OdaAktif=@OdaAktif,OdaDurum=@OdaDurum where OdaId=@Id";
                    SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                    DegistirKomut.Parameters.AddWithValue("@OdaNo", OdaNo.Text);
                    DegistirKomut.Parameters.AddWithValue("@OdaKapasite", OdaKapasite.Text);
                    DegistirKomut.Parameters.AddWithValue("@OdaAktif", OdaAktif.Text);
                    DegistirKomut.Parameters.AddWithValue("@OdaDurum", OdaDurum.Checked);
                    DegistirKomut.Parameters.AddWithValue("@Id", dataOda.CurrentRow.Cells[0].Value.ToString());

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
            if (OdaNo.Text == "" || OdaKapasite.Text == "" || OdaKapasite.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                Oda_Degistir();

                Oda_listele();

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
                    string Sorgu = "Delete from Odalar where OdaId=" + dataOda.CurrentRow.Cells[0].Value.ToString();
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
            Oda_listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OdaNo.Text = dataOda.CurrentRow.Cells[1].Value.ToString();
            OdaKapasite.Text = dataOda.CurrentRow.Cells[2].Value.ToString();
            OdaAktif.Text = dataOda.CurrentRow.Cells[3].Value.ToString();
            OdaDurum.Checked = Convert.ToBoolean(dataOda.CurrentRow.Cells[4].Value);
        }
        public void HizliAra()
        {

            try
            {
                girisekranı.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Odalar";

                string SorguOdaNoİceren = "Select * from Odalar where OdaNo like '%" + OdaNo.Text + "%'";
                
                if (swioda.Checked == true)
                {
                    SorguTum = SorguOdaNoİceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, girisekranı.Baglanti);
                da.Fill(ds, "Ogrenci");  //dataadapterın içini dolduruyor 
                dataOda.DataSource = ds.Tables["Ogrenci"];
                girisekranı.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

            }

        }
        private void OdaNo_TextChanged(object sender, EventArgs e)
        {
            if (swioda.Checked == true)
            {
                HizliAra();
            }
        }
    }
}
