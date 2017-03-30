namespace Yazlab2_Proje1
{
    partial class Form1
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
            this.txtBaslangicOdacik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHedefOdacik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIterasyonSayisi = new System.Windows.Forms.TextBox();
            this.lblDeneme = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVeriCek = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBaslangicOdacik
            // 
            this.txtBaslangicOdacik.Location = new System.Drawing.Point(224, 49);
            this.txtBaslangicOdacik.Name = "txtBaslangicOdacik";
            this.txtBaslangicOdacik.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangicOdacik.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(57, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Odacığı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(64, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hedef Odacık : ";
            // 
            // txtHedefOdacik
            // 
            this.txtHedefOdacik.Location = new System.Drawing.Point(224, 85);
            this.txtHedefOdacik.Name = "txtHedefOdacik";
            this.txtHedefOdacik.Size = new System.Drawing.Size(100, 20);
            this.txtHedefOdacik.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "İterasyon Sayısı : ";
            // 
            // txtIterasyonSayisi
            // 
            this.txtIterasyonSayisi.Location = new System.Drawing.Point(224, 122);
            this.txtIterasyonSayisi.Name = "txtIterasyonSayisi";
            this.txtIterasyonSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtIterasyonSayisi.TabIndex = 4;
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Location = new System.Drawing.Point(376, 265);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(0, 13);
            this.lblDeneme.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(365, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(361, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input Dosyası";
            // 
            // btnVeriCek
            // 
            this.btnVeriCek.Location = new System.Drawing.Point(25, 165);
            this.btnVeriCek.Name = "btnVeriCek";
            this.btnVeriCek.Size = new System.Drawing.Size(112, 36);
            this.btnVeriCek.TabIndex = 10;
            this.btnVeriCek.Text = "Verileri Çek";
            this.btnVeriCek.UseVisualStyleBackColor = true;
            this.btnVeriCek.Click += new System.EventHandler(this.btnVeriCek_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(143, 165);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 36);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "Algoritmayı Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Grafiği Çizdir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(562, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnVeriCek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIterasyonSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHedefOdacik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaslangicOdacik);
            this.Name = "Form1";
            this.Text = "Q-Learning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaslangicOdacik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHedefOdacik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIterasyonSayisi;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVeriCek;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button button1;
    }
}

