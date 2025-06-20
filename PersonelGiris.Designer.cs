namespace KutuphaneOtomasyonu
{
    partial class PersonelGiris
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
            this.adlabel = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.UyeKAyit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adlabel
            // 
            this.adlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adlabel.Location = new System.Drawing.Point(561, 72);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(113, 42);
            this.adlabel.TabIndex = 1;
            this.adlabel.Click += new System.EventHandler(this.adlabel_Click);
            // 
            // soyadlabel
            // 
            this.soyadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlabel.Location = new System.Drawing.Point(680, 65);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(108, 42);
            this.soyadlabel.TabIndex = 1;
            this.soyadlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UyeKAyit
            // 
            this.UyeKAyit.Location = new System.Drawing.Point(576, 327);
            this.UyeKAyit.Name = "UyeKAyit";
            this.UyeKAyit.Size = new System.Drawing.Size(136, 54);
            this.UyeKAyit.TabIndex = 2;
            this.UyeKAyit.Text = "Uye Kayit";
            this.UyeKAyit.UseVisualStyleBackColor = true;
            this.UyeKAyit.Click += new System.EventHandler(this.UyeKAyit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kitap Kayit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(434, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Bilgilerim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Giris";
            // 
            // PersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.soyadlabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.adlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UyeKAyit);
            this.Name = "PersonelGiris";
            this.Text = "PersonelGiris";
            this.Load += new System.EventHandler(this.PersonelGiris_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.Button UyeKAyit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}