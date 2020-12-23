using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_021_Dimas_Bagas_AjiPratama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TampilData();
        }

        public void TampilData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            dataGridView1.DataSource = data;

        }

        public void SearchData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            string nim = txtnim.Text;
            if (nim == null || nim == "")
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                var item = data.Where(x => x.nim == txtnim.Text).ToList();

                dataGridView1.DataSource = item;
            }
        }

        public class Mahasiswa
        {
            private string _nama, _nim, _prodi, _angkatan;
            public string nama
            {
                get { return _nama; }
                set { _nama = value; }
            }

            public string nim
            {
                get { return _nim; }
                set { _nim = value; }
            }

            public string prodi
            {
                get { return _prodi; }
                set { _prodi = value; }
            }

            public string angkatan
            {
                get { return _angkatan; }
                set { _angkatan = value; }
            }
        }

        string baseurl = "http://localhost:1907/";



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.nama = txtnama.Text;
            mhs.nim = txtnim.Text;
            mhs.prodi = txtprodi.Text;
            mhs.angkatan = txtangkatan.Text;

            var data = JsonConvert.SerializeObject(mhs);
            var postdata = new WebClient();
            postdata.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = postdata.UploadString(baseurl + "Mahasiswa", data);
            Console.WriteLine(response);
            TampilData();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtnim.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            txtprodi.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            txtangkatan.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void btnjumlah_Click(object sender, EventArgs e)
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);
            int length = data.Count();
            lbljumlahdata.Text = Convert.ToString(length);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
