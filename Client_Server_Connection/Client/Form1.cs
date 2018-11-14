using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += clientDataReceived;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            try
            {
                client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
                serverStatus.BackColor = Color.Green;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Връзката не е осъществена.",
                    "Проблем",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                btnConnect.Enabled = true;
            }           
        }

        private void clientDataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;
            });
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
            } catch (Exception) {
                MessageBox.Show(
                   "Съобщението което пращате е невалидно",
                   "Възникна грешка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            txtMessage.Text = "";
        }
    }
}
