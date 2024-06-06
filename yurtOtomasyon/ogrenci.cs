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
    public partial class ogrenci : Form
    {
        public ogrenci()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && MskDogum.Text != "" && MskTc.Text != "" && TxtMail.Text != "" && MskTel.Text != "" && CmbOda.Text != "" && rchAdres.Text != "" && MskVeliTel.Text != "" && txtVeliAd.Text != ""&& cmbYasadigi.Text != "" && cmbDogdugu.Text != "")
            {
                girisekranı.BaglantiAc();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Ogrenci WHERE OgrenciTc = @TC", girisekranı.Baglanti);
                command.Parameters.AddWithValue("@TC", MskTc.Text);
                int existingRecords = (int)command.ExecuteScalar();
                girisekranı.Baglanti.Close();
                if (existingRecords == 0)
                {
                    DialogResult dialogResult = DialogResult.OK;
                    dialogResult = MessageBox.Show("Eklemek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            //Öğrenci Eklemek
                            girisekranı.BaglantiAc();
                            string bolum = txtBolum.Text.Trim().ToUpper();
                            string sorgu = "insert into Ogrenci (OgrenciAd,OgrenciDogum,OgrenciTc,OgrenciBolum," +
                                "OgrenciMail,OgrenciTelefon,OgrenciOdaNo,OgrenciAdres,VeliTel,VeliAd,IlIlce,Dogduguyer) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)";
                            SqlCommand komut = new SqlCommand(sorgu, girisekranı.Baglanti);

                            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                            komut.Parameters.AddWithValue("@p2", MskDogum.Text);
                            komut.Parameters.AddWithValue("@p3", MskTc.Text);
                            komut.Parameters.AddWithValue("@p4", bolum);
                            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
                            komut.Parameters.AddWithValue("@p6", MskTel.Text);
                            komut.Parameters.AddWithValue("@p7", CmbOda.Text);
                            komut.Parameters.AddWithValue("@p8", rchAdres.Text);
                            komut.Parameters.AddWithValue("@p9", MskVeliTel.Text);
                            komut.Parameters.AddWithValue("@p10", txtVeliAd.Text);
                            komut.Parameters.AddWithValue("@p11", cmbYasadigi.Text);
                            komut.Parameters.AddWithValue("@p12", cmbDogdugu.Text);

                            komut.ExecuteNonQuery();


                            //Odadaki aktif kalan kişi sayısını arttırmak
                            SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif = OdaAktif+1 where OdaNo=@h1", girisekranı.Baglanti);
                            komut2.Parameters.AddWithValue("@h1", CmbOda.Text);
                            komut2.ExecuteNonQuery();
                            MessageBox.Show("Öğrenci Eklendi");



                            SqlCommand komut3 = new SqlCommand("insert into Borclar (OgrenciAd,OgrenciKalanBorc,OgrenciTc,OgrenciTel) values (@b2,@b4,@b1,@b3)", girisekranı.Baglanti);
                            komut3.Parameters.AddWithValue("@b1", MskTc.Text);
                            komut3.Parameters.AddWithValue("@b2", TxtAd.Text);
                            komut3.Parameters.AddWithValue("@b3", MskTel.Text);
                            komut3.Parameters.AddWithValue("b4", txtYurtUcreti.Text);
                            komut3.ExecuteNonQuery();


                            txtBolum.Clear();
                            cmbDogdugu.Text = null;
                            cmbYasadigi.Text = null;
                            MskTc.Text = "";
                            MskTel.Text = "";
                            rchAdres.Text = "";
                            txtVeliAd.Text = "";
                            TxtAd.Text = "";
                            TxtMail.Text = "";
                            MskDogum.Text = "";

                            CmbOda.Text = null;
                            txtVeliAd.Text = "";

                            MskVeliTel.Text = "";
                            txtYurtUcreti.Text = "";
                            girisekranı.Baglanti.Close();


                        }
                        catch (Exception exp)
                        {
                            DialogResult d = new DialogResult();
                            d = MessageBox.Show(exp+" Öğrenci Eklenemedi.Veritabanlı sıkıntı olabilir bekleyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                    }

                }
                else
                {
                    girisekranı.Baglanti.Close();
                    MessageBox.Show("bu tc kimlik no ile kayıtlı birisi var ");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            ogrenci_listele();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void ogrenci_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogrenci", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataogrenci.DataSource = dt;
            girisekranı.Baglanti.Close();
        }

        private void ogrenci_Load(object sender, EventArgs e)
        {
            Odalistele();
            ogrenci_listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBolum.Clear();
            cmbDogdugu.Text = null;
            cmbYasadigi.Text = null;
            CmbOda.Text = null;
            MskTc.Text = "";
            MskTel.Text = "";
            rchAdres.Text = "";
            txtVeliAd.Text = "";
            TxtAd.Text = "";
            TxtMail.Text = "";
            MskDogum.Text = "";
            txtVeliAd.Text = "";
            MskVeliTel.Text = "";
            txtYurtUcreti.Text = "";
        }

        private void dataogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlCommand command = new SqlCommand("select OgrenciKalanBorc from Borclar where OgrenciTc=@b1", girisekranı.Baglanti);
            command.Parameters.AddWithValue("@b1", dataogrenci.CurrentRow.Cells[2].Value.ToString());
            girisekranı.Baglanti.Open();
             string toplamBorc = command.ExecuteScalar().ToString();
            girisekranı.Baglanti.Close();

            TxtAd.Text = dataogrenci.CurrentRow.Cells[1].Value.ToString();
            MskTc.Text = dataogrenci.CurrentRow.Cells[2].Value.ToString();
            MskTel.Text = dataogrenci.CurrentRow.Cells[3].Value.ToString();
            MskDogum.Text = dataogrenci.CurrentRow.Cells[4].Value.ToString();
            txtBolum.Text = dataogrenci.CurrentRow.Cells[5].Value.ToString();
            TxtMail.Text = dataogrenci.CurrentRow.Cells[6].Value.ToString();
            label2.Text = dataogrenci.CurrentRow.Cells[7].Value.ToString();
            txtVeliAd.Text = dataogrenci.CurrentRow.Cells[8].Value.ToString();
            MskVeliTel.Text = dataogrenci.CurrentRow.Cells[9].Value.ToString();
            rchAdres.Text = dataogrenci.CurrentRow.Cells[10].Value.ToString();
            cmbYasadigi.Text = dataogrenci.CurrentRow.Cells[11].Value.ToString();
            cmbDogdugu.Text = dataogrenci.CurrentRow.Cells[12].Value.ToString();
            txtYurtUcreti.Text = toplamBorc;

        }

        private void dataogrenci_SelectionChanged(object sender, EventArgs e)
        {
           


        }
        public void Odalistele()
        {
            CmbOda.Items.Clear();
            girisekranı.BaglantiAc();
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar where OdaKapasite != OdaAktif", girisekranı.Baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbOda.Items.Add(dr2[0].ToString());
            }

            girisekranı.Baglanti.Close();
        }
        public void KayitDegistir()
        {
            DialogResult dialogResult = DialogResult.OK;
            dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int kayıt = 0;
                if (dataogrenci.CurrentRow.Cells[2].Value.ToString() != MskTc.Text)
                {
                    girisekranı.BaglantiAc();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Ogrenci WHERE OgrenciTc = @TC", girisekranı.Baglanti);
                    command.Parameters.AddWithValue("@TC", MskTc.Text);
                    kayıt = (int)command.ExecuteScalar();
                    girisekranı.Baglanti.Close();
                }

                if (kayıt == 0)
                {
                    try
                    {
                        girisekranı.BaglantiAc();
                        if (dataogrenci.CurrentRow.Cells[7].Value.ToString() != CmbOda.Text)
                        {
                            SqlCommand komut1 = new SqlCommand("Update Odalar set OdaAktif = OdaAktif-1 where OdaNo=@h1", girisekranı.Baglanti);
                            komut1.Parameters.AddWithValue("@h1", dataogrenci.CurrentRow.Cells[7].Value.ToString());
                            komut1.ExecuteNonQuery();
                            SqlCommand komut2 = new SqlCommand("Update Odalar set OdaAktif = OdaAktif+1 where OdaNo=@h1", girisekranı.Baglanti);
                            komut2.Parameters.AddWithValue("@h1", CmbOda.Text);
                            komut2.ExecuteNonQuery();
                        }
                        string Sorgu = "Update Ogrenci Set OgrenciAd=@OgrenciAd,OgrenciDogum=@OgrenciDogum,OgrenciTc=@OgrenciTc,OgrenciBolum=@OgrenciBolum,OgrenciMail=@OgrenciMail,OgrenciTelefon=@OgrenciTelefon,OgrenciOdaNo=@OgrenciOdaNo,OgrenciAdres=@OgrenciAdres,VeliTel=@VeliTel,VeliAd=@VeliAd,IlIlce=@IlIlce,Dogduguyer=@Dogduguyer where OgrId=@OgrId";
                        SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciDogum", MskDogum.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciBolum", txtBolum.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciMail", TxtMail.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciTelefon", MskTel.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciOdaNo", CmbOda.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrenciAdres", rchAdres.Text);
                        DegistirKomut.Parameters.AddWithValue("@VeliTel", MskVeliTel.Text);
                        DegistirKomut.Parameters.AddWithValue("@VeliAd", txtVeliAd.Text);
                        DegistirKomut.Parameters.AddWithValue("@IlIlce", cmbYasadigi.Text);
                        DegistirKomut.Parameters.AddWithValue("@Dogduguyer", cmbDogdugu.Text);
                        DegistirKomut.Parameters.AddWithValue("@OgrId", dataogrenci.CurrentRow.Cells[0].Value.ToString());
                        DegistirKomut.ExecuteNonQuery();

                        string borcsorgu = "Update Borclar Set  OgrenciAd=@OgrenciAd,OgrenciKalanBorc=@OgrenciKalanBorc,OgrenciTel=@OgrenciTel where OgrenciTc=@OgrenciTc";
                        SqlCommand komut4 = new SqlCommand(borcsorgu, girisekranı.Baglanti);
                        komut4.Parameters.AddWithValue("@OgrenciTc", MskTc.Text);
                        komut4.Parameters.AddWithValue("@OgrenciAd", TxtAd.Text);
                        komut4.Parameters.AddWithValue("@OgrenciTel", MskTel.Text);
                        komut4.Parameters.AddWithValue("@OgrenciKalanBorc", txtYurtUcreti.Text);

                        if (komut4.ExecuteNonQuery() > 0)
                            MessageBox.Show("Kayıt değiştirildi");
                        girisekranı.Baglanti.Close();

                    }
                    catch (Exception Hata)
                    {
                        MessageBox.Show(Hata.Message, "Kayıt Değiştir Hata Penceresi");
                    }

                }
                else
                {
                    girisekranı.Baglanti.Close();
                    MessageBox.Show("bu tc kimlik no ile kayıtlı birisi var ");
                }
            }


        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || txtBolum.Text=="" || MskDogum.Text == "  .  ." || MskTc.Text == "" || TxtMail.Text == "" || MskTel.Text == "(   )    -" || CmbOda.Text == "" || rchAdres.Text == "" || MskVeliTel.Text == "(   )    -" || txtVeliAd.Text  == "" || cmbYasadigi.Text == "" ||  cmbDogdugu.Text == "")
            {
                MessageBox.Show("boş alanları doldurunuz!", "Uyarı");
            }
            else
            {
                KayitDegistir();
                ogrenci_listele();
                Odalistele();
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
                    SqlCommand komut1 = new SqlCommand("Update Odalar set OdaAktif = OdaAktif-1 where OdaNo=@h1", girisekranı.Baglanti);
                    komut1.Parameters.AddWithValue("@h1", dataogrenci.CurrentRow.Cells[7].Value.ToString());
                    komut1.ExecuteNonQuery();

                    string Sorgu = "Delete from Ogrenci where OgrId=" + dataogrenci.CurrentRow.Cells[0].Value.ToString();
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
            ogrenci_listele();
        }
        public void HizliAra()
        {
            
            try
            {
                girisekranı.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Ogrenci";
                
                string SorguTcNoİceren = "Select * from Ogrenci where OgrenciTc like '%" + MskTc.Text + "%'";
                string SorguAdİceren = "Select * from Ogrenci where OgrenciAd like '%" + TxtAd.Text + "%'";                
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
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked==true)
            {
                gunaSwitch1.Checked = false;
            }
        }

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void MskTc_TextChanged(object sender, EventArgs e)
        {
            if ( gunaSwitch1.Checked == true)
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

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (gunaSwitch1.Checked == true && gunaSwitch2.Checked == true)
            {
                gunaSwitch2.Checked = false;
            }
        }
    }
}
