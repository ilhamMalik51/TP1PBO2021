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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Pelanggan pelanggan = new Pelanggan(); //instansiasi objek

            pelanggan.username = Convert.ToString(tbUsername.Text);
            pelanggan.password = Convert.ToString(tbPassword.Text);

            if (pelanggan.login(pelanggan))
            {
                string message = "Login Berhasil!";
                string judul = "Status Login";
                MessageBox.Show(message, judul);

                this.Hide();
                Home dashboard = new Home();
                dashboard.ShowDialog();
            }
            else
            {
                string message = "Login Gagal! Username atau Password Salah! Password = pbo123 Username Boleh Apa Saja Tapi Tidak Boleh Kosong";
                string judul = "Status Login";
                MessageBox.Show(message, judul);
            }

        }
    }
}
