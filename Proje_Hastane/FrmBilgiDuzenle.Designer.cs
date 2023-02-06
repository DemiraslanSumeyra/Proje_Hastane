namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(163, 267);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(202, 57);
            this.btn_bilgiguncelle.TabIndex = 22;
            this.btn_bilgiguncelle.Text = "&Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = false;
            this.btn_bilgiguncelle.Click += new System.EventHandler(this.btn_bilgiguncelle_Click);
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(163, 220);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(202, 31);
            this.cmb_cinsiyet.TabIndex = 6;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(163, 72);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(202, 31);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(163, 183);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(202, 31);
            this.txt_sifre.TabIndex = 5;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(163, 35);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(202, 31);
            this.txt_ad.TabIndex = 1;
            // 
            // msk_telefon
            // 
            this.msk_telefon.Location = new System.Drawing.Point(163, 146);
            this.msk_telefon.Mask = "(999) 000-0000";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(202, 31);
            this.msk_telefon.TabIndex = 4;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(163, 109);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(202, 31);
            this.msk_TC.TabIndex = 3;
            this.msk_TC.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.btn_bilgiguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(416, 348);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.cmb_cinsiyet);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.msk_telefon);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bilgiguncelle;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}