
namespace TP1PBO
{
    partial class Home
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
            this.lblNama = new System.Windows.Forms.Label();
            this.NIM = new System.Windows.Forms.Label();
            this.cboJenisBarang = new System.Windows.Forms.ComboBox();
            this.cboHarga = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblJenisBarang = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblJudulBarang = new System.Windows.Forms.Label();
            this.lblKatalog = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(932, 21);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(176, 20);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Muhammad Ilham Malik";
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(932, 58);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(72, 20);
            this.NIM.TabIndex = 2;
            this.NIM.Text = "1902563";
            // 
            // cboJenisBarang
            // 
            this.cboJenisBarang.FormattingEnabled = true;
            this.cboJenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.cboJenisBarang.Location = new System.Drawing.Point(10, 98);
            this.cboJenisBarang.Name = "cboJenisBarang";
            this.cboJenisBarang.Size = new System.Drawing.Size(180, 28);
            this.cboJenisBarang.TabIndex = 3;
            this.cboJenisBarang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboHarga
            // 
            this.cboHarga.FormattingEnabled = true;
            this.cboHarga.Items.AddRange(new object[] {
            "100.000 - 200.000",
            "200.000 - 500.000",
            "500.000 - 1.000.000"});
            this.cboHarga.Location = new System.Drawing.Point(10, 174);
            this.cboHarga.Name = "cboHarga";
            this.cboHarga.Size = new System.Drawing.Size(180, 28);
            this.cboHarga.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(10, 237);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(180, 108);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblJenisBarang
            // 
            this.lblJenisBarang.AutoSize = true;
            this.lblJenisBarang.Location = new System.Drawing.Point(10, 72);
            this.lblJenisBarang.Name = "lblJenisBarang";
            this.lblJenisBarang.Size = new System.Drawing.Size(102, 20);
            this.lblJenisBarang.TabIndex = 6;
            this.lblJenisBarang.Text = "Jenis Barang";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(10, 142);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(105, 20);
            this.lblRange.TabIndex = 7;
            this.lblRange.Text = "Range Harga";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Location = new System.Drawing.Point(350, 30);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(52, 20);
            this.lblHome.TabIndex = 8;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(690, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 48);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblJudulBarang
            // 
            this.lblJudulBarang.AutoSize = true;
            this.lblJudulBarang.Location = new System.Drawing.Point(226, 79);
            this.lblJudulBarang.Name = "lblJudulBarang";
            this.lblJudulBarang.Size = new System.Drawing.Size(124, 20);
            this.lblJudulBarang.TabIndex = 11;
            this.lblJudulBarang.Text = "Semua Barang :";
            this.lblJudulBarang.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblKatalog
            // 
            this.lblKatalog.AutoSize = true;
            this.lblKatalog.Location = new System.Drawing.Point(515, 30);
            this.lblKatalog.Name = "lblKatalog";
            this.lblKatalog.Size = new System.Drawing.Size(96, 20);
            this.lblKatalog.TabIndex = 12;
            this.lblKatalog.TabStop = true;
            this.lblKatalog.Text = "WebKatalog";
            this.lblKatalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblKatalog_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnKembali);
            this.panel1.Controls.Add(this.lblRange);
            this.panel1.Controls.Add(this.lblJenisBarang);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.cboHarga);
            this.panel1.Controls.Add(this.cboJenisBarang);
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 523);
            this.panel1.TabIndex = 13;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(10, 382);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(114, 48);
            this.btnKembali.TabIndex = 14;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Visible = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKatalog);
            this.Controls.Add(this.lblJudulBarang);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.lblNama);
            this.Name = "Home";
            this.Text = "Home";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.ComboBox cboJenisBarang;
        private System.Windows.Forms.ComboBox cboHarga;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblJenisBarang;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblJudulBarang;
        private System.Windows.Forms.LinkLabel lblKatalog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKembali;
    }
}