using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System.Data.SqlClient;

namespace yurtOtomasyon
{
    public partial class frmİstatistik : Form
    {
        public frmİstatistik()
        {
            InitializeComponent();
        }
        private void gelir_hesapla()
        {

            girisekranı.BaglantiAc();
            // Geçerli ayın başlangıç ve bitiş tarihlerini al
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);

            // SQL sorgusu
            string query = "SELECT SUM(Ödenen) FROM Ödeme WHERE ÖTar >= @FirstDayOfMonth AND ÖTar < @FirstDayOfNextMonth";


            SqlCommand command = new SqlCommand(query, girisekranı.Baglanti);
            
            // Parametreleri ekle
            command.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth);
            command.Parameters.AddWithValue("@FirstDayOfNextMonth", firstDayOfNextMonth);

            
            object result = command.ExecuteScalar();

            // Gelir toplamını hesapla
            double totalIncome = (result != DBNull.Value) ? Convert.ToDouble(result) : 0;
            gelir= totalIncome;
            // Gelir toplamını göster

            girisekranı.Baglanti.Close();
            
        }
        private void Gider_hesapla()
        {

            girisekranı.BaglantiAc();
            // Geçerli ayın başlangıç ve bitiş tarihlerini al
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfNextMonth = firstDayOfMonth.AddMonths(1);

            // SQL sorgusu
            string query = "SELECT SUM(Ödenen) FROM Gider WHERE ÖTar >= @FirstDayOfMonth AND ÖTar < @FirstDayOfNextMonth";


            SqlCommand command = new SqlCommand(query, girisekranı.Baglanti);

            // Parametreleri ekle
            command.Parameters.AddWithValue("@FirstDayOfMonth", firstDayOfMonth);
            command.Parameters.AddWithValue("@FirstDayOfNextMonth", firstDayOfNextMonth);


            object result = command.ExecuteScalar();

            // Gelir toplamını hesapla
            double totalIncome = (result != DBNull.Value) ? Convert.ToDouble(result) : 0;

            gider = totalIncome;


            girisekranı.Baglanti.Close();

        }
        private void GelirliAylariComboBoxaEkle()
        {
            comboBoxAylar.Items.Clear();
            girisekranı.BaglantiAc();
            
            string query = "SELECT DISTINCT DATEADD(month, DATEDIFF(month, 0, ÖTar), 0) AS Ay FROM Gider";
            SqlCommand command = new SqlCommand(query, girisekranı.Baglanti);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime ay = Convert.ToDateTime(reader["Ay"]);
                comboBoxAylar.Items.Add($"{ay.ToString("MMMM")}-{ay.Year}");
            }
            
        }
        double gelir;
        double gider;
        private void LoadChart()
        {
            // Gelir ve Gider değerlerini tanımlayın
            

            // Oranı hesaplayın
            double oran = gelir / gider;

            // PieChart'a veri ekleyin
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Gelir",
                    Values = new ChartValues<double> { gelir },
                    DataLabels = true,
                   
                },
                new PieSeries
                {
                    Title = "Gider",
                    
                    Values = new ChartValues<double> { gider },
                    DataLabels = true
                }
            };
            pieChart1.LegendLocation = LegendLocation.None;
            pieChart1.DefaultLegend.Visibility = System.Windows.Visibility.Hidden;

            // Oranı ekrana yazdırın
           

           
        }

        private void frmİstatistik_Load(object sender, EventArgs e)
        {
            gelir_hesapla();
            Gider_hesapla();
            LoadChart();
            GelirliAylariComboBoxaEkle();
        }

        private void comboBoxAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAylar.SelectedItem != null)
            {
                string secilenAy = comboBoxAylar.SelectedItem.ToString();
                decimal ayGeliri = AyGeliriniGetir(secilenAy);
                decimal ayGideri = AyGideriniGetir(secilenAy);
                gelir = Convert.ToDouble(ayGeliri);
                gider = Convert.ToDouble(ayGideri);
                label1.Text = comboBoxAylar.Text;
                LoadChart();
                GelirliAylariComboBoxaEkle();
            }
        }

        private decimal AyGeliriniGetir(string secilenAy)
        {
            decimal ayGeliri = 0;

            girisekranı.BaglantiAc();
            string query = "SELECT SUM(Ödenen) AS AyGeliri FROM Ödeme WHERE DATEADD(month, DATEDIFF(month, 0, ÖTar), 0) = @SecilenAy";

            SqlCommand command = new SqlCommand(query, girisekranı.Baglanti);
            command.Parameters.AddWithValue("@SecilenAy", DateTime.ParseExact(secilenAy, "MMMM-yyyy", null));

            
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
            {
                ayGeliri = Convert.ToDecimal(result);
            }

            girisekranı.Baglanti.Close();
            return ayGeliri;

        }

        private decimal AyGideriniGetir(string secilenAy)
        {
            decimal ayGideri = 0;

            girisekranı.BaglantiAc();
            string query = "SELECT SUM(Ödenen) AS AyGeliri FROM Gider WHERE DATEADD(month, DATEDIFF(month, 0, ÖTar), 0) = @SecilenAy";


            SqlCommand command = new SqlCommand(query, girisekranı.Baglanti);
            command.Parameters.AddWithValue("@SecilenAy", DateTime.ParseExact(secilenAy, "MMMM-yyyy", null));


            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
            {
                ayGideri = Convert.ToDecimal(result);
            }

            girisekranı.Baglanti.Close();
            return ayGideri;

        }
    }

}
