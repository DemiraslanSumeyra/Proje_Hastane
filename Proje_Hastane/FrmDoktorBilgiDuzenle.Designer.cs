namespace Proje_Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.msk_TC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(156, 58);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(202, 31);
            this.txt_soyad.TabIndex = 25;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(156, 175);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(202, 31);
            this.txt_sifre.TabIndex = 26;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(156, 18);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(202, 31);
            this.txt_ad.TabIndex = 27;
            // 
            // msk_TC
            // 
            this.msk_TC.Location = new System.Drawing.Point(156, 138);
            this.msk_TC.Mask = "00000000000";
            this.msk_TC.Name = "msk_TC";
            this.msk_TC.Size = new System.Drawing.Size(202, 31);
            this.msk_TC.TabIndex = 24;
            this.msk_TC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Şifre:";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(156, 98);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(202, 31);
            this.cmb_brans.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Branş:";
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(156, 221);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(202, 57);
            this.btn_bilgiguncelle.TabIndex = 31;
            this.btn_bilgiguncelle.Text = "Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = false;
            this.btn_bilgiguncelle.Click += new System.EventHandler(this.btn_bilgiguncelle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(412, 302);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.msk_TC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.MaskedTextBox msk_TC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_bilgiguncelle;
    }
}