namespace ntpfinalApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            lblSinif = new Label();
            button1 = new Button();
            btn_bul = new Button();
            btn_guncelle = new Button();
            btnKaydet = new Button();
            txtNumara = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            lblNumara = new Label();
            lblSoyad = new Label();
            lblAd = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lblSinif);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btn_bul);
            groupBox1.Controls.Add(btn_guncelle);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtNumara);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(lblNumara);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Location = new Point(218, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 361);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(161, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // lblSinif
            // 
            lblSinif.AutoSize = true;
            lblSinif.Location = new Point(71, 157);
            lblSinif.Name = "lblSinif";
            lblSinif.Size = new Size(30, 15);
            lblSinif.TabIndex = 10;
            lblSinif.Text = "Sınıf";
            // 
            // button1
            // 
            button1.Location = new Point(136, 272);
            button1.Name = "button1";
            button1.Size = new Size(92, 23);
            button1.TabIndex = 9;
            button1.Text = "Ders Seçimi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(238, 225);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(75, 23);
            btn_bul.TabIndex = 8;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(27, 225);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(75, 23);
            btn_guncelle.TabIndex = 7;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(136, 225);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(159, 112);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(100, 23);
            txtNumara.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(159, 73);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(159, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 3;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(63, 112);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(50, 15);
            lblNumara.TabIndex = 2;
            lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(63, 81);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(39, 15);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(63, 41);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(22, 15);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            lblAd.Click += lblAd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKaydet;
        private TextBox txtNumara;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label lblNumara;
        private Label lblSoyad;
        private Label lblAd;
        private Button btn_guncelle;
        private Button button1;
        private Button btn_bul;
        private TextBox txtID;
        private Label lblID;
        private ComboBox comboBox1;
        private Label lblSinif;
    }
}
