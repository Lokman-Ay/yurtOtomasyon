
namespace yurtOtomasyon
{
    partial class frmGider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.rchAciklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOdeme = new System.Windows.Forms.DateTimePicker();
            this.dataYonetici = new Guna.UI.WinForms.GunaDataGridView();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEkle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataYonetici)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.rchAciklama);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.TxtOdenen);
            this.gunaGroupBox1.Controls.Add(this.txtad);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.dtOdeme);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(303, 384);
            this.gunaGroupBox1.TabIndex = 26;
            this.gunaGroupBox1.Text = "Bilgiler";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // rchAciklama
            // 
            this.rchAciklama.Location = new System.Drawing.Point(7, 233);
            this.rchAciklama.Name = "rchAciklama";
            this.rchAciklama.Size = new System.Drawing.Size(287, 133);
            this.rchAciklama.TabIndex = 43;
            this.rchAciklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Gider Adı:";
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Location = new System.Drawing.Point(160, 91);
            this.TxtOdenen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(130, 22);
            this.TxtOdenen.TabIndex = 42;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(160, 45);
            this.txtad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(130, 22);
            this.txtad.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Gider Açıklaması";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödenen Miktar:";
            // 
            // dtOdeme
            // 
            this.dtOdeme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOdeme.Location = new System.Drawing.Point(160, 147);
            this.dtOdeme.Name = "dtOdeme";
            this.dtOdeme.Size = new System.Drawing.Size(130, 22);
            this.dtOdeme.TabIndex = 2;
            this.dtOdeme.Value = new System.DateTime(2024, 5, 31, 23, 45, 40, 0);
            // 
            // dataYonetici
            // 
            this.dataYonetici.AllowUserToAddRows = false;
            this.dataYonetici.AllowUserToDeleteRows = false;
            this.dataYonetici.AllowUserToResizeColumns = false;
            this.dataYonetici.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataYonetici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataYonetici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataYonetici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataYonetici.BackgroundColor = System.Drawing.Color.White;
            this.dataYonetici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataYonetici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataYonetici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataYonetici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataYonetici.ColumnHeadersHeight = 30;
            this.dataYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataYonetici.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataYonetici.EnableHeadersVisualStyles = false;
            this.dataYonetici.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataYonetici.Location = new System.Drawing.Point(312, 7);
            this.dataYonetici.Name = "dataYonetici";
            this.dataYonetici.ReadOnly = true;
            this.dataYonetici.RowHeadersVisible = false;
            this.dataYonetici.RowHeadersWidth = 25;
            this.dataYonetici.RowTemplate.Height = 24;
            this.dataYonetici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataYonetici.Size = new System.Drawing.Size(683, 698);
            this.dataYonetici.TabIndex = 34;
            this.dataYonetici.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataYonetici.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataYonetici.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataYonetici.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataYonetici.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataYonetici.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataYonetici.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataYonetici.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataYonetici.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dataYonetici.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataYonetici.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataYonetici.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataYonetici.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataYonetici.ThemeStyle.HeaderStyle.Height = 30;
            this.dataYonetici.ThemeStyle.ReadOnly = true;
            this.dataYonetici.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataYonetici.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataYonetici.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataYonetici.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataYonetici.ThemeStyle.RowsStyle.Height = 24;
            this.dataYonetici.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataYonetici.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataYonetici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagider_CellContentClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTemizle.AnimationHoverSpeed = 0.07F;
            this.btnTemizle.AnimationSpeed = 0.03F;
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnTemizle.BorderColor = System.Drawing.Color.Black;
            this.btnTemizle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTemizle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.CheckedForeColor = System.Drawing.Color.White;
            this.btnTemizle.CheckedImage = null;
            this.btnTemizle.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTemizle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTemizle.FocusedColor = System.Drawing.Color.Empty;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTemizle.ForeColor = System.Drawing.Color.White;
            this.btnTemizle.Image = global::yurtOtomasyon.Properties.Resources.icons8_clear_100;
            this.btnTemizle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTemizle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.Location = new System.Drawing.Point(70, 648);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.White;
            this.btnTemizle.Radius = 15;
            this.btnTemizle.Size = new System.Drawing.Size(150, 42);
            this.btnTemizle.TabIndex = 35;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGüncelle.AnimationHoverSpeed = 0.07F;
            this.btnGüncelle.AnimationSpeed = 0.03F;
            this.btnGüncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGüncelle.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnGüncelle.BorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnGüncelle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.CheckedForeColor = System.Drawing.Color.White;
            this.btnGüncelle.CheckedImage = null;
            this.btnGüncelle.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnGüncelle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGüncelle.FocusedColor = System.Drawing.Color.Empty;
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGüncelle.ForeColor = System.Drawing.Color.White;
            this.btnGüncelle.Image = global::yurtOtomasyon.Properties.Resources.icons8_update_64;
            this.btnGüncelle.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGüncelle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.Location = new System.Drawing.Point(70, 418);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.White;
            this.btnGüncelle.Radius = 15;
            this.btnGüncelle.Size = new System.Drawing.Size(150, 42);
            this.btnGüncelle.TabIndex = 36;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSil.AnimationHoverSpeed = 0.07F;
            this.btnSil.AnimationSpeed = 0.03F;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnSil.BorderColor = System.Drawing.Color.Black;
            this.btnSil.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSil.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSil.CheckedForeColor = System.Drawing.Color.White;
            this.btnSil.CheckedImage = null;
            this.btnSil.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSil.FocusedColor = System.Drawing.Color.Empty;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Image = global::yurtOtomasyon.Properties.Resources.icons8_delete_96;
            this.btnSil.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSil.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.Location = new System.Drawing.Point(70, 583);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.White;
            this.btnSil.Radius = 15;
            this.btnSil.Size = new System.Drawing.Size(150, 42);
            this.btnSil.TabIndex = 37;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.AnimationHoverSpeed = 0.07F;
            this.btnEkle.AnimationSpeed = 0.03F;
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.btnEkle.BorderColor = System.Drawing.Color.Black;
            this.btnEkle.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEkle.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEkle.CheckedForeColor = System.Drawing.Color.White;
            this.btnEkle.CheckedImage = null;
            this.btnEkle.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEkle.FocusedColor = System.Drawing.Color.Empty;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Image = global::yurtOtomasyon.Properties.Resources.icons8_add_96;
            this.btnEkle.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEkle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.Location = new System.Drawing.Point(70, 498);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.OnPressedColor = System.Drawing.Color.White;
            this.btnEkle.Radius = 15;
            this.btnEkle.Size = new System.Drawing.Size(150, 42);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 717);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataYonetici);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGider";
            this.Text = "frmGider";
            this.Load += new System.EventHandler(this.frmGider_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataYonetici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOdeme;
        private System.Windows.Forms.RichTextBox rchAciklama;
        private Guna.UI.WinForms.GunaDataGridView dataYonetici;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnGüncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnEkle;
    }
}