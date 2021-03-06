using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO
{
    public class Barang
    {
        public string namaBarang { get; set; }
        public string jenisBarang { get; set; }
        public int hargaBarang { get; set; }
        public string tmplHarga { get; set; }
        public string alamatFoto { get; set; }


        public Barang()
        {
        }
        public Barang(string namaBarang, string jenisBarang, int hargaBarang, string tmplHarga)
        {
            this.namaBarang = namaBarang;
            this.jenisBarang = jenisBarang;
            this.hargaBarang = hargaBarang;
            this.tmplHarga = tmplHarga;
        }
    }
}
