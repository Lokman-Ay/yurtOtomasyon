using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yurtOtomasyon
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }
       
        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton1.BackColor = Color.RoyalBlue;
            container(new ogrenci());
        }

        private void container(object _form)
        {
            if (gunaPanel3_container.Controls.Count > 0) gunaPanel3_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle=FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            gunaPanel3_container.Controls.Add(fm);
            gunaPanel3_container.Tag = fm;
            fm.Show();
        }
        
        private void buttoncolor()
        {
            gunaAdvenceButton1.BackColor = Color.White;
            gunaAdvenceButton2.BackColor = Color.White;
            gunaAdvenceButton3.BackColor = Color.White;
            gunaAdvenceButton4.BackColor = Color.White;
            gunaAdvenceButton5.BackColor = Color.White;
            gunaAdvenceButton6.BackColor = Color.White;
            gunaAdvenceButton7.BackColor = Color.White;
            gunaAdvenceButton8.BackColor = Color.White;
            gunaAdvenceButton9.BackColor = Color.White;
        }
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton2.BackColor = Color.RoyalBlue;
            container(new frmÖdemeİslemleri());
        }
       

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            girisekranı.Baglanti.Close();
            Application.Exit();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton4.BackColor = Color.RoyalBlue;
            container(new frmPersonel());
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

            buttoncolor();
            gunaAdvenceButton5.BackColor = Color.RoyalBlue;
            container(new frmGider());
        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton9.BackColor = Color.RoyalBlue;
            container(new frmİzin());
        }
        
        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton8.BackColor = Color.RoyalBlue;
            container(new frmYönetici());
            
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            if (lblrütbe.Text != "Yönetici")
            {
                gunaAdvenceButton3.Enabled = false;
                gunaAdvenceButton4.Enabled = false;
                gunaAdvenceButton5.Enabled = false;
            }
            
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton7.BackColor = Color.RoyalBlue;
            container(new Ariza());
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton3.BackColor = Color.RoyalBlue;
            container(new frmİstatistik());
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            buttoncolor();
            gunaAdvenceButton3.BackColor = Color.RoyalBlue;
            container(new frmOda());
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            girisekranı frmgiris = new girisekranı();
            this.Hide();
            frmgiris.Show();
            
        }
    }
}
