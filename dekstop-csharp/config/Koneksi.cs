using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace dekstop_csharp.config
{
    internal class Koneksi
    {
       static String koneksi= "server=localhost;user=root;database=db_spp_sekolaah_xii;password=;";
        public static MySqlConnection getconnection()
        {
            MySqlConnection koneksi = new MySqlConnection();
            try 
            { 
         
                koneksi.Open();
                return koneksi;
            }
            catch (Exception)
            {
                MessageBox.Show("gagal terhubung ke database");
            }
            return null;
        }
    }
}
