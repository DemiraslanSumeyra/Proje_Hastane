namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rch_sikayet = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_duyurular = new System.Windows.Forms.Button();
            this.btn_bilgiduzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(273, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(106, 38);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(120, 23);
            this.lbl_TC.TabIndex = 6;
            this.lbl_TC.Text = "00000000000";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(106, 81);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(76, 23);
            this.lbl_adsoyad.TabIndex = 7;
            this.lbl_adsoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rch_sikayet);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rch_sikayet
            // 
            this.rch_sikayet.Location = new System.Drawing.Point(17, 78);
            this.rch_sikayet.Name = "rch_sikayet";
            this.rch_sikayet.Size = new System.Drawing.Size(208, 136);
            this.rch_sikayet.TabIndex = 12;
            this.rch_sikayet.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şikayet:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(291, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 529);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 499);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_cikis);
            this.groupBox4.Controls.Add(this.btn_duyurular);
            this.groupBox4.Controls.Add(this.btn_bilgiduzenle);
            this.groupBox4.Location = new System.Drawing.Point(13, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 129);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(6, 72);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(260, 36);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_duyurular
            // 
            this.btn_duyurular.Location = new System.Drawing.Point(139, 30);
            this.btn_duyurular.Name = "btn_duyurular";
            this.btn_duyurular.Size = new System.Drawing.Size(127, 36);
            this.btn_duyurular.TabIndex = 0;
            this.btn_duyurular.Text = "Duyurular";
            this.btn_duyurular.UseVisualStyleBackColor = true;
            this.btn_duyurular.Click += new System.EventHandler(this.btn_duyurular_Click);
            // 
            // btn_bilgiduzenle
            // 
            this.btn_bilgiduzenle.Location = new System.Drawing.Point(6, 30);
            this.btn_bilgiduzenle.Name = "btn_bilgiduzenle";
            this.btn_bilgiduzenle.Size = new System.Drawing.Size(127, 36);
            this.btn_bilgiduzenle.TabIndex = 0;
            this.btn_bilgiduzenle.Text = "Bilgi Düzenle";
            this.btn_bilgiduzenle.UseVisualStyleBackColor = true;
            this.btn_bilgiduzenle.Click += new System.EventHandler(this.btn_bilgiduzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(893, 574);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rch_sikayet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_duyurular;
        private System.Windows.Forms.Button btn_bilgiduzenle;
    }
}