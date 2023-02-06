namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lnk_bilgiduzenle = new System.Windows.Forms.LinkLabel();
            this.btn_randevual = new System.Windows.Forms.Button();
            this.rch_sikayet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_doktor = new System.Windows.Forms.ComboBox();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TC);
            this.groupBox1.Controls.Add(this.lbl_adsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(117, 37);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(120, 23);
            this.lbl_TC.TabIndex = 5;
            this.lbl_TC.Text = "00000000000";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(117, 80);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(76, 23);
            this.lbl_adsoyad.TabIndex = 5;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.lnk_bilgiduzenle);
            this.groupBox2.Controls.Add(this.btn_randevual);
            this.groupBox2.Controls.Add(this.rch_sikayet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmb_doktor);
            this.groupBox2.Controls.Add(this.cmb_brans);
            this.groupBox2.Location = new System.Drawing.Point(12, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 321);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(82, 26);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(155, 31);
            this.txt_id.TabIndex = 5;
            // 
            // lnk_bilgiduzenle
            // 
            this.lnk_bilgiduzenle.AutoSize = true;
            this.lnk_bilgiduzenle.Location = new System.Drawing.Point(11, 286);
            this.lnk_bilgiduzenle.Name = "lnk_bilgiduzenle";
            this.lnk_bilgiduzenle.Size = new System.Drawing.Size(147, 23);
            this.lnk_bilgiduzenle.TabIndex = 4;
            this.lnk_bilgiduzenle.TabStop = true;
            this.lnk_bilgiduzenle.Text = "Bilgilerini Düzenle";
            this.lnk_bilgiduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_bilgiduzenle_LinkClicked);
            // 
            // btn_randevual
            // 
            this.btn_randevual.Location = new System.Drawing.Point(109, 246);
            this.btn_randevual.Name = "btn_randevual";
            this.btn_randevual.Size = new System.Drawing.Size(105, 37);
            this.btn_randevual.TabIndex = 3;
            this.btn_randevual.Text = "Randevu Al";
            this.btn_randevual.UseVisualStyleBackColor = true;
            this.btn_randevual.Click += new System.EventHandler(this.btn_randevual_Click);
            // 
            // rch_sikayet
            // 
            this.rch_sikayet.Location = new System.Drawing.Point(82, 144);
            this.rch_sikayet.Name = "rch_sikayet";
            this.rch_sikayet.Size = new System.Drawing.Size(155, 96);
            this.rch_sikayet.TabIndex = 2;
            this.rch_sikayet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Şikayet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Doktor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Branş:";
            // 
            // cmb_doktor
            // 
            this.cmb_doktor.FormattingEnabled = true;
            this.cmb_doktor.Location = new System.Drawing.Point(82, 107);
            this.cmb_doktor.Name = "cmb_doktor";
            this.cmb_doktor.Size = new System.Drawing.Size(155, 31);
            this.cmb_doktor.TabIndex = 0;
            this.cmb_doktor.SelectedIndexChanged += new System.EventHandler(this.cmb_doktor_SelectedIndexChanged);
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(82, 63);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(155, 31);
            this.cmb_brans.TabIndex = 0;
            this.cmb_brans.SelectedIndexChanged += new System.EventHandler(this.cmb_brans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(279, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 247);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 217);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(279, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(663, 226);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(657, 196);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1035, 508);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay ";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_randevual;
        private System.Windows.Forms.RichTextBox rch_sikayet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_doktor;
        private System.Windows.Forms.ComboBox cmb_brans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnk_bilgiduzenle;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
    }
}