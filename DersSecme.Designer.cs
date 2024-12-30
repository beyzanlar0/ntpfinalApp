namespace ntpfinalApp
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            lblOgrenciBilgileri = new Label();
            lblOgrBilgi = new Label();
            btnDersKayit = new Button();
            lblSecilenDers = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(740, 207);
            dataGridView1.TabIndex = 0;
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(143, 34);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(0, 15);
            lblOgrenciBilgileri.TabIndex = 1;
            // 
            // lblOgrBilgi
            // 
            lblOgrBilgi.AutoSize = true;
            lblOgrBilgi.Location = new Point(158, 43);
            lblOgrBilgi.Name = "lblOgrBilgi";
            lblOgrBilgi.Size = new Size(0, 15);
            lblOgrBilgi.TabIndex = 3;
            // 
            // btnDersKayit
            // 
            btnDersKayit.Location = new Point(600, 342);
            btnDersKayit.Name = "btnDersKayit";
            btnDersKayit.Size = new Size(114, 40);
            btnDersKayit.TabIndex = 4;
            btnDersKayit.Text = "Dersleri Kaydet";
            btnDersKayit.UseVisualStyleBackColor = true;
            btnDersKayit.Click += btnDersKayit_Click;
            // 
            // lblSecilenDers
            // 
            lblSecilenDers.AutoSize = true;
            lblSecilenDers.Location = new Point(77, 367);
            lblSecilenDers.Name = "lblSecilenDers";
            lblSecilenDers.Size = new Size(0, 15);
            lblSecilenDers.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSecilenDers);
            Controls.Add(btnDersKayit);
            Controls.Add(lblOgrBilgi);
            Controls.Add(lblOgrenciBilgileri);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblOgrenciBilgileri;
        private Label lblOgrBilgi;
        private Button btnDersKayit;
        private Label lblSecilenDers;
    }
}