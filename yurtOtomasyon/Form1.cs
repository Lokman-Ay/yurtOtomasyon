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
    public partial class girisekranı : Form
    {
        public girisekranı()
        {
            InitializeComponent();
        }
        public static SqlConnection Baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YurtO" +";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
       
        public static void BaglantiAc()
        {
            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                    // MessageBox.Show("Veritabanı bağlantısı açıldı.");
                }
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }
        public static string rutbe, adsoyad,ıd;
        public void giris()
        {
            try
            {
                BaglantiAc();
                SqlCommand komut = new SqlCommand("select YoneticiStatü,YoneticiAdSoy,YoneticiId from Kullanicilar where YoneticiAd=@kad and YoneticiSifre=@sifre", Baglanti);
                komut.Parameters.AddWithValue("@kad", kadtext.Text);
                komut.Parameters.AddWithValue("@sifre", sifretext.Text);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    rutbe = oku["YoneticiStatü"].ToString();
                    adsoyad = oku["YoneticiAdSoy"].ToString();
                    ıd = oku["YoneticiId"].ToString();
                    frmAnaForm fr = new frmAnaForm();
                    fr.lblrütbe.Text = rutbe;
                    fr.lblKadı.Text = adsoyad;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");
                    kadtext.Clear();
                    sifretext.Clear();
                    kadtext.Focus();
                }
                Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }
        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void girisekranı_Load(object sender, EventArgs e)
        {

        }
    }
}
