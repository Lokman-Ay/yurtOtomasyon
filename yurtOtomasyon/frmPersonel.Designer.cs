
namespace yurtOtomasyon
{
    partial class frmPersonel
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
            this.gunaSwitch2 = new Guna.UI.WinForms.GunaSwitch();
            this.gunaSwitch1 = new Guna.UI.WinForms.GunaSwitch();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskDogum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYasadigi = new System.Windows.Forms.ComboBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataPersonel = new Guna.UI.WinForms.GunaDataGridView();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEkle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaSwitch2);
            this.gunaGroupBox1.Controls.Add(this.gunaSwitch1);
            this.gunaGroupBox1.Controls.Add(this.cmbDepartman);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.txtMaas);
            this.gunaGroupBox1.Controls.Add(this.TxtAd);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.MskDogum);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.MskTc);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 446);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(360, 259);
            this.gunaGroupBox1.TabIndex = 33;
            this.gunaGroupBox1.Text = "Kişisel Bilgiler";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaSwitch2
            // 
            this.gunaSwitch2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaSwitch2.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaSwitch2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaSwitch2.FillColor = System.Drawing.Color.White;
            this.gunaSwitch2.Location = new System.Drawing.Point(315, 86);
            this.gunaSwitch2.Name = "gunaSwitch2";
            this.gunaSwitch2.Size = new System.Drawing.Size(42, 32);
            this.gunaSwitch2.TabIndex = 40;
            this.gunaSwitch2.CheckedChanged += new System.EventHandler(this.gunaSwitch2_CheckedChanged);
            // 
            // gunaSwitch1
            // 
            this.gunaSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaSwitch1.Location = new System.Drawing.Point(315, 45);
            this.gunaSwitch1.Name = "gunaSwitch1";
            this.gunaSwitch1.Size = new System.Drawing.Size(42, 32);
            this.gunaSwitch1.TabIndex = 40;
            this.gunaSwitch1.CheckedChanged += new System.EventHandler(this.gunaSwitch1_CheckedChanged);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "Güvenlik",
            "Yemekhane",
            "Çamaşırhane",
            "Kantin",
            "Nizamiye",
            "Kalorifer",
            "Kat Görevlisi"});
            this.cmbDepartman.Location = new System.Drawing.Point(155, 168);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(154, 24);
            this.cmbDepartman.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Departman:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "TC No :";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(155, 209);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(154, 22);
            this.txtMaas.TabIndex = 28;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(155, 84);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(154, 22);
            this.TxtAd.TabIndex = 25;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Maaş:";
            // 
            // MskDogum
            // 
            this.MskDogum.Location = new System.Drawing.Point(155, 125);
            this.MskDogum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskDogum.Mask = "00/00/0000";
            this.MskDogum.Name = "MskDogum";
            this.MskDogum.Size = new System.Drawing.Size(154, 22);
            this.MskDogum.TabIndex = 26;
            this.MskDogum.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(155, 43);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(154, 22);
            this.MskTc.TabIndex = 27;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTc_MaskInputRejected);
            this.MskTc.TextChanged += new System.EventHandler(this.MskTc_TextChanged);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.label4);
            this.gunaGroupBox2.Controls.Add(this.cmbYasadigi);
            this.gunaGroupBox2.Controls.Add(this.TxtMail);
            this.gunaGroupBox2.Controls.Add(this.MskTel);
            this.gunaGroupBox2.Controls.Add(this.label11);
            this.gunaGroupBox2.Controls.Add(this.label16);
            this.gunaGroupBox2.Controls.Add(this.rchAdres);
            this.gunaGroupBox2.Controls.Add(this.label15);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox2.Location = new System.Drawing.Point(407, 446);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 15;
            this.gunaGroupBox2.Size = new System.Drawing.Size(385, 259);
            this.gunaGroupBox2.TabIndex = 35;
            this.gunaGroupBox2.Text = "İletişim Bilgiler";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Telefon:";
            // 
            // cmbYasadigi
            // 
            this.cmbYasadigi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYasadigi.FormattingEnabled = true;
            this.cmbYasadigi.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cmbYasadigi.Location = new System.Drawing.Point(142, 127);
            this.cmbYasadigi.Name = "cmbYasadigi";
            this.cmbYasadigi.Size = new System.Drawing.Size(226, 24);
            this.cmbYasadigi.TabIndex = 28;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(142, 86);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(226, 22);
            this.TxtMail.TabIndex = 30;
            // 
            // MskTel
            // 
            this.MskTel.Location = new System.Drawing.Point(142, 45);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(226, 22);
            this.MskTel.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(18, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Yaşadığı İl:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(18, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Mail:";
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(142, 168);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(226, 82);
            this.rchAdres.TabIndex = 29;
            this.rchAdres.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(18, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Adres:";
            // 
            // dataPersonel
            // 
            this.dataPersonel.AllowUserToAddRows = false;
            this.dataPersonel.AllowUserToDeleteRows = false;
            this.dataPersonel.AllowUserToResizeColumns = false;
            this.dataPersonel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataPersonel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPersonel.BackgroundColor = System.Drawing.Color.White;
            this.dataPersonel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPersonel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataPersonel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPersonel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPersonel.ColumnHeadersHeight = 30;
            this.dataPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPersonel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataPersonel.EnableHeadersVisualStyles = false;
            this.dataPersonel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPersonel.Location = new System.Drawing.Point(12, 12);
            this.dataPersonel.Name = "dataPersonel";
            this.dataPersonel.ReadOnly = true;
            this.dataPersonel.RowHeadersVisible = false;
            this.dataPersonel.RowHeadersWidth = 25;
            this.dataPersonel.RowTemplate.Height = 24;
            this.dataPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPersonel.Size = new System.Drawing.Size(979, 428);
            this.dataPersonel.TabIndex = 40;
            this.dataPersonel.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataPersonel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPersonel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataPersonel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataPersonel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataPersonel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataPersonel.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataPersonel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataPersonel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dataPersonel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPersonel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataPersonel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataPersonel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPersonel.ThemeStyle.HeaderStyle.Height = 30;
            this.dataPersonel.ThemeStyle.ReadOnly = true;
            this.dataPersonel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataPersonel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataPersonel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataPersonel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPersonel.ThemeStyle.RowsStyle.Height = 24;
            this.dataPersonel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataPersonel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataPersonel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPersonel_CellContentClick);
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
            this.btnTemizle.Location = new System.Drawing.Point(841, 662);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.White;
            this.btnTemizle.Radius = 15;
            this.btnTemizle.Size = new System.Drawing.Size(150, 42);
            this.btnTemizle.TabIndex = 36;
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
            this.btnGüncelle.Location = new System.Drawing.Point(841, 446);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.White;
            this.btnGüncelle.Radius = 15;
            this.btnGüncelle.Size = new System.Drawing.Size(150, 42);
            this.btnGüncelle.TabIndex = 37;
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
            this.btnSil.Location = new System.Drawing.Point(841, 590);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.White;
            this.btnSil.Radius = 15;
            this.btnSil.Size = new System.Drawing.Size(150, 42);
            this.btnSil.TabIndex = 38;
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
            this.btnEkle.Location = new System.Drawing.Point(841, 518);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.OnPressedColor = System.Drawing.Color.White;
            this.btnEkle.Radius = 15;
            this.btnEkle.Size = new System.Drawing.Size(150, 42);
            this.btnEkle.TabIndex = 39;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 717);
            this.Controls.Add(this.dataPersonel);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.Text = "frmPersonel";
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaSwitch gunaSwitch2;
        private Guna.UI.WinForms.GunaSwitch gunaSwitch1;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskDogum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYasadigi;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnGüncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnEkle;
        private Guna.UI.WinForms.GunaDataGridView dataPersonel;
    }
}