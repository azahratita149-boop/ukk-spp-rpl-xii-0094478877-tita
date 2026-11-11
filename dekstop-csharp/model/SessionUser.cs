using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekstop_csharp.model
{
    internal class SessionUser
    {
        public static int id_petugas { get; set; }
        public static string username { get; set; }
        public static string nama_petugas { get; set; }
        public static string level { get; set; }
        public static string isLoggedIn { get; set; }

        public static void setSession(int id_petugas, string username, string nama_petugas, string level, string isLoggedIn)
        {


        }

        public static void clearSession(Object sender, EventArgs e)
        {
            id_petugas = 0;
            username = null;
            nama_petugas = null;
            level = null;
            isLoggedIn = null;
        }

    }
}

    
