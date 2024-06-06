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
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }
        public void gider_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Gider", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataYonetici.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        private void ödeme()
        {

            if (TxtOdenen.Text != "" && txtad.Text !="" && dtOdeme.Value !=null )
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("Gider Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                      
                     
                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("insert into Gider (Ödenen,Gadı,ÖTar,Gaciklama) values (@b1,@b2,@b3,@b4)", girisekranı.Baglanti);
                        komut3.Parameters.AddWithValue("@b1", TxtOdenen.Text);
                        komut3.Parameters.AddWithValue("@b2", txtad.Text);
                        komut3.Parameters.AddWithValue("@b3", dtOdeme.Value);
                        komut3.Parameters.AddWithValue("@b4", rchAciklama.Text);

                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("Gider Eklendi");

                       

                        
                        txtad.Text = "";
                        TxtOdenen.Text = "";
                        rchAciklama.Text = "";

                        girisekranı.Baglanti.Close();

                        
                        
                        
                        
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString()+"Gider Eklerken bir sorun oluştu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanları Boş Bırakmayınız");
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void frmGider_Load(object sender, EventArgs e)
        {
            gider_listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ödeme();
            gider_listele();
        }
        private void temizle()
        {
            txtad.Text = "";
            TxtOdenen.Text = "";
            rchAciklama.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void datagider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataYonetici.CurrentRow.Cells[2].Value.ToString();
            TxtOdenen.Text = dataYonetici.CurrentRow.Cells[1].Value.ToString();
            dtOdeme.Value = Convert.ToDateTime(dataYonetici.CurrentRow.Cells[3].Value);
            rchAciklama.Text = dataYonetici.CurrentRow.Cells[4].Value.ToString();
        }
        public void GiderDegistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {                
                try
                {
                    girisekranı.BaglantiAc();
                   
                    string Sorgu = "Update Gider Set Gadı=@Gadı,Ödenen=@Ödenen,Gaciklama=@Gaciklama,ÖTar=@ÖTar where Id=@Id";
                    SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                    DegistirKomut.Parameters.AddWithValue("@Gadı", txtad.Text);
                    DegistirKomut.Parameters.AddWithValue("@Ödenen", TxtOdenen.Text);
                    DegistirKomut.Parameters.AddWithValue("@Gaciklama", rchAciklama.Text);
                    DegistirKomut.Parameters.AddWithValue("@ÖTar", dtOdeme.Value);
                    DegistirKomut.Parameters.AddWithValue("@Id", dataYonetici.CurrentRow.Cells[0].Value.ToString());

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
            if (txtad.Text == "" || TxtOdenen.Text==""|| rchAciklama.Text=="")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                GiderDegistir();

                gider_listele();
             
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
                    string Sorgu = "Delete from Gider where Id=" + dataYonetici.CurrentRow.Cells[0].Value.ToString();
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
            gider_listele();
        }
    }
}
