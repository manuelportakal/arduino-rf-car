namespace araba_test2
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.msk_komut_kuyrugu = new System.Windows.Forms.MaskedTextBox();
            this.btn_servo_sol = new System.Windows.Forms.Button();
            this.btn_komut_gonder = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_sag = new System.Windows.Forms.Button();
            this.btn_ileri = new System.Windows.Forms.Button();
            this.btn_sol = new System.Windows.Forms.Button();
            this.btn_servo_orta = new System.Windows.Forms.Button();
            this.btn_servo_sag = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_verial = new System.Windows.Forms.Button();
            this.txt_sicaklik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_dur = new System.Windows.Forms.Button();
            this.btn_baglan = new System.Windows.Forms.Button();
            this.btn_baglantiyi_kes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // msk_komut_kuyrugu
            // 
            this.msk_komut_kuyrugu.Location = new System.Drawing.Point(70, 57);
            this.msk_komut_kuyrugu.Mask = "0000000";
            this.msk_komut_kuyrugu.Name = "msk_komut_kuyrugu";
            this.msk_komut_kuyrugu.Size = new System.Drawing.Size(70, 22);
            this.msk_komut_kuyrugu.TabIndex = 8;
            // 
            // btn_servo_sol
            // 
            this.btn_servo_sol.Location = new System.Drawing.Point(122, 22);
            this.btn_servo_sol.Name = "btn_servo_sol";
            this.btn_servo_sol.Size = new System.Drawing.Size(102, 31);
            this.btn_servo_sol.TabIndex = 11;
            this.btn_servo_sol.Text = "Servo Sola";
            this.btn_servo_sol.UseVisualStyleBackColor = true;
            this.btn_servo_sol.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_komut_gonder
            // 
            this.btn_komut_gonder.Location = new System.Drawing.Point(194, 52);
            this.btn_komut_gonder.Name = "btn_komut_gonder";
            this.btn_komut_gonder.Size = new System.Drawing.Size(99, 33);
            this.btn_komut_gonder.TabIndex = 4;
            this.btn_komut_gonder.Text = "Gönder";
            this.btn_komut_gonder.UseVisualStyleBackColor = true;
            this.btn_komut_gonder.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(117, 128);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(97, 33);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_sag
            // 
            this.btn_sag.Location = new System.Drawing.Point(215, 80);
            this.btn_sag.Name = "btn_sag";
            this.btn_sag.Size = new System.Drawing.Size(78, 33);
            this.btn_sag.TabIndex = 2;
            this.btn_sag.Text = "Sağ";
            this.btn_sag.UseVisualStyleBackColor = true;
            this.btn_sag.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.Location = new System.Drawing.Point(118, 25);
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(96, 33);
            this.btn_ileri.TabIndex = 0;
            this.btn_ileri.Text = "İleri";
            this.btn_ileri.UseVisualStyleBackColor = true;
            this.btn_ileri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sol
            // 
            this.btn_sol.Location = new System.Drawing.Point(31, 80);
            this.btn_sol.Name = "btn_sol";
            this.btn_sol.Size = new System.Drawing.Size(84, 32);
            this.btn_sol.TabIndex = 1;
            this.btn_sol.Text = "Sol";
            this.btn_sol.UseVisualStyleBackColor = true;
            this.btn_sol.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_servo_orta
            // 
            this.btn_servo_orta.Location = new System.Drawing.Point(122, 70);
            this.btn_servo_orta.Name = "btn_servo_orta";
            this.btn_servo_orta.Size = new System.Drawing.Size(102, 31);
            this.btn_servo_orta.TabIndex = 12;
            this.btn_servo_orta.Text = "Servo Ortaya";
            this.btn_servo_orta.UseVisualStyleBackColor = true;
            this.btn_servo_orta.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_servo_sag
            // 
            this.btn_servo_sag.Location = new System.Drawing.Point(122, 115);
            this.btn_servo_sag.Name = "btn_servo_sag";
            this.btn_servo_sag.Size = new System.Drawing.Size(102, 31);
            this.btn_servo_sag.TabIndex = 13;
            this.btn_servo_sag.Text = "Servo Sağa";
            this.btn_servo_sag.UseVisualStyleBackColor = true;
            this.btn_servo_sag.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_servo_sag);
            this.groupBox1.Controls.Add(this.btn_servo_orta);
            this.groupBox1.Controls.Add(this.btn_servo_sol);
            this.groupBox1.Location = new System.Drawing.Point(456, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servo Kontrol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msk_komut_kuyrugu);
            this.groupBox2.Controls.Add(this.btn_komut_gonder);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 113);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Komut Kuyruğu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_dur);
            this.groupBox3.Controls.Add(this.btn_geri);
            this.groupBox3.Controls.Add(this.btn_sol);
            this.groupBox3.Controls.Add(this.btn_ileri);
            this.groupBox3.Controls.Add(this.btn_sag);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 168);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Araç Kontrol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_verial);
            this.groupBox4.Controls.Add(this.txt_sicaklik);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(456, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 113);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Veriler";
            // 
            // btn_verial
            // 
            this.btn_verial.Location = new System.Drawing.Point(136, 75);
            this.btn_verial.Name = "btn_verial";
            this.btn_verial.Size = new System.Drawing.Size(75, 32);
            this.btn_verial.TabIndex = 2;
            this.btn_verial.Text = "Veri Al";
            this.btn_verial.UseVisualStyleBackColor = true;
            this.btn_verial.Click += new System.EventHandler(this.button9_Click);
            // 
            // txt_sicaklik
            // 
            this.txt_sicaklik.Location = new System.Drawing.Point(124, 42);
            this.txt_sicaklik.Name = "txt_sicaklik";
            this.txt_sicaklik.Size = new System.Drawing.Size(100, 22);
            this.txt_sicaklik.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıcaklık:";
            // 
            // btn_alarm
            // 
            this.btn_alarm.Location = new System.Drawing.Point(366, 169);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(75, 33);
            this.btn_alarm.TabIndex = 18;
            this.btn_alarm.Text = "Alarm";
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_dur
            // 
            this.btn_dur.Location = new System.Drawing.Point(129, 82);
            this.btn_dur.Name = "btn_dur";
            this.btn_dur.Size = new System.Drawing.Size(75, 28);
            this.btn_dur.TabIndex = 4;
            this.btn_dur.Text = "Dur";
            this.btn_dur.UseVisualStyleBackColor = true;
            this.btn_dur.Click += new System.EventHandler(this.button11_Click);
            // 
            // btn_baglan
            // 
            this.btn_baglan.Location = new System.Drawing.Point(366, 31);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(75, 33);
            this.btn_baglan.TabIndex = 19;
            this.btn_baglan.Text = "Bağlan";
            this.btn_baglan.UseVisualStyleBackColor = true;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // btn_baglantiyi_kes
            // 
            this.btn_baglantiyi_kes.Location = new System.Drawing.Point(366, 70);
            this.btn_baglantiyi_kes.Name = "btn_baglantiyi_kes";
            this.btn_baglantiyi_kes.Size = new System.Drawing.Size(75, 29);
            this.btn_baglantiyi_kes.TabIndex = 20;
            this.btn_baglantiyi_kes.Text = "Kapat";
            this.btn_baglantiyi_kes.UseVisualStyleBackColor = true;
            this.btn_baglantiyi_kes.Click += new System.EventHandler(this.btn_baglantiyi_kes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 318);
            this.Controls.Add(this.btn_baglantiyi_kes);
            this.Controls.Add(this.btn_baglan);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Yer İstasyonu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MaskedTextBox msk_komut_kuyrugu;
        private System.Windows.Forms.Button btn_servo_sol;
        private System.Windows.Forms.Button btn_komut_gonder;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_sag;
        private System.Windows.Forms.Button btn_ileri;
        private System.Windows.Forms.Button btn_sol;
        private System.Windows.Forms.Button btn_servo_orta;
        private System.Windows.Forms.Button btn_servo_sag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_verial;
        private System.Windows.Forms.TextBox txt_sicaklik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.Button btn_dur;
        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.Button btn_baglantiyi_kes;
    }
}

