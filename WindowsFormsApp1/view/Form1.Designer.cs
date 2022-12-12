namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nohp = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.npm = new System.Windows.Forms.TextBox();
            this.angkatan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataMahasiswa = new System.Windows.Forms.DataGridView();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbCariData = new System.Windows.Forms.TextBox();
            this.Pencarian = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nohp);
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Controls.Add(this.npm);
            this.groupBox2.Controls.Add(this.angkatan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(20, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "table form mahasiswa";
            // 
            // nohp
            // 
            this.nohp.Location = new System.Drawing.Point(164, 170);
            this.nohp.Name = "nohp";
            this.nohp.Size = new System.Drawing.Size(269, 22);
            this.nohp.TabIndex = 27;
            this.nohp.TextChanged += new System.EventHandler(this.nohp_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(164, 142);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(269, 22);
            this.email.TabIndex = 26;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(164, 114);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(269, 22);
            this.alamat.TabIndex = 25;
            this.alamat.TextChanged += new System.EventHandler(this.alamat_TextChanged);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(164, 46);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(269, 22);
            this.nama.TabIndex = 24;
            this.nama.TextChanged += new System.EventHandler(this.nama_TextChanged);
            // 
            // npm
            // 
            this.npm.Location = new System.Drawing.Point(165, 19);
            this.npm.Name = "npm";
            this.npm.Size = new System.Drawing.Size(269, 22);
            this.npm.TabIndex = 23;
            this.npm.TextChanged += new System.EventHandler(this.npm_TextChanged);
            // 
            // angkatan
            // 
            this.angkatan.FormattingEnabled = true;
            this.angkatan.Items.AddRange(new object[] {
            "2021",
            "2022"});
            this.angkatan.Location = new System.Drawing.Point(164, 72);
            this.angkatan.Name = "angkatan";
            this.angkatan.Size = new System.Drawing.Size(283, 24);
            this.angkatan.TabIndex = 22;
            this.angkatan.SelectedIndexChanged += new System.EventHandler(this.angkatan_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "NO HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "ALAMAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "ANGKATAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "NAMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "NPM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataMahasiswa);
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "table data mahasiswa";
            // 
            // DataMahasiswa
            // 
            this.DataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMahasiswa.Location = new System.Drawing.Point(0, 21);
            this.DataMahasiswa.Name = "DataMahasiswa";
            this.DataMahasiswa.RowHeadersWidth = 51;
            this.DataMahasiswa.RowTemplate.Height = 24;
            this.DataMahasiswa.Size = new System.Drawing.Size(763, 180);
            this.DataMahasiswa.TabIndex = 28;
            this.DataMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataMahasiswa_CellClick);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(24, 128);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(273, 23);
            this.btnUbah.TabIndex = 18;
            this.btnUbah.Text = "UBAH";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(24, 171);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(273, 23);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(273, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "REFRES";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(24, 82);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(273, 23);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Text = "SIMPAN";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHapus);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnSimpan);
            this.groupBox3.Controls.Add(this.btnUbah);
            this.groupBox3.Location = new System.Drawing.Point(486, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 205);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOMBLO ACTION";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Pencarian);
            this.groupBox4.Controls.Add(this.tbCariData);
            this.groupBox4.Location = new System.Drawing.Point(486, 453);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 77);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TOMBLO ACTION";
            // 
            // tbCariData
            // 
            this.tbCariData.Location = new System.Drawing.Point(109, 35);
            this.tbCariData.Name = "tbCariData";
            this.tbCariData.Size = new System.Drawing.Size(269, 22);
            this.tbCariData.TabIndex = 28;
            this.tbCariData.TextChanged += new System.EventHandler(this.tbCariData_TextChanged);
            // 
            // Pencarian
            // 
            this.Pencarian.AutoSize = true;
            this.Pencarian.Location = new System.Drawing.Point(6, 38);
            this.Pencarian.Name = "Pencarian";
            this.Pencarian.Size = new System.Drawing.Size(67, 16);
            this.Pencarian.TabIndex = 28;
            this.Pencarian.Text = "pencarian";
            this.Pencarian.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 714);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataMahasiswa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nohp;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox npm;
        private System.Windows.Forms.ComboBox angkatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataMahasiswa;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Pencarian;
        private System.Windows.Forms.TextBox tbCariData;
    }
}

