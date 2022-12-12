using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.controller;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        string id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil();
        }
        public void tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");

            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "NAMA";
            DataMahasiswa.Columns[2].HeaderText = "ANGKATAN";
            DataMahasiswa.Columns[3].HeaderText = "ALAMAT";
            DataMahasiswa.Columns[4].HeaderText = "EMAIL";
            DataMahasiswa.Columns[5].HeaderText = "NO hp";

        }

        private void npm_TextChanged(object sender, EventArgs e)
        {

        }

        private void nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void angkatan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void nohp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs= new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Insert(m_mhs);
                
                npm.Text = "";
                nama.Text = "";
                angkatan.Text = "";
                alamat.Text = "";
                email.Text = "";
                nohp.Text = "";
                tampil();
            }

        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (npm.Text == "" || nama.Text == "" || angkatan.SelectedIndex == -1 || alamat.Text == "" || email.Text == "" || nohp.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = npm.Text;
                m_mhs.Nama = nama.Text;
                m_mhs.Angkatan = angkatan.Text;
                m_mhs.Alamat = alamat.Text;
                m_mhs.Email = email.Text;
                m_mhs.Nohp = nohp.Text;

                mhs.Update(m_mhs, id);

                npm.Text = "";
                nama.Text = "";
                angkatan.Text = "";
                alamat.Text = "";
                email.Text = "";
                nohp.Text = "";
                tampil();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            npm.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            nama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            angkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            alamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            email.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            nohp.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
          
            DialogResult pesan = MessageBox.Show("apakah yakin anda ?", "perhatikan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(id);
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbCariData_TextChanged(object sender, EventArgs e)
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa WHERE npm LIKE '%' '" + tbCariData.Text + "' '%' OR nama LIKE '%' '" + tbCariData.Text + "' '%'");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
