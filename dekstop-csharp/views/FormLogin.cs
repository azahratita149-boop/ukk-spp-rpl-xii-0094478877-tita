using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dekstop_csharp.views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            txtpassword.UseSystemPasswordChar = true;
            
            string connect = "server=localhost;user=root;database db_spp_sekolaah_xii;password=;";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
                return;
                
            }
            else
            {
                string username = txtusername.Text;
                string password = txtpassword.Text;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string koneksi = "server=localhost;user=root;database db_spp_sekolaah_xii;password=;";

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin mendaftar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormRegistertugas formRegistertugas = new FormRegistertugas();
                formRegistertugas.Show();
                this.Hide();
            } 
        } 
    } 
}
