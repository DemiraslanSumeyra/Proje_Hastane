namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.msk_telefon = new System.Windows.Forms.MaskedTextBox();
            this.cmb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kayityap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(155, 27);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(202, 31);
            this.txt_ad.TabIndex = 1;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(155, 101);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(202, 31);
            this.msk_TC.TabIndex = 3;
            this.msk_TC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şifre:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(155, 175);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(202, 31);
            this.txt_sifre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyad:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(155, 64);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(202, 31);
            this.txt_soyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // msk_telefon
            // 
            this.msk_telefon.Location = new System.Drawing.Point(155, 138);
            this.msk_telefon.Mask = "(999) 000-0000";
            this.msk_telefon.Name = "msk_telefon";
            this.msk_telefon.Size = new System.Drawing.Size(202, 31);
            this.msk_telefon.TabIndex = 4;
            // 
            // cmb_cinsiyet
            // 
            this.cmb_cinsiyet.FormattingEnabled = true;
            this.cmb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_cinsiyet.Location = new System.Drawing.Point(155, 212);
            this.cmb_cinsiyet.Name = "cmb_cinsiyet";
            this.cmb_cinsiyet.Size = new System.Drawing.Size(202, 31);
            this.cmb_cinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cinsiyet:";
            // 
            // btn_kayityap
            // 
            this.btn_kayityap.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_kayityap.Location = new System.Drawing.Point(155, 259);
            this.btn_kayityap.Name = "btn_kayityap";
            this.btn_kayityap.Size = new System.Drawing.Size(202, 57);
            this.btn_kayityap.TabIndex = 6;
            this.btn_kayityap.Text = "Kayıt Yap";
            this.btn_kayityap.UseVisualStyleBackColor = false;
            this.btn_kayityap.Click += new System.EventHandler(this.btn_kayityap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btn_kayityap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(403, 358);
            this.Controls.Add(this.btn_kayityap);
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
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox msk_telefon;
        private System.Windows.Forms.ComboBox cmb_cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kayityap;
    }
}