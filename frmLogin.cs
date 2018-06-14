using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavy
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        string version = "2.1.0.0";
        WebClient wc = new WebClient();
        string verified;


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if(verified.Contains("minecraft") || verified.Contains("combo"))
            {
                frmDashboard frm = new frmDashboard();
                this.Hide();
                frm.Show();

            }
            else if (verified.Contains("not registered"))
            {
                MessageBox.Show("HWID not registered.", "Not registered.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else if ( verified.Contains("free"))
            {
                MessageBox.Show("Upgrade your plan!", "You don't have access.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else if (verified.Contains("csgo"))
            {
                MessageBox.Show("You don't have access to the cheat.\nYour plan: CS-GO CHEAT", "You don't have access.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else if (verified.Contains("error"))
            {
                MessageBox.Show("An internal error occurred, please try again later.", "An internal error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
               
            }


        }
      
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                
                string getCurrentVersion = wc.DownloadString("http://lavy.ml/api/version.txt");
                
                if (!getCurrentVersion.Contains(version))
                {
                    if (MessageBox.Show("You are using an old version, download a new version.", "New Version", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                    {
                        Process.Start(t69haSAA7K.Properties.Settings.Default.rootUrl +"/pt-br/?page=changelog");
                        Application.Exit();
                    }
                    else
                    {
                        Process.Start(t69haSAA7K.Properties.Settings.Default.rootUrl + "/pt-br/?page=changelog");
                        Application.Exit();
                    }
                   
                }
                else
                {
                    string drive = "C";
                    ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
                    dsk.Get();
                    string volumeSerial = dsk["VolumeSerialNumber"].ToString();

                     verified = wc.DownloadString("http://lavy.ml/api/hwid?hwid=" + volumeSerial);
                    
                }
            }
            catch (IOException ee)
            { 
            

                MessageBox.Show("Apparently our services are out of reach, try later!" + ee.Source);
                Application.Exit();

            }
            
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
