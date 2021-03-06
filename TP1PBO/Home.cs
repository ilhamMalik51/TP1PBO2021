using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO
{
    public partial class Home : Form
    {
        List<Barang> listBarang = new List<Barang>();

        public Home()
        {
            InitializeComponent();
            Barang barang1 = new Barang("Jersey", "Baju", 120000, "120.000");
            Barang barang2 = new Barang("Gelato", "Makanan", 145000, "145.000");
            Barang barang3 = new Barang("Laptop", "Elektronik", 1000000, "1.000.000");
            Barang barang4 = new Barang("Mouse", "Elektronik", 250000, "250.000");
            Barang barang5 = new Barang("Gucci", "Baju", 750000, "750.000");

            barang1.alamatFoto = @"C:\Users\USER\source\repos\TP1PBO\TP1PBO\images\jersey.jpg";
            barang2.alamatFoto = @"C:\Users\USER\source\repos\TP1PBO\TP1PBO\images\gelato.jpg";
            barang3.alamatFoto = @"C:\Users\USER\source\repos\TP1PBO\TP1PBO\images\laptop.png";
            barang4.alamatFoto = @"C:\Users\USER\source\repos\TP1PBO\TP1PBO\images\mouse.jpg";
            barang5.alamatFoto = @"C:\Users\USER\source\repos\TP1PBO\TP1PBO\images\gucci.jpg";
            
            listBarang.Add(barang1);
            listBarang.Add(barang2);
            listBarang.Add(barang3);
            listBarang.Add(barang4);
            listBarang.Add(barang5);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            direction("baru", null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void tmplBarang(int left, Barang barang)
        {
            Label hargaBarang = new Label();
            this.Controls.Add(hargaBarang);

            Label namaBarang = new Label();
            this.Controls.Add(namaBarang);

            PictureBox ktkFoto = new PictureBox();
            this.Controls.Add(ktkFoto);

            Button btnBeli = new Button();
            this.Controls.Add(btnBeli);

            // 
            // hargaBarang
            // 
            hargaBarang.AutoSize = true;
            hargaBarang.Location = new System.Drawing.Point(left + 51, 244);
            hargaBarang.Name = "hargaBarang";
            hargaBarang.Size = new System.Drawing.Size(58, 20);
            hargaBarang.TabIndex = 14;
            hargaBarang.Text = "Rp." + barang.tmplHarga;
            // 
            // namaBarang
            // 
            namaBarang.AutoSize = true;
            namaBarang.Location = new System.Drawing.Point(left + 55, 224);
            namaBarang.Name = "namaBarang";
            namaBarang.Size = new System.Drawing.Size(111, 20);
            namaBarang.TabIndex = 13;
            namaBarang.Text = barang.namaBarang;
            // 
            // btnBeli
            // 
            btnBeli.Location = new System.Drawing.Point(left + 29, 267);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new System.Drawing.Size(99, 37);
            btnBeli.TabIndex = 15;
            btnBeli.Text = "Beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += new System.EventHandler((s , e) => btnBeli_Click(s , e, barang.namaBarang));
            // 
            // ktkFoto
            // 
            ktkFoto.Location = new System.Drawing.Point(left, 76);
            ktkFoto.Name = "ktkFoto";
            ktkFoto.Size = new System.Drawing.Size(120, 146);
            ktkFoto.TabIndex = 12;
            ktkFoto.TabStop = false;
            ktkFoto.Image = Image.FromFile(barang.alamatFoto);

        }

        private void direction(string status, string btnBeli)
        {
            int left = 120;

            if (status == "baru")
            {
                foreach (Barang bykBarang in listBarang)
                {
                    tmplBarang(left, bykBarang);
                    left += 150;
                }
            }
            else if (status == "filter")
            {
                int batasBawah = 0;
                int batasAtas = 0;

                if(Convert.ToString(cboHarga.SelectedItem) == "100.000 - 200.000")
                {
                    batasBawah = 100000;
                    batasAtas = 200000;
                }
                else if (Convert.ToString(cboHarga.SelectedItem) == "200.000 - 500.000")
                {
                    batasBawah = 200000;
                    batasAtas = 500000;
                }
                else if(Convert.ToString(cboHarga.SelectedItem) == "500.000 - 1.000.000")
                {
                    batasBawah = 500000;
                    batasAtas = 1000000;
                }


                foreach (Barang bykBarang in listBarang)
                {
                    if(bykBarang.jenisBarang == Convert.ToString(cboJenisBarang.SelectedItem))
                    {
                        if(bykBarang.hargaBarang >= batasBawah && bykBarang.hargaBarang <= batasAtas)
                        {
                            tmplBarang(left, bykBarang);
                            left += 150;
                        }
                    }
                }
            }
            else if (status == "beli" && btnBeli != null)
            {
                foreach (Barang bykBarang in listBarang)
                {
                    if(bykBarang.namaBarang == btnBeli)
                    {
                        tmplBarang(left, bykBarang);
                    }
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cboHarga.SelectedItem == null && cboJenisBarang.SelectedItem == null)
            {
                MessageBox.Show("Tolong Masukan Kedua Filter");
            }
            else
            {
                empty();
                direction("filter", null);
                btnKembali.Visible = false;
            }
        }

        private void empty()
        {
            
            foreach (Control c in this.Controls)
            {
                if (c.Name == "hargaBarang" || c.Name == "namaBarang" || c.Name == "ktkFoto" || c.Name == "btnBeli")
                {
                    c.Visible = false;
                }
            }
        }

        private void lblKatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://shopee.co.id/");
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            empty();
            direction("baru", null);
            btnKembali.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            f1.Show();

            this.Hide();
            this.Close();
        }

        private void btnBeli_Click(object sender, EventArgs e, string nama)
        {
            empty();
            direction("beli", nama);
            btnKembali.Visible = true;
            lblJudulBarang.Text = "Detail Barang:";
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            empty();
            direction("baru", null);
            btnKembali.Visible = false;
            lblJudulBarang.Text = "Semua Barang:";
        }
    }
}
