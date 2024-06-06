
namespace yurtOtomasyon
{
    partial class frmÖdemeİslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtOdeme = new System.Windows.Forms.DateTimePicker();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.mskKalan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.dataogrenci = new Guna.UI.WinForms.GunaDataGridView();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEkle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataogrenci)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kalan Borç:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödeme Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödenen Miktar:";
            // 
            // dtOdeme
            // 
            this.dtOdeme.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOdeme.Location = new System.Drawing.Point(174, 220);
            this.dtOdeme.Name = "dtOdeme";
            this.dtOdeme.Size = new System.Drawing.Size(113, 22);
            this.dtOdeme.TabIndex = 2;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaAdvenceButton1);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.TxtAd);
            this.gunaGroupBox1.Controls.Add(this.TxtOdenen);
            this.gunaGroupBox1.Controls.Add(this.mskKalan);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.msktel);
            this.gunaGroupBox1.Controls.Add(this.dtOdeme);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.MskTc);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(290, 348);
            this.gunaGroupBox1.TabIndex = 25;
            this.gunaGroupBox1.Text = "Bilgiler";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(174, 113);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(113, 22);
            this.TxtAd.TabIndex = 38;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Location = new System.Drawing.Point(174, 149);
            this.TxtOdenen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(113, 22);
            this.TxtOdenen.TabIndex = 42;
            // 
            // mskKalan
            // 
            this.mskKalan.Location = new System.Drawing.Point(174, 45);
            this.mskKalan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskKalan.Name = "mskKalan";
            this.mskKalan.Size = new System.Drawing.Size(113, 22);
            this.mskKalan.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Öğrenci TC:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(174, 82);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(113, 22);
            this.MskTc.TabIndex = 39;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // dataogrenci
            // 
            this.dataogrenci.AllowUserToAddRows = false;
            this.dataogrenci.AllowUserToDeleteRows = false;
            this.dataogrenci.AllowUserToResizeColumns = false;
            this.dataogrenci.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataogrenci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataogrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataogrenci.BackgroundColor = System.Drawing.Color.White;
            this.dataogrenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataogrenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataogrenci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataogrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataogrenci.ColumnHeadersHeight = 30;
            this.dataogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataogrenci.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataogrenci.EnableHeadersVisualStyles = false;
            this.dataogrenci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataogrenci.Location = new System.Drawing.Point(308, 0);
            this.dataogrenci.Name = "dataogrenci";
            this.dataogrenci.ReadOnly = true;
            this.dataogrenci.RowHeadersVisible = false;
            this.dataogrenci.RowHeadersWidth = 25;
            this.dataogrenci.RowTemplate.Height = 24;
            this.dataogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataogrenci.Size = new System.Drawing.Size(695, 717);
            this.dataogrenci.TabIndex = 33;
            this.dataogrenci.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataogrenci.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataogrenci.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataogrenci.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataogrenci.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataogrenci.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataogrenci.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataogrenci.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataogrenci.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dataogrenci.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataogrenci.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataogrenci.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataogrenci.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataogrenci.ThemeStyle.HeaderStyle.Height = 30;
            this.dataogrenci.ThemeStyle.ReadOnly = true;
            this.dataogrenci.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataogrenci.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataogrenci.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataogrenci.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataogrenci.ThemeStyle.RowsStyle.Height = 24;
            this.dataogrenci.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataogrenci.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataogrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataogrenci_CellContentClick);
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
            this.btnTemizle.Location = new System.Drawing.Point(66, 250);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.White;
            this.btnTemizle.Radius = 15;
            this.btnTemizle.Size = new System.Drawing.Size(150, 42);
            this.btnTemizle.TabIndex = 39;
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
            this.btnGüncelle.Location = new System.Drawing.Point(66, 58);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.White;
            this.btnGüncelle.Radius = 15;
            this.btnGüncelle.Size = new System.Drawing.Size(150, 42);
            this.btnGüncelle.TabIndex = 40;
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
            this.btnSil.Location = new System.Drawing.Point(66, 186);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.White;
            this.btnSil.Radius = 15;
            this.btnSil.Size = new System.Drawing.Size(150, 42);
            this.btnSil.TabIndex = 41;
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
            this.btnEkle.Location = new System.Drawing.Point(66, 122);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.OnPressedColor = System.Drawing.Color.White;
            this.btnEkle.Radius = 15;
            this.btnEkle.Size = new System.Drawing.Size(150, 42);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(174, 183);
            this.msktel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(113, 22);
            this.msktel.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Öğrenci Tel:";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnGüncelle);
            this.gunaGroupBox2.Controls.Add(this.btnTemizle);
            this.gunaGroupBox2.Controls.Add(this.btnEkle);
            this.gunaGroupBox2.Controls.Add(this.btnSil);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox2.Location = new System.Drawing.Point(9, 396);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 15;
            this.gunaGroupBox2.Size = new System.Drawing.Size(290, 309);
            this.gunaGroupBox2.TabIndex = 43;
            this.gunaGroupBox2.Text = "Borç İşlemleri";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.CornflowerBlue;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::yurtOtomasyon.Properties.Resources.icons8_payment_100;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(63, 284);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Radius = 15;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(150, 42);
            this.gunaAdvenceButton1.TabIndex = 43;
            this.gunaAdvenceButton1.Text = "Ödeme Al";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // frmÖdemeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 717);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.dataogrenci);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmÖdemeİslemleri";
            this.Text = "frmÖdemeİslemleri";
            this.Load += new System.EventHandler(this.frmÖdemeİslemleri_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataogrenci)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtOdeme;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaDataGridView dataogrenci;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.TextBox mskKalan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnGüncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msktel;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}