namespace Otomatik_Kapatma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Close_Rbtn = new System.Windows.Forms.RadioButton();
            this.Restart_RdBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Zaman = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dakika = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Saat = new System.Windows.Forms.NumericUpDown();
            this.Durdur_Btn = new System.Windows.Forms.Button();
            this.Baslat_Btn = new System.Windows.Forms.Button();
            this.Cıkıs_Btn = new System.Windows.Forms.Button();
            this.Lbl_H = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Rb_Btn_Turksih = new System.Windows.Forms.RadioButton();
            this.Rb_Btn_english = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_S = new System.Windows.Forms.Label();
            this.Lbl_M = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Zaman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_Rbtn
            // 
            this.Close_Rbtn.AutoSize = true;
            this.Close_Rbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Close_Rbtn.Location = new System.Drawing.Point(54, 41);
            this.Close_Rbtn.Name = "Close_Rbtn";
            this.Close_Rbtn.Size = new System.Drawing.Size(56, 18);
            this.Close_Rbtn.TabIndex = 0;
            this.Close_Rbtn.TabStop = true;
            this.Close_Rbtn.Text = "Kapat";
            this.Close_Rbtn.UseVisualStyleBackColor = true;
            // 
            // Restart_RdBtn
            // 
            this.Restart_RdBtn.AutoSize = true;
            this.Restart_RdBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Restart_RdBtn.Location = new System.Drawing.Point(197, 41);
            this.Restart_RdBtn.Name = "Restart_RdBtn";
            this.Restart_RdBtn.Size = new System.Drawing.Size(105, 18);
            this.Restart_RdBtn.TabIndex = 1;
            this.Restart_RdBtn.Text = "Yeniden Başlat";
            this.Restart_RdBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Close_Rbtn);
            this.groupBox1.Controls.Add(this.Restart_RdBtn);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Tipi";
            // 
            // Zaman
            // 
            this.Zaman.Controls.Add(this.label2);
            this.Zaman.Controls.Add(this.Dakika);
            this.Zaman.Controls.Add(this.label1);
            this.Zaman.Controls.Add(this.Saat);
            this.Zaman.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Zaman.Location = new System.Drawing.Point(12, 99);
            this.Zaman.Name = "Zaman";
            this.Zaman.Size = new System.Drawing.Size(182, 200);
            this.Zaman.TabIndex = 4;
            this.Zaman.TabStop = false;
            this.Zaman.Text = "Zaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dakika :";
            // 
            // Dakika
            // 
            this.Dakika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dakika.Location = new System.Drawing.Point(105, 120);
            this.Dakika.Name = "Dakika";
            this.Dakika.Size = new System.Drawing.Size(54, 22);
            this.Dakika.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat :";
            // 
            // Saat
            // 
            this.Saat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Saat.Location = new System.Drawing.Point(105, 46);
            this.Saat.Name = "Saat";
            this.Saat.Size = new System.Drawing.Size(54, 22);
            this.Saat.TabIndex = 0;
            // 
            // Durdur_Btn
            // 
            this.Durdur_Btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Durdur_Btn.Location = new System.Drawing.Point(274, 99);
            this.Durdur_Btn.Name = "Durdur_Btn";
            this.Durdur_Btn.Size = new System.Drawing.Size(60, 63);
            this.Durdur_Btn.TabIndex = 5;
            this.Durdur_Btn.Text = "Durdur";
            this.Durdur_Btn.UseVisualStyleBackColor = true;
            this.Durdur_Btn.Click += new System.EventHandler(this.Durdur_Btn_Click);
            // 
            // Baslat_Btn
            // 
            this.Baslat_Btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Baslat_Btn.Location = new System.Drawing.Point(209, 99);
            this.Baslat_Btn.Name = "Baslat_Btn";
            this.Baslat_Btn.Size = new System.Drawing.Size(59, 63);
            this.Baslat_Btn.TabIndex = 6;
            this.Baslat_Btn.Text = "Başlat";
            this.Baslat_Btn.UseVisualStyleBackColor = true;
            this.Baslat_Btn.Click += new System.EventHandler(this.Baslat_Btn_Click);
            // 
            // Cıkıs_Btn
            // 
            this.Cıkıs_Btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cıkıs_Btn.Location = new System.Drawing.Point(209, 168);
            this.Cıkıs_Btn.Name = "Cıkıs_Btn";
            this.Cıkıs_Btn.Size = new System.Drawing.Size(125, 49);
            this.Cıkıs_Btn.TabIndex = 7;
            this.Cıkıs_Btn.Text = "Çıkış";
            this.Cıkıs_Btn.UseVisualStyleBackColor = true;
            // 
            // Lbl_H
            // 
            this.Lbl_H.AutoSize = true;
            this.Lbl_H.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_H.Location = new System.Drawing.Point(60, 318);
            this.Lbl_H.Name = "Lbl_H";
            this.Lbl_H.Size = new System.Drawing.Size(45, 33);
            this.Lbl_H.TabIndex = 9;
            this.Lbl_H.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Rb_Btn_Turksih
            // 
            this.Rb_Btn_Turksih.AutoSize = true;
            this.Rb_Btn_Turksih.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rb_Btn_Turksih.Location = new System.Drawing.Point(30, 20);
            this.Rb_Btn_Turksih.Name = "Rb_Btn_Turksih";
            this.Rb_Btn_Turksih.Size = new System.Drawing.Size(63, 18);
            this.Rb_Btn_Turksih.TabIndex = 10;
            this.Rb_Btn_Turksih.Text = "Türkçe";
            this.Rb_Btn_Turksih.UseVisualStyleBackColor = true;
            // 
            // Rb_Btn_english
            // 
            this.Rb_Btn_english.AutoSize = true;
            this.Rb_Btn_english.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rb_Btn_english.Location = new System.Drawing.Point(30, 44);
            this.Rb_Btn_english.Name = "Rb_Btn_english";
            this.Rb_Btn_english.Size = new System.Drawing.Size(67, 18);
            this.Rb_Btn_english.TabIndex = 11;
            this.Rb_Btn_english.TabStop = true;
            this.Rb_Btn_english.Text = "İngilizce";
            this.Rb_Btn_english.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rb_Btn_Turksih);
            this.groupBox2.Controls.Add(this.Rb_Btn_english);
            this.groupBox2.Location = new System.Drawing.Point(201, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 75);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dil";
            // 
            // Lbl_S
            // 
            this.Lbl_S.AutoSize = true;
            this.Lbl_S.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_S.Location = new System.Drawing.Point(203, 318);
            this.Lbl_S.Name = "Lbl_S";
            this.Lbl_S.Size = new System.Drawing.Size(45, 33);
            this.Lbl_S.TabIndex = 13;
            this.Lbl_S.Text = "00";
            // 
            // Lbl_M
            // 
            this.Lbl_M.AutoSize = true;
            this.Lbl_M.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_M.Location = new System.Drawing.Point(132, 318);
            this.Lbl_M.Name = "Lbl_M";
            this.Lbl_M.Size = new System.Drawing.Size(45, 33);
            this.Lbl_M.TabIndex = 14;
            this.Lbl_M.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(183, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(101, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 368);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_M);
            this.Controls.Add(this.Lbl_S);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Lbl_H);
            this.Controls.Add(this.Cıkıs_Btn);
            this.Controls.Add(this.Baslat_Btn);
            this.Controls.Add(this.Durdur_Btn);
            this.Controls.Add(this.Zaman);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Zaman.ResumeLayout(false);
            this.Zaman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Close_Rbtn;
        private System.Windows.Forms.RadioButton Restart_RdBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Zaman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Dakika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Saat;
        private System.Windows.Forms.Button Durdur_Btn;
        private System.Windows.Forms.Button Baslat_Btn;
        private System.Windows.Forms.Button Cıkıs_Btn;
        private System.Windows.Forms.Label Lbl_H;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton Rb_Btn_Turksih;
        private System.Windows.Forms.RadioButton Rb_Btn_english;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_S;
        private System.Windows.Forms.Label Lbl_M;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

