namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btn_hastagirisi = new System.Windows.Forms.Button();
            this.btn_doktorgirisi = new System.Windows.Forms.Button();
            this.btn_sekretergirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hastagirisi
            // 
            this.btn_hastagirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hastagirisi.BackgroundImage")));
            this.btn_hastagirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hastagirisi.Location = new System.Drawing.Point(34, 156);
            this.btn_hastagirisi.Name = "btn_hastagirisi";
            this.btn_hastagirisi.Size = new System.Drawing.Size(150, 116);
            this.btn_hastagirisi.TabIndex = 0;
            this.btn_hastagirisi.UseVisualStyleBackColor = true;
            this.btn_hastagirisi.Click += new System.EventHandler(this.btn_hastagirisi_Click);
            // 
            // btn_doktorgirisi
            // 
            this.btn_doktorgirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktorgirisi.BackgroundImage")));
            this.btn_doktorgirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktorgirisi.Location = new System.Drawing.Point(222, 156);
            this.btn_doktorgirisi.Name = "btn_doktorgirisi";
            this.btn_doktorgirisi.Size = new System.Drawing.Size(150, 116);
            this.btn_doktorgirisi.TabIndex = 0;
            this.btn_doktorgirisi.UseVisualStyleBackColor = true;
            this.btn_doktorgirisi.Click += new System.EventHandler(this.btn_doktorgirisi_Click);
            // 
            // btn_sekretergirisi
            // 
            this.btn_sekretergirisi.BackColor = System.Drawing.Color.Silver;
            this.btn_sekretergirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekretergirisi.BackgroundImage")));
            this.btn_sekretergirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekretergirisi.Location = new System.Drawing.Point(407, 156);
            this.btn_sekretergirisi.Name = "btn_sekretergirisi";
            this.btn_sekretergirisi.Size = new System.Drawing.Size(150, 116);
            this.btn_sekretergirisi.TabIndex = 0;
            this.btn_sekretergirisi.UseVisualStyleBackColor = false;
            this.btn_sekretergirisi.Click += new System.EventHandler(this.btn_sekretergirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teal Hospital";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(613, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sekretergirisi);
            this.Controls.Add(this.btn_doktorgirisi);
            this.Controls.Add(this.btn_hastagirisi);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Teal Hospital Giriş";        
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hastagirisi;
        private System.Windows.Forms.Button btn_doktorgirisi;
        private System.Windows.Forms.Button btn_sekretergirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

