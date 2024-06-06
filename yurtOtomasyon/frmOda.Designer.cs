
namespace yurtOtomasyon
{
    partial class frmOda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataOda = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.OdaDurum = new Guna.UI.WinForms.GunaWinSwitch();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OdaAktif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OdaKapasite = new System.Windows.Forms.TextBox();
            this.btnTemizle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnGüncelle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSil = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEkle = new Guna.UI.WinForms.GunaAdvenceButton();
            this.OdaNo = new System.Windows.Forms.MaskedTextBox();
            this.swioda = new Guna.UI.WinForms.GunaWinSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dataOda)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOda
            // 
            this.dataOda.AllowUserToAddRows = false;
            this.dataOda.AllowUserToDeleteRows = false;
            this.dataOda.AllowUserToResizeColumns = false;
            this.dataOda.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataOda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataOda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataOda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataOda.BackgroundColor = System.Drawing.Color.White;
            this.dataOda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataOda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataOda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataOda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataOda.ColumnHeadersHeight = 30;
            this.dataOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataOda.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataOda.EnableHeadersVisualStyles = false;
            this.dataOda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataOda.Location = new System.Drawing.Point(404, 12);
            this.dataOda.Name = "dataOda";
            this.dataOda.ReadOnly = true;
            this.dataOda.RowHeadersVisible = false;
            this.dataOda.RowHeadersWidth = 25;
            this.dataOda.RowTemplate.Height = 24;
            this.dataOda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOda.Size = new System.Drawing.Size(587, 693);
            this.dataOda.TabIndex = 34;
            this.dataOda.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataOda.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataOda.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataOda.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataOda.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataOda.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataOda.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataOda.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataOda.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dataOda.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataOda.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataOda.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataOda.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataOda.ThemeStyle.HeaderStyle.Height = 30;
            this.dataOda.ThemeStyle.ReadOnly = true;
            this.dataOda.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataOda.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataOda.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataOda.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataOda.ThemeStyle.RowsStyle.Height = 24;
            this.dataOda.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataOda.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataOda_CellContentClick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.swioda);
            this.gunaGroupBox1.Controls.Add(this.OdaNo);
            this.gunaGroupBox1.Controls.Add(this.OdaDurum);
            this.gunaGroupBox1.Controls.Add(this.label13);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.OdaAktif);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.OdaKapasite);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.CornflowerBlue;
            this.gunaGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(375, 254);
            this.gunaGroupBox1.TabIndex = 35;
            this.gunaGroupBox1.Text = "Oda Bilgileri";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // OdaDurum
            // 
            this.OdaDurum.BaseColor = System.Drawing.SystemColors.Control;
            this.OdaDurum.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.OdaDurum.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OdaDurum.FillColor = System.Drawing.Color.White;
            this.OdaDurum.Location = new System.Drawing.Point(194, 206);
            this.OdaDurum.Name = "OdaDurum";
            this.OdaDurum.Size = new System.Drawing.Size(73, 40);
            this.OdaDurum.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(17, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Oda Durum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Oda No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Oda Kapasite:";
            // 
            // OdaAktif
            // 
            this.OdaAktif.Location = new System.Drawing.Point(161, 156);
            this.OdaAktif.Name = "OdaAktif";
            this.OdaAktif.Size = new System.Drawing.Size(154, 22);
            this.OdaAktif.TabIndex = 28;
            this.OdaAktif.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Oda Aktif:";
            // 
            // OdaKapasite
            // 
            this.OdaKapasite.Location = new System.Drawing.Point(161, 110);
            this.OdaKapasite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OdaKapasite.Name = "OdaKapasite";
            this.OdaKapasite.Size = new System.Drawing.Size(154, 22);
            this.OdaKapasite.TabIndex = 25;
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
            this.btnTemizle.Location = new System.Drawing.Point(12, 654);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnTemizle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTemizle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTemizle.OnHoverImage = null;
            this.btnTemizle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTemizle.OnPressedColor = System.Drawing.Color.White;
            this.btnTemizle.Radius = 15;
            this.btnTemizle.Size = new System.Drawing.Size(364, 42);
            this.btnTemizle.TabIndex = 39;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnGüncelle.Location = new System.Drawing.Point(12, 315);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnGüncelle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGüncelle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGüncelle.OnHoverImage = null;
            this.btnGüncelle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnGüncelle.OnPressedColor = System.Drawing.Color.White;
            this.btnGüncelle.Radius = 15;
            this.btnGüncelle.Size = new System.Drawing.Size(364, 42);
            this.btnGüncelle.TabIndex = 40;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSil.Location = new System.Drawing.Point(12, 541);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSil.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSil.OnHoverImage = null;
            this.btnSil.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSil.OnPressedColor = System.Drawing.Color.White;
            this.btnSil.Radius = 15;
            this.btnSil.Size = new System.Drawing.Size(364, 42);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnEkle.Location = new System.Drawing.Point(12, 428);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBaseColor = System.Drawing.Color.RoyalBlue;
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEkle.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEkle.OnHoverImage = null;
            this.btnEkle.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEkle.OnPressedColor = System.Drawing.Color.White;
            this.btnEkle.Radius = 15;
            this.btnEkle.Size = new System.Drawing.Size(364, 42);
            this.btnEkle.TabIndex = 42;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // OdaNo
            // 
            this.OdaNo.Location = new System.Drawing.Point(161, 60);
            this.OdaNo.Mask = "000";
            this.OdaNo.Name = "OdaNo";
            this.OdaNo.Size = new System.Drawing.Size(150, 22);
            this.OdaNo.TabIndex = 38;
            this.OdaNo.TextChanged += new System.EventHandler(this.OdaNo_TextChanged);
            // 
            // swioda
            // 
            this.swioda.BaseColor = System.Drawing.SystemColors.Control;
            this.swioda.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.swioda.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.swioda.FillColor = System.Drawing.Color.White;
            this.swioda.Location = new System.Drawing.Point(317, 60);
            this.swioda.Name = "swioda";
            this.swioda.Size = new System.Drawing.Size(57, 36);
            this.swioda.TabIndex = 39;
            // 
            // frmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1003, 717);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.dataOda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOda";
            this.Text = "frmOda";
            this.Load += new System.EventHandler(this.frmOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOda)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dataOda;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OdaAktif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OdaKapasite;
        private Guna.UI.WinForms.GunaWinSwitch OdaDurum;
        private Guna.UI.WinForms.GunaAdvenceButton btnTemizle;
        private Guna.UI.WinForms.GunaAdvenceButton btnGüncelle;
        private Guna.UI.WinForms.GunaAdvenceButton btnSil;
        private Guna.UI.WinForms.GunaAdvenceButton btnEkle;
        private System.Windows.Forms.MaskedTextBox OdaNo;
        private Guna.UI.WinForms.GunaWinSwitch swioda;
    }
}