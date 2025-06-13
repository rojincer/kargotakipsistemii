namespace kargoTakipSistemiii
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakipNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.TakipNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GonderiDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAlici);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTakipNo);
            this.groupBox1.Location = new System.Drawing.Point(37, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alıcı";
            // 
            // txtAlici
            // 
            this.txtAlici.BackColor = System.Drawing.Color.Plum;
            this.txtAlici.Location = new System.Drawing.Point(127, 88);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(100, 26);
            this.txtAlici.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Takip No";
            // 
            // txtTakipNo
            // 
            this.txtTakipNo.BackColor = System.Drawing.Color.Plum;
            this.txtTakipNo.Location = new System.Drawing.Point(127, 35);
            this.txtTakipNo.Name = "txtTakipNo";
            this.txtTakipNo.Size = new System.Drawing.Size(100, 26);
            this.txtTakipNo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.cmbTip);
            this.groupBox2.Controls.Add(this.cmbDurum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(375, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderi Bilgileri";
            // 
            // cmbTip
            // 
            this.cmbTip.BackColor = System.Drawing.Color.Plum;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "Yurtici",
            "Yurtdisi"});
            this.cmbTip.Location = new System.Drawing.Point(204, 92);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 28);
            this.cmbTip.TabIndex = 3;
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.Plum;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(204, 41);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 28);
            this.cmbDurum.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gönderi Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gönderi Durumu";
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.AllowUserToAddRows = false;
            this.dgvKargolar.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TakipNo,
            this.Alici,
            this.GonderiDurumu,
            this.Tip});
            this.dgvKargolar.Location = new System.Drawing.Point(12, 339);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.ReadOnly = true;
            this.dgvKargolar.RowHeadersWidth = 62;
            this.dgvKargolar.RowTemplate.Height = 28;
            this.dgvKargolar.Size = new System.Drawing.Size(688, 258);
            this.dgvKargolar.TabIndex = 2;
            // 
            // TakipNo
            // 
            this.TakipNo.HeaderText = "Takip No";
            this.TakipNo.MinimumWidth = 8;
            this.TakipNo.Name = "TakipNo";
            this.TakipNo.ReadOnly = true;
            this.TakipNo.Width = 150;
            // 
            // Alici
            // 
            this.Alici.HeaderText = "Alıcı";
            this.Alici.MinimumWidth = 8;
            this.Alici.Name = "Alici";
            this.Alici.ReadOnly = true;
            this.Alici.Width = 150;
            // 
            // GonderiDurumu
            // 
            this.GonderiDurumu.HeaderText = "Durum";
            this.GonderiDurumu.MinimumWidth = 8;
            this.GonderiDurumu.Name = "GonderiDurumu";
            this.GonderiDurumu.ReadOnly = true;
            this.GonderiDurumu.Width = 150;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.MinimumWidth = 8;
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 150;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOlustur.Location = new System.Drawing.Point(794, 271);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(133, 52);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Gönderi Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(794, 329);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(133, 48);
            this.btnDurumGuncelle.TabIndex = 4;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSorgula.Location = new System.Drawing.Point(794, 383);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(133, 45);
            this.btnSorgula.TabIndex = 5;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = false;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(978, 944);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.dgvKargolar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaForm";
            this.Text = "Kargo Takip Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.TextBox txtTakipNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakipNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alici;
        private System.Windows.Forms.DataGridViewTextBoxColumn GonderiDurumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.Button btnSorgula;
    }
}

