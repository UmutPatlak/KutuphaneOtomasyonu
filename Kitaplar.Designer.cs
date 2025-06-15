namespace KutuphaneOtomasyonu
{
    partial class Kitaplar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maskedTextboxKitapKAyit = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRafno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYayinevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYazarAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitap Al";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kitap Ver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "KITAP BILGILERI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 61);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(881, 163);
            this.dataGridView1.TabIndex = 53;
            // 
            // maskedTextboxKitapKAyit
            // 
            this.maskedTextboxKitapKAyit.Location = new System.Drawing.Point(200, 261);
            this.maskedTextboxKitapKAyit.Mask = "00-00-0000";
            this.maskedTextboxKitapKAyit.Name = "maskedTextboxKitapKAyit";
            this.maskedTextboxKitapKAyit.Size = new System.Drawing.Size(73, 22);
            this.maskedTextboxKitapKAyit.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 66;
            this.label7.Text = "Kitap Kayit Tarihi";
            // 
            // textBoxRafno
            // 
            this.textBoxRafno.Location = new System.Drawing.Point(182, 225);
            this.textBoxRafno.Name = "textBoxRafno";
            this.textBoxRafno.Size = new System.Drawing.Size(100, 22);
            this.textBoxRafno.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "Raf Numarasi";
            // 
            // textBoxTur
            // 
            this.textBoxTur.Location = new System.Drawing.Point(182, 193);
            this.textBoxTur.Name = "textBoxTur";
            this.textBoxTur.Size = new System.Drawing.Size(100, 22);
            this.textBoxTur.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tür";
            // 
            // textBoxSayfa
            // 
            this.textBoxSayfa.Location = new System.Drawing.Point(182, 160);
            this.textBoxSayfa.Name = "textBoxSayfa";
            this.textBoxSayfa.Size = new System.Drawing.Size(100, 22);
            this.textBoxSayfa.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Kitap Sayfasi";
            // 
            // textBoxYayinevi
            // 
            this.textBoxYayinevi.Location = new System.Drawing.Point(182, 132);
            this.textBoxYayinevi.Name = "textBoxYayinevi";
            this.textBoxYayinevi.Size = new System.Drawing.Size(100, 22);
            this.textBoxYayinevi.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Yayinevi";
            // 
            // textBoxYazarAd
            // 
            this.textBoxYazarAd.Location = new System.Drawing.Point(182, 100);
            this.textBoxYazarAd.Name = "textBoxYazarAd";
            this.textBoxYazarAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxYazarAd.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Yazar Adi";
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.Location = new System.Drawing.Point(182, 67);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(100, 22);
            this.textBoxKitapAd.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Kitap Adi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 56);
            this.button3.TabIndex = 68;
            this.button3.Text = "Tum Kitaplar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 478);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextboxKitapKAyit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRafno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSayfa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxYayinevi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYazarAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKitapAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedTextboxKitapKAyit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRafno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSayfa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYayinevi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYazarAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}