
namespace yurtOtomasyon
{
    partial class frmİzin
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
            this.DateBit = new System.Windows.Forms.DateTimePicker();
            this.gunaSwitch2 = new Guna.UI.WinForms.GunaSwitch();
            this.DateBas = new System.Windows.Forms.DateTimePicker();
            this.gunaSwitch1 = new Guna.UI.WinForms.GunaSwitch();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsebep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.mskogrtel = new System.Windows.Forms.MaskedTextBox();
            this.mskvelitel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.dataogrenci = new Guna.UI.WinForms.GunaDataGridView();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEkle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataogrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.DateBit);
            this.gunaGroupBox1.Controls.Add(this.gunaSwitch2);
            this.gunaGroupBox1.Controls.Add(this.DateBas);
            this.gunaGroupBox1.Controls.Add(this.gunaSwitch1);
            this.gunaGroupBox1.Controls.Add(this.label11);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtsebep);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.TxtAd);
            this.gunaGroupBox1.Controls.Add(this.mskogrtel);
            this.gunaGroupBox1.Controls.Add(this.mskvelitel);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.MskTc);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(21, 386);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(437, 319);
            this.gunaGroupBox1.TabIndex = 32;
            this.gunaGroupBox1.Text = "Kişisel Bilgiler";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // DateBit
            // 
            this.DateBit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBit.Location = new System.Drawing.Point(164, 295);
            this.DateBit.Name = "DateBit";
            this.DateBit.Size = new System.Drawing.Size(206, 22);
            this.DateBit.TabIndex = 35;
            // 
            // gunaSwitch2
            // 
            this.gunaSwitch2.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaSwitch2.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaSwitch2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaSwitch2.FillColor = System.Drawing.Color.White;
            this.gunaSwitch2.Location = new System.Drawing.Point(392, 85);
            this.gunaSwitch2.Name = "gunaSwitch2";
            this.gunaSwitch2.Size = new System.Drawing.Size(42, 32);
            this.gunaSwitch2.TabIndex = 40;
            this.gunaSwitch2.CheckedChanged += new System.EventHandler(this.gunaSwitch2_CheckedChanged);
            // 
            // DateBas
            // 
            this.DateBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBas.Location = new System.Drawing.Point(164, 253);
            this.DateBas.Name = "DateBas";
            this.DateBas.Size = new System.Drawing.Size(206, 22);
            this.DateBas.TabIndex = 34;
            // 
            // gunaSwitch1
            // 
            this.gunaSwitch1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaSwitch1.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.gunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaSwitch1.FillColor = System.Drawing.Color.White;
            this.gunaSwitch1.Location = new System.Drawing.Point(392, 43);
            this.gunaSwitch1.Name = "gunaSwitch1";
            this.gunaSwitch1.Size = new System.Drawing.Size(42, 32);
            this.gunaSwitch1.TabIndex = 40;
            this.gunaSwitch1.CheckedChanged += new System.EventHandler(this.gunaSwitch1_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "İzin Bitiş:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Veli Tel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtsebep
            // 
            this.txtsebep.Location = new System.Drawing.Point(164, 211);
            this.txtsebep.Name = "txtsebep";
            this.txtsebep.Size = new System.Drawing.Size(206, 22);
            this.txtsebep.TabIndex = 28;
            this.txtsebep.TextChanged += new System.EventHandler(this.txtBolum_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "İzin Başlangıç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "İzin Sebebi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Öğrenci TC:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(164, 85);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(206, 22);
            this.TxtAd.TabIndex = 25;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // mskogrtel
            // 
            this.mskogrtel.Location = new System.Drawing.Point(164, 127);
            this.mskogrtel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskogrtel.Mask = "(999) 000-0000";
            this.mskogrtel.Name = "mskogrtel";
            this.mskogrtel.Size = new System.Drawing.Size(206, 22);
            this.mskogrtel.TabIndex = 26;
            // 
            // mskvelitel
            // 
            this.mskvelitel.Location = new System.Drawing.Point(164, 169);
            this.mskvelitel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mskvelitel.Mask = "(999) 000-0000";
            this.mskvelitel.Name = "mskvelitel";
            this.mskvelitel.Size = new System.Drawing.Size(206, 22);
            this.mskvelitel.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ögrenci Tel:";
            // 
            // MskTc
            // 
            this.MskTc.Location = new System.Drawing.Point(164, 43);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(206, 22);
            this.MskTc.TabIndex = 27;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MskTc_MaskInputRejected);
            this.MskTc.TextChanged += new System.EventHandler(this.MskTc_TextChanged);
            // 
            // dataogrenci
            // 
            this.dataogrenci.AllowUserToAddRows = false;
            this.dataogrenci.AllowUserToDeleteRows = false;
            this.dataogrenci.AllowUserToResizeColumns = false;
            this.dataogrenci.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataogrenci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataogrenci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataogrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataogrenci.BackgroundColor = System.Drawing.Color.White;
            this.dataogrenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataogrenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataogrenci.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataogrenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataogrenci.ColumnHeadersHeight = 30;
            this.dataogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataogrenci.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataogrenci.EnableHeadersVisualStyles = false;
            this.dataogrenci.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataogrenci.Location = new System.Drawing.Point(12, 12);
            this.dataogrenci.Name = "dataogrenci";
            this.dataogrenci.ReadOnly = true;
            this.dataogrenci.RowHeadersVisible = false;
            this.dataogrenci.RowHeadersWidth = 25;
            this.dataogrenci.RowTemplate.Height = 24;
            this.dataogrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataogrenci.Size = new System.Drawing.Size(979, 358);
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
            this.btnTemizle.Location = new System.Drawing.Point(583, 662);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.White;
            this.btnTemizle.Radius = 15;
            this.btnTemizle.Size = new System.Drawing.Size(342, 42);
            this.btnTemizle.TabIndex = 34;
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
            this.btnGüncelle.Location = new System.Drawing.Point(583, 386);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.White;
            this.btnGüncelle.Radius = 15;
            this.btnGüncelle.Size = new System.Drawing.Size(342, 42);
            this.btnGüncelle.TabIndex = 35;
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
            this.btnSil.Location = new System.Drawing.Point(583, 570);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.White;
            this.btnSil.Radius = 15;
            this.btnSil.Size = new System.Drawing.Size(342, 42);
            this.btnSil.TabIndex = 36;
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
            this.btnEkle.Location = new System.Drawing.Point(583, 478);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.OnPressedColor = System.Drawing.Color.White;
            this.btnEkle.Radius = 15;
            this.btnEkle.Size = new System.Drawing.Size(342, 42);
            this.btnEkle.TabIndex = 37;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmİzin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 717);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataogrenci);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmİzin";
            this.Text = "frmİzin";
            this.Load += new System.EventHandler(this.frmİzin_Load);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataogrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaSwitch gunaSwitch2;
        private Guna.UI.WinForms.GunaSwitch gunaSwitch1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsebep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox mskvelitel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private Guna.UI.WinForms.GunaDataGridView dataogrenci;
        private System.Windows.Forms.DateTimePicker DateBit;
        private System.Windows.Forms.DateTimePicker DateBas;
        private System.Windows.Forms.MaskedTextBox mskogrtel;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnGüncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnEkle;
    }
}