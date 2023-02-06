namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(88, 23);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(153, 31);
            this.txt_ad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad:";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(88, 103);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(153, 31);
            this.cmb_brans.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre:";
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(88, 144);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(153, 31);
            this.msk_TC.TabIndex = 4;
            this.msk_TC.ValidatingType = typeof(int);
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(88, 61);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(153, 31);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(88, 187);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(153, 31);
            this.txt_sifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 274);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEkle.Location = new System.Drawing.Point(88, 224);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(59, 34);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnSil.Location = new System.Drawing.Point(182, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(59, 34);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(88, 264);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 34);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(944, 332);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}