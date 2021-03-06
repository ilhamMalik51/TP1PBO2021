using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO
{
    class Pelanggan
    {
        public string nama { get; set; }
        public string NIM { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool status { get; set; }

        public Pelanggan(string nama, string NIM)
        {
            this.nama = nama;
            this.NIM = NIM;
        }

        public Pelanggan()
        {
        }

        public bool login(Pelanggan pelanggan)
        {
            if(pelanggan.password == "pbo123" && !string.IsNullOrEmpty(pelanggan.username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
