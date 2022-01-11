
namespace Events_Calisma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.chkBayi = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKdv = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.rdbBeyazEsya = new System.Windows.Forms.RadioButton();
            this.rdbKirtsasiye = new System.Windows.Forms.RadioButton();
            this.rdbGıda = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birim Fiyatı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Malzeme Adı :";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzemeAdi.Location = new System.Drawing.Point(171, 35);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(132, 23);
            this.txtMalzemeAdi.TabIndex = 1;
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyati.Location = new System.Drawing.Point(171, 80);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(132, 23);
            this.txtBirimFiyati.TabIndex = 1;
            this.txtBirimFiyati.TextChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // chkBayi
            // 
            this.chkBayi.AutoSize = true;
            this.chkBayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBayi.Location = new System.Drawing.Point(171, 185);
            this.chkBayi.Name = "chkBayi";
            this.chkBayi.Size = new System.Drawing.Size(58, 21);
            this.chkBayi.TabIndex = 2;
            this.chkBayi.Text = "Bayi";
            this.chkBayi.UseVisualStyleBackColor = true;
            this.chkBayi.CheckedChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbGıda);
            this.groupBox1.Controls.Add(this.rdbKirtsasiye);
            this.groupBox1.Controls.Add(this.rdbBeyazEsya);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(344, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 171);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzeme Cinsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "KDV :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "TUTAR :";
            // 
            // txtKdv
            // 
            this.txtKdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdv.Location = new System.Drawing.Point(171, 234);
            this.txtKdv.Name = "txtKdv";
            this.txtKdv.Size = new System.Drawing.Size(132, 23);
            this.txtKdv.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(171, 276);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(132, 23);
            this.txtTutar.TabIndex = 1;
            // 
            // rdbBeyazEsya
            // 
            this.rdbBeyazEsya.AutoSize = true;
            this.rdbBeyazEsya.Location = new System.Drawing.Point(29, 34);
            this.rdbBeyazEsya.Name = "rdbBeyazEsya";
            this.rdbBeyazEsya.Size = new System.Drawing.Size(120, 24);
            this.rdbBeyazEsya.TabIndex = 0;
            this.rdbBeyazEsya.TabStop = true;
            this.rdbBeyazEsya.Text = "Beyaz Esya";
            this.rdbBeyazEsya.UseVisualStyleBackColor = true;
            this.rdbBeyazEsya.CheckedChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // rdbKirtsasiye
            // 
            this.rdbKirtsasiye.AutoSize = true;
            this.rdbKirtsasiye.Location = new System.Drawing.Point(29, 75);
            this.rdbKirtsasiye.Name = "rdbKirtsasiye";
            this.rdbKirtsasiye.Size = new System.Drawing.Size(95, 24);
            this.rdbKirtsasiye.TabIndex = 0;
            this.rdbKirtsasiye.TabStop = true;
            this.rdbKirtsasiye.Text = "Kırtasiye";
            this.rdbKirtsasiye.UseVisualStyleBackColor = true;
            this.rdbKirtsasiye.CheckedChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // rdbGıda
            // 
            this.rdbGıda.AutoSize = true;
            this.rdbGıda.Location = new System.Drawing.Point(29, 116);
            this.rdbGıda.Name = "rdbGıda";
            this.rdbGıda.Size = new System.Drawing.Size(65, 24);
            this.rdbGıda.TabIndex = 0;
            this.rdbGıda.TabStop = true;
            this.rdbGıda.Text = "Gıda";
            this.rdbGıda.UseVisualStyleBackColor = true;
            this.rdbGıda.CheckedChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(171, 123);
            this.nudAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(132, 23);
            this.nudAdet.TabIndex = 5;
            this.nudAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAdet.ValueChanged += new System.EventHandler(this.txtBirimFiyati_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 348);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkBayi);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtKdv);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.CheckBox chkBayi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbGıda;
        private System.Windows.Forms.RadioButton rdbKirtsasiye;
        private System.Windows.Forms.RadioButton rdbBeyazEsya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKdv;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudAdet;
    }
}

