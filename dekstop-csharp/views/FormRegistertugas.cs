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
    public partial class FormRegistertugas : Form
    {
        public FormRegistertugas()
        {
            InitializeComponent();

            string koneksi = "server=localhost;user=root;database db_spp_sekolaah_xii;password=;";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {

            {
                if (txtUsername.Text == "" || txtpassword.Text == "" || cmblvl.SelectedItem == null)
                {
                    MessageBox.Show("Username, Password, dan Level tidak boleh kosong");
                    return;
                }
                else
                {
                    string username = txtUsername.Text;
                    string password = txtpassword.Text;
                    string level = cmblvl.SelectedItem.ToString();
                    // Lakukan proses penyimpanan data ke database sesuai kebutuhan Anda
                }
            }

        }

        private void txtpassword_Click(object sender, EventArgs e)
        {

        }

        private void FormRegistertugas_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {

            }
        }

        private void cmblvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblvl.SelectedItem.ToString() == "Admin")
            {
                MessageBox.Show("Anda memilih level Admin");
            }
            else if (cmblvl.SelectedItem.ToString() == "Petugas")
            {
                MessageBox.Show("Anda memilih level Petugas");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "konfirmasi password";
                txtpassword.ForeColor = Color.Black;
            }
        }
    }
}
