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

namespace Client_Server_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += serverDataReceived;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
            try
            {               
                server.Start(ip, Convert.ToInt32(txtPort.Text));
                txtStatus.Items.Add("Сървъра слуша...");
                serverStatus.BackColor = Color.Green;
            } catch (Exception) {

                MessageBox.Show(
                    "Айпито или порта са грешни, моля въведете правилно АЙПИ или ПОРТ",
                    "Възникна грешка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                txtStatus.Text = "Сървъра е спрян";
                serverStatus.BackColor = Color.Red;
                server.Stop();
            }
        }

        private void serverDataReceived(object sender, SimpleTCP.Message e)
        {
            //Delegates are used to pass methods as arguments to other methods
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Items.Add(e.MessageString);
                e.ReplyLine(string.Format("Клиент: ", e.MessageString));
            });
        }
    }
}
