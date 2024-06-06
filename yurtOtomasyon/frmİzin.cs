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
    public partial class frmİzin : Form
    {
        public frmİzin()
        {
            InitializeComponent();
        }

        private void txtBolum_TextChanged(object sender, EventArgs e)
        {

        }
        private void temizle()
        {
            mskogrtel.Text = "";
            mskvelitel.Text = "";
            MskTc.Text = "";
            TxtAd.Text = "";
            txtsebep.Text = "";
            
        }
        public void İzin_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from İzin", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataogrenci.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        private void frmİzin_Load(object sender, EventArgs e)
        {
            İzin_listele();
        }

        private void dataogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mskogrtel.Text = dataogrenci.CurrentRow.Cells[3].Value.ToString();
            mskvelitel.Text = dataogrenci.CurrentRow.Cells[4].Value.ToString();
            MskTc.Text = dataogrenci.CurrentRow.Cells[1].Value.ToString();
            TxtAd.Text = dataogrenci.CurrentRow.Cells[2].Value.ToString();
            txtsebep.Text = dataogrenci.CurrentRow.Cells[5].Value.ToString();
            DateBas.Value = Convert.ToDateTime(dataogrenci.CurrentRow.Cells[6].Value);
            DateBit.Value = Convert.ToDateTime(dataogrenci.CurrentRow.Cells[7].Value);
        }
        private void İzin_Ekle()
        {

            if (MskTc.Text != "" && mskogrtel.Text != "" && mskvelitel.Text != "" && TxtAd.Text != "" && txtsebep.Text != "")
            {

                DialogResult d = new DialogResult();
                d = MessageBox.Show("İzin Eklemek İstediğinize Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        girisekranı.BaglantiAc();
                        SqlCommand komut3 = new SqlCommand("insert into İzin (OgrenciTc,OgrenciAd,OgrenciTel,VeliTel,İzinsebep,İzinBas,İzinBit) values (@OgrenciTc,@OgrenciAd,@OgrenciTel,@VeliTel,@İzinsebep,@İzinBas,@İzinBit)", girisekranı.Baglanti);
                       
                        komut3.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                        komut3.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                        komut3.Parameters.AddWithValue("@OgrenciTel", mskogrtel.Text);
                        komut3.Parameters.AddWithValue("@VeliTel", mskvelitel.Text);
                        komut3.Parameters.AddWithValue("@İzinsebep", txtsebep.Text);
                        komut3.Parameters.AddWithValue("@İzinBas", DateBas.Value);
                        komut3.Parameters.AddWithValue("@İzinBit", DateBit.Value);
                        //komut3.Parameters.AddWithValue("@İzinId", dataogrenci.CurrentRow.Cells[0].Value.ToString());
                        if (komut3.ExecuteNonQuery() > 0)
                            MessageBox.Show("İzin Eklendi");
                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.ToString() + "İzin Eklerken bir sorun oluştu");
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
            İzin_Ekle();
            İzin_listele();
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
                    string Sorgu = "Delete from İzin where İzinId=" + dataogrenci.CurrentRow.Cells[0].Value.ToString();
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
            İzin_listele();
        }

        public void İzin_Degistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    girisekranı.BaglantiAc();

                    string Sorgu = "Update İzin Set OgrenciTc=@OgrenciTc,OgrenciAd=@OgrenciAd,OgrenciTel=@OgrenciTel,VeliTel=@VeliTel,İzinsebep=@İzinsebep,İzinBas=@İzinBas,İzinBit=@İzinBit where İzinId=@İzinId";
                    SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);

                    DegistirKomut.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                    DegistirKomut.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                    DegistirKomut.Parameters.AddWithValue("@OgrenciTel", mskogrtel.Text);
                    DegistirKomut.Parameters.AddWithValue("@VeliTel", mskvelitel.Text);
                    DegistirKomut.Parameters.AddWithValue("@İzinsebep", txtsebep.Text);
                    DegistirKomut.Parameters.AddWithValue("@İzinBas", DateBas.Value);
                    DegistirKomut.Parameters.AddWithValue("@İzinBit", DateBit.Value);
                    DegistirKomut.Parameters.AddWithValue("@İzinId", dataogrenci.CurrentRow.Cells[0].Value.ToString());
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
            if (MskTc.Text == "" || mskogrtel.Text == "" || mskvelitel.Text == "" || TxtAd.Text == "" || txtsebep.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                İzin_Degistir();

                İzin_listele();

            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        public void HizliAra()
        {

            try
            {
                girisekranı.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from İzin";

                string SorguTcNoİceren = "Select * from İzin where OgrenciTc like '%" + MskTc.Text + "%'";
                string SorguAdİceren = "Select * from İzin where OgrenciAd like '%" + TxtAd.Text + "%'";
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
                dataogrenci.DataSource = ds.Tables["Ogrenci"];
                girisekranı.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

            }

        }
        private void gunaSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked == true)
            {
                gunaSwitch1.Checked = false;
            }
        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked == true)
            {
                gunaSwitch2.Checked = false;
            }
        }

        private void MskTc_TextChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true)
            {
                HizliAra();
            }
        }

        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            if (gunaSwitch2.Checked == true)
            {
                HizliAra();
            }
        }

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
