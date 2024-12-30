namespace ntpfinalApp
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            btnBul = new Button();
            btnKaydet = new Button();
            btnGüncelle = new Button();
            txtDersAdi = new TextBox();
            txtDersKodu = new TextBox();
            lblDersAdi = new Label();
            lblDersKodu = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBul);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(txtDersAdi);
            groupBox1.Controls.Add(txtDersKodu);
            groupBox1.Controls.Add(lblDersAdi);
            groupBox1.Controls.Add(lblDersKodu);
            groupBox1.Location = new Point(207, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 305);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBul
            // 
            btnBul.Location = new Point(261, 196);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(75, 23);
            btnBul.TabIndex = 6;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(150, 196);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(31, 196);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 4;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(175, 124);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(100, 23);
            txtDersAdi.TabIndex = 3;
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(175, 73);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(100, 23);
            txtDersKodu.TabIndex = 2;
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(104, 127);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(51, 15);
            lblDersAdi.TabIndex = 1;
            lblDersAdi.Text = "Ders Adı";
            // 
            // lblDersKodu
            // 
            lblDersKodu.AutoSize = true;
            lblDersKodu.Location = new Point(104, 73);
            lblDersKodu.Name = "lblDersKodu";
            lblDersKodu.Size = new Size(61, 15);
            lblDersKodu.TabIndex = 0;
            lblDersKodu.Text = "Ders Kodu";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBul;
        private Button btnKaydet;
        private Button btnGüncelle;
        private TextBox txtDersAdi;
        private TextBox txtDersKodu;
        private Label lblDersAdi;
        private Label lblDersKodu;
    }
}