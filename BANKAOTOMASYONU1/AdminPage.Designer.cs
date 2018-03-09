namespace BANKAOTOMASYONU1
{
    partial class AdminPage
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnraporgoruntule = new System.Windows.Forms.Button();
            this.tpMusteriEkle = new System.Windows.Forms.TabPage();
            this.cmbmusteritipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btngeridon = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txttckimlik = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmusteriekle = new System.Windows.Forms.Button();
            this.lbmusteriler = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpMusteriEkle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnraporgoruntule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gelir Gider Raporu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 284);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnraporgoruntule
            // 
            this.btnraporgoruntule.Location = new System.Drawing.Point(7, 6);
            this.btnraporgoruntule.Name = "btnraporgoruntule";
            this.btnraporgoruntule.Size = new System.Drawing.Size(112, 29);
            this.btnraporgoruntule.TabIndex = 1;
            this.btnraporgoruntule.Text = "Rapor";
            this.btnraporgoruntule.UseVisualStyleBackColor = true;
            this.btnraporgoruntule.Click += new System.EventHandler(this.btnraporgoruntule_Click);
            // 
            // tpMusteriEkle
            // 
            this.tpMusteriEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tpMusteriEkle.Controls.Add(this.cmbmusteritipi);
            this.tpMusteriEkle.Controls.Add(this.label5);
            this.tpMusteriEkle.Controls.Add(this.btngeridon);
            this.tpMusteriEkle.Controls.Add(this.txtsifre);
            this.tpMusteriEkle.Controls.Add(this.txttckimlik);
            this.tpMusteriEkle.Controls.Add(this.txtsoyad);
            this.tpMusteriEkle.Controls.Add(this.txtad);
            this.tpMusteriEkle.Controls.Add(this.label4);
            this.tpMusteriEkle.Controls.Add(this.label3);
            this.tpMusteriEkle.Controls.Add(this.label2);
            this.tpMusteriEkle.Controls.Add(this.label1);
            this.tpMusteriEkle.Controls.Add(this.btnmusteriekle);
            this.tpMusteriEkle.Controls.Add(this.lbmusteriler);
            this.tpMusteriEkle.Location = new System.Drawing.Point(4, 22);
            this.tpMusteriEkle.Name = "tpMusteriEkle";
            this.tpMusteriEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpMusteriEkle.Size = new System.Drawing.Size(610, 331);
            this.tpMusteriEkle.TabIndex = 0;
            this.tpMusteriEkle.Text = "Müşteri Ekle";
            // 
            // cmbmusteritipi
            // 
            this.cmbmusteritipi.FormattingEnabled = true;
            this.cmbmusteritipi.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.cmbmusteritipi.Location = new System.Drawing.Point(431, 159);
            this.cmbmusteritipi.Name = "cmbmusteritipi";
            this.cmbmusteritipi.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteritipi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(327, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "MÜŞTERİ TİPİ:";
            // 
            // btngeridon
            // 
            this.btngeridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngeridon.ForeColor = System.Drawing.Color.Crimson;
            this.btngeridon.Location = new System.Drawing.Point(457, 262);
            this.btngeridon.Name = "btngeridon";
            this.btngeridon.Size = new System.Drawing.Size(87, 25);
            this.btngeridon.TabIndex = 10;
            this.btngeridon.Text = "GERİ DÖN";
            this.btngeridon.UseVisualStyleBackColor = true;
            this.btngeridon.Click += new System.EventHandler(this.btngeridon_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(431, 121);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 9;
            // 
            // txttckimlik
            // 
            this.txttckimlik.Location = new System.Drawing.Point(431, 81);
            this.txttckimlik.Name = "txttckimlik";
            this.txttckimlik.Size = new System.Drawing.Size(100, 20);
            this.txttckimlik.TabIndex = 8;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(431, 47);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(431, 13);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(378, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "ŞİFRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(373, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "AD:";
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmusteriekle.ForeColor = System.Drawing.Color.Crimson;
            this.btnmusteriekle.Location = new System.Drawing.Point(376, 204);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(138, 36);
            this.btnmusteriekle.TabIndex = 1;
            this.btnmusteriekle.Text = "MÜŞTERİ EKLE";
            this.btnmusteriekle.UseVisualStyleBackColor = true;
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // lbmusteriler
            // 
            this.lbmusteriler.FormattingEnabled = true;
            this.lbmusteriler.Location = new System.Drawing.Point(7, 18);
            this.lbmusteriler.Name = "lbmusteriler";
            this.lbmusteriler.Size = new System.Drawing.Size(295, 290);
            this.lbmusteriler.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpMusteriEkle);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(631, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPage";
            this.Text = "YETKİLİ GİRİŞİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpMusteriEkle.ResumeLayout(false);
            this.tpMusteriEkle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnraporgoruntule;
        private System.Windows.Forms.TabPage tpMusteriEkle;
        private System.Windows.Forms.ComboBox cmbmusteritipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btngeridon;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txttckimlik;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmusteriekle;
        private System.Windows.Forms.ListBox lbmusteriler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}