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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }
            /*
            [PerAd]       
            [PerTc]       
            [PerTel]      
            [PerDogum]    
            [PerDepartman]
            [PerMail]     
            [PerAdres]    
            [PerIlIlce]   
            [PerMaas]     
            */

        public void Personel_listele()
        {
            girisekranı.BaglantiAc();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personel", girisekranı.Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataPersonel.DataSource = dt;
            girisekranı.Baglanti.Close();
        }
        public void HizliAra()
        {

            try
            {
                girisekranı.BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Personel";

                string SorguTcNoİceren = "Select * from Personel where PerTc like '%" + MskTc.Text + "%'";
                string SorguAdİceren = "Select * from Personel where PerAd like '%" + TxtAd.Text + "%'";
                if (gunaSwitch1.Checked == true)
                {
                    SorguTum = SorguTcNoİceren;
                }
                else if (gunaSwitch2.Checked == true)
                {
                    SorguTum = SorguAdİceren;
                }


                SqlDataAdapter da = new SqlDataAdapter(SorguTum, girisekranı.Baglanti);
                da.Fill(ds, "Personel");  //dataadapterın içini dolduruyor 
                dataPersonel.DataSource = ds.Tables["Personel"];
                girisekranı.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

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
                    string Sorgu = "Delete from Personel where PerId=" + dataPersonel.CurrentRow.Cells[0].Value.ToString();
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

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            Personel_listele();
        }
        private void Temizle()
        {
            cmbYasadigi.Text = null;
            MskTc.Text = "";
            MskTel.Text = "";
            rchAdres.Text = "";
            TxtAd.Text = "";
            TxtMail.Text = "";
            MskDogum.Text = "";
            txtMaas.Text = "";
            cmbDepartman.Text = null;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
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

        private void MskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
            Personel_listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" && MskDogum.Text != "" && MskTc.Text != "" && TxtMail.Text != "" && MskTel.Text != "" && cmbDepartman.Text != "" && rchAdres.Text != "" && txtMaas.Text != "" && cmbYasadigi.Text != "")
            {
                girisekranı.BaglantiAc();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE PerTc = @TC", girisekranı.Baglanti);
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
                            string sorgu = "insert into Personel (PerAd,PerTc,PerTel,PerDogum,PerDepartman,PerMail,PerAdres,PerIlIlce,PerMaas) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
                            SqlCommand komut = new SqlCommand(sorgu, girisekranı.Baglanti);

                            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                            komut.Parameters.AddWithValue("@p2", MskTc.Text);
                            komut.Parameters.AddWithValue("@p3", MskTel.Text);
                            komut.Parameters.AddWithValue("@p4", MskDogum.Text);
                            komut.Parameters.AddWithValue("@p5", cmbDepartman.Text);
                            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
                            komut.Parameters.AddWithValue("@p7", rchAdres.Text);
                            komut.Parameters.AddWithValue("@p8", cmbYasadigi.Text);
                            komut.Parameters.AddWithValue("@p9", txtMaas.Text);
                            if (komut.ExecuteNonQuery() > 0)
                                MessageBox.Show("Kayıt Eklendi");
                            
                            Temizle();
                            girisekranı.Baglanti.Close();


                        }
                        catch (Exception exp)
                        {
                            DialogResult d = new DialogResult();
                            d = MessageBox.Show(exp + " Personel Eklenemedi.Veritabanlı sıkıntı olabilir bekleyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            Personel_listele();
        }
       

        private void dataPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtAd.Text = dataPersonel.CurrentRow.Cells[1].Value.ToString();
            MskTc.Text = dataPersonel.CurrentRow.Cells[2].Value.ToString();
            MskTel.Text = dataPersonel.CurrentRow.Cells[3].Value.ToString();
            MskDogum.Text = dataPersonel.CurrentRow.Cells[4].Value.ToString();
            cmbDepartman.Text = dataPersonel.CurrentRow.Cells[5].Value.ToString();
            TxtMail.Text = dataPersonel.CurrentRow.Cells[6].Value.ToString();
            rchAdres.Text = dataPersonel.CurrentRow.Cells[7].Value.ToString();
            cmbYasadigi.Text = dataPersonel.CurrentRow.Cells[8].Value.ToString();
            txtMaas.Text = dataPersonel.CurrentRow.Cells[9].Value.ToString();
        }
         public void KayitDegistir()
         {
            if (TxtAd.Text != "" && MskDogum.Text != "" && MskTc.Text != "" && TxtMail.Text != "" && MskTel.Text != "" && cmbDepartman.Text != "" && rchAdres.Text != "" && txtMaas.Text != "" && cmbYasadigi.Text != "")
            {
                DialogResult dialogResult = DialogResult.OK;
                dialogResult = MessageBox.Show("Bu Kayıttaki Bigileri değiştirmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int kayıt = 0;
                    if (dataPersonel.CurrentRow.Cells[2].Value.ToString() != MskTc.Text)
                    {
                        girisekranı.BaglantiAc();
                        SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Personel WHERE PerTc = @TC", girisekranı.Baglanti);
                        command.Parameters.AddWithValue("@TC", MskTc.Text);
                        kayıt = (int)command.ExecuteScalar();
                        girisekranı.Baglanti.Close();
                    }

                    if (kayıt == 0)
                    {
                        try
                        {
                            girisekranı.BaglantiAc();

                            string Sorgu = "Update Personel Set PerAd=@PerAd,PerDogum=@PerDogum,PerTc=@PerTc,PerDepartman=@PerDepartman,PerMail=@PerMail,PerTel=@PerTel,PerAdres=@PerAdres,PerIlIlce=@PerIlIlce,PerMaas=@PerMaas where PerId=@PerId";
                            SqlCommand DegistirKomut = new SqlCommand(Sorgu, girisekranı.Baglanti);
                            DegistirKomut.Parameters.AddWithValue("@PerAd", TxtAd.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerTc", MskTc.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerTel", MskTel.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerDogum", MskDogum.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerDepartman", cmbDepartman.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerMail", TxtMail.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerAdres", rchAdres.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerIlIlce", cmbYasadigi.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerMaas", txtMaas.Text);
                            DegistirKomut.Parameters.AddWithValue("@PerId", dataPersonel.CurrentRow.Cells[0].Value.ToString());
                            
                            if (DegistirKomut.ExecuteNonQuery() > 0)
                                MessageBox.Show("Kayıt Değitirildi");

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
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
            }
            Personel_listele();



         }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            KayitDegistir();
        }
    }
}
