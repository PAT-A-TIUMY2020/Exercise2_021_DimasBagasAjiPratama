using ServiceRest_021_Dimas_Bagas_AjiPratama;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_021_DimasBagasAjiPratama
{
    public partial class Form1 : Form
    {
        ServiceHost hostObj = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnon.Enabled = true;
            btnoff.Enabled = false;
        }

        private void btnon_Click(object sender, EventArgs e)
        {
            try
            {
                btnon.Enabled = false;
                btnoff.Enabled = true;
                ServiceHost hostObj = null;
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                lblonoff.Text = "Server ON";
                lblmessage.Text = "Klik OFF untuk Mematikan Server";


            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    btnon.Enabled = true;
                    btnoff.Enabled = false;
                    ServiceHost hostObj = null;
                    hostObj = new ServiceHost(typeof(TI_UMY));
                    hostObj.Close();
                    lblonoff.Text = "Server OFF";
                    lblmessage.Text = "Klik ON untuk Menjalankan Server";


                }

                catch (Exception ex)
                {
                    hostObj = null;
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}
