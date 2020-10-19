namespace Kalkulator_Sederhana
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
            this.nilai1 = new System.Windows.Forms.Label();
            this.tnilai1 = new System.Windows.Forms.TextBox();
            this.tnilai2 = new System.Windows.Forms.TextBox();
            this.nilai2 = new System.Windows.Forms.Label();
            this.thasil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btambah = new System.Windows.Forms.Button();
            this.bbagi = new System.Windows.Forms.Button();
            this.bkali = new System.Windows.Forms.Button();
            this.bkurang = new System.Windows.Forms.Button();
            this.kosongkan = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nilai1
            // 
            this.nilai1.AutoSize = true;
            this.nilai1.Location = new System.Drawing.Point(78, 21);
            this.nilai1.Name = "nilai1";
            this.nilai1.Size = new System.Drawing.Size(36, 13);
            this.nilai1.TabIndex = 0;
            this.nilai1.Text = "Nilai 1";
            // 
            // tnilai1
            // 
            this.tnilai1.Location = new System.Drawing.Point(49, 37);
            this.tnilai1.Name = "tnilai1";
            this.tnilai1.Size = new System.Drawing.Size(100, 20);
            this.tnilai1.TabIndex = 1;
            this.tnilai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tnilai1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tnilai2
            // 
            this.tnilai2.Location = new System.Drawing.Point(49, 86);
            this.tnilai2.Name = "tnilai2";
            this.tnilai2.Size = new System.Drawing.Size(100, 20);
            this.tnilai2.TabIndex = 3;
            this.tnilai2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nilai2
            // 
            this.nilai2.AutoSize = true;
            this.nilai2.Location = new System.Drawing.Point(78, 70);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(36, 13);
            this.nilai2.TabIndex = 2;
            this.nilai2.Text = "Nilai 2";
            // 
            // thasil
            // 
            this.thasil.Location = new System.Drawing.Point(27, 145);
            this.thasil.Multiline = true;
            this.thasil.Name = "thasil";
            this.thasil.Size = new System.Drawing.Size(146, 38);
            this.thasil.TabIndex = 5;
            this.thasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.thasil.TextChanged += new System.EventHandler(this.hasil_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil";
            // 
            // btambah
            // 
            this.btambah.Location = new System.Drawing.Point(24, 201);
            this.btambah.Name = "btambah";
            this.btambah.Size = new System.Drawing.Size(30, 24);
            this.btambah.TabIndex = 6;
            this.btambah.Text = "+";
            this.btambah.UseVisualStyleBackColor = true;
            this.btambah.Click += new System.EventHandler(this.btambah_Click);
            // 
            // bbagi
            // 
            this.bbagi.Location = new System.Drawing.Point(143, 201);
            this.bbagi.Name = "bbagi";
            this.bbagi.Size = new System.Drawing.Size(30, 24);
            this.bbagi.TabIndex = 7;
            this.bbagi.Text = "/";
            this.bbagi.UseVisualStyleBackColor = true;
            this.bbagi.Click += new System.EventHandler(this.bbagi_Click);
            // 
            // bkali
            // 
            this.bkali.Location = new System.Drawing.Point(107, 202);
            this.bkali.Name = "bkali";
            this.bkali.Size = new System.Drawing.Size(30, 24);
            this.bkali.TabIndex = 8;
            this.bkali.Text = "x";
            this.bkali.UseVisualStyleBackColor = true;
            this.bkali.Click += new System.EventHandler(this.bkali_Click);
            // 
            // bkurang
            // 
            this.bkurang.Location = new System.Drawing.Point(60, 201);
            this.bkurang.Name = "bkurang";
            this.bkurang.Size = new System.Drawing.Size(30, 24);
            this.bkurang.TabIndex = 9;
            this.bkurang.Text = "-";
            this.bkurang.UseVisualStyleBackColor = true;
            this.bkurang.Click += new System.EventHandler(this.bkurang_Click);
            // 
            // kosongkan
            // 
            this.kosongkan.Location = new System.Drawing.Point(24, 232);
            this.kosongkan.Name = "kosongkan";
            this.kosongkan.Size = new System.Drawing.Size(149, 33);
            this.kosongkan.TabIndex = 10;
            this.kosongkan.Text = "Kosongkan";
            this.kosongkan.UseVisualStyleBackColor = true;
            this.kosongkan.Click += new System.EventHandler(this.kosongkan_Click);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(24, 271);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(149, 33);
            this.keluar.TabIndex = 11;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 313);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.kosongkan);
            this.Controls.Add(this.bkurang);
            this.Controls.Add(this.bkali);
            this.Controls.Add(this.bbagi);
            this.Controls.Add(this.btambah);
            this.Controls.Add(this.thasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnilai2);
            this.Controls.Add(this.nilai2);
            this.Controls.Add(this.tnilai1);
            this.Controls.Add(this.nilai1);
            this.Name = "Form1";
            this.Text = "Kalkulator Sederhana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nilai1;
        private System.Windows.Forms.TextBox tnilai1;
        private System.Windows.Forms.TextBox tnilai2;
        private System.Windows.Forms.Label nilai2;
        private System.Windows.Forms.TextBox thasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btambah;
        private System.Windows.Forms.Button bbagi;
        private System.Windows.Forms.Button bkali;
        private System.Windows.Forms.Button bkurang;
        private System.Windows.Forms.Button kosongkan;
        private System.Windows.Forms.Button keluar;
    }
}

