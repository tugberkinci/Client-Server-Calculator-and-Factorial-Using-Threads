using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public partial class Form1 : Form
    {

        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(IpTextBox.Text), int.Parse(PortTextBox.Text));
            try
            {
                client.Connect(IpEnd);
                if (client.Connected)
                {
                    ConnectLabel.Text=("Connected to Server ");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    //backgroundWorker1.RunWorkerAsync();
                    
                    backgroundWorker1.WorkerSupportsCancellation = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (client.Connected)
            {
                STW.WriteLine(TextToSend);
                recieve = STR.ReadLine();
                this.RecivedLabel.Invoke(new MethodInvoker(delegate ()
                 {
                     RecivedLabel.Text = recieve;
                 }
                ));


            }
            else
            {
                MessageBox.Show("Sending failed");
            }
            backgroundWorker1.CancelAsync();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (SendTextBox.Text != "")
            {
                TextToSend = SendTextBox.Text;
                
                backgroundWorker1.RunWorkerAsync();
            }
            else
                MessageBox.Show("İnvalid input");
            SendTextBox.Text = "";
        }

        

        
        
           

        
    }
    }

