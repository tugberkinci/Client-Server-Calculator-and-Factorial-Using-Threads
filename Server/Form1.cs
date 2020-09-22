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
using System.Linq.Expressions;
using System.Threading;

namespace Server
{
   
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TextToSend;
        public static object _locker = new object();



        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress adress in localIP)
            {
                if (adress.AddressFamily == AddressFamily.InterNetwork)
                {
                    IpTextBox.Text = adress.ToString();
                }
            }
        }

        

        private void ServerSatartButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(PortTextBox.Text));
            try
            {
                listener.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.RecivedLabel.Invoke(new MethodInvoker(delegate ()
                    {
                        RecivedLabel.Text = recieve;
                    }
                ));

                    //STW.WriteLine(calculate(recieve));
                    //recieve = "";
                    int index_fac = recieve.IndexOf('!');
                    int index_fib = recieve.IndexOf('f');
                    int index_fib_upper = recieve.IndexOf('F');
                    int index_sum = recieve.IndexOf('+');
                    int index_sub = recieve.IndexOf('-');
                    int index_mul = recieve.IndexOf('*');
                    int index_div = recieve.IndexOf('/');

                    if (index_fac >= 1)
                    {
                        
                        
                        long k=Factoria(translate(recieve));
                        STW.WriteLine(k.ToString());

                    }
                    else if (index_fib >= 1 || index_fib_upper >= 1)
                    {
                        //result = fibonacci(str);
                        

                        var doneEvents = new ManualResetEvent(true);     
                        doneEvents = new ManualResetEvent(false);
                        var f = new Fibonacci(translate(recieve), doneEvents);
                        STW.WriteLine(f.ToString());


                        //ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback);


                        // WaitHandle.WaitAll(doneEvents);



                        //
                    }

                    else if (index_mul >= 1 || index_sub >= 1 || index_sum >= 1 || index_div >= 1)
                    {
                        //result = new DataTable().Compute(str, null).ToString();
                        STW.WriteLine(new DataTable().Compute(recieve, null).ToString());
                    }
                    else
                        STW.WriteLine("İnvalid input");

                    ////
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Factorial(int v)
        {
            throw new NotImplementedException();
        }

        /*
public string calculate(string str)
{
   string result;
   try
   {
       int index_fac = str.IndexOf('!');
       int index_fib = str.IndexOf('f');
       int index_fib_upper = str.IndexOf('F');
       int index_sum = str.IndexOf('+');
       int index_sub = str.IndexOf('-');
       int index_mul = str.IndexOf('*');
       int index_div = str.IndexOf('/');

       if (index_fac >= 1)
       {
           result = factorial(str);
       }
       else if (index_fib >= 1 || index_fib_upper >= 1)
       {
           result = fibonacci(str);
       }

       else if (index_mul >= 1 || index_sub >= 1 || index_sum >= 1 || index_div >= 1)
       {
           result = new DataTable().Compute(str, null).ToString();
       }
       else
           result = "İnvalid input";
   }
   catch(Exception ex)
   {
       result = "Please calculate again";
       MessageBox.Show(ex.Message.ToString());
   }


   return result;
}
*/

        public int translate(string fac)
        {
            int factor = 1;
            int var = 0;
            int tempt;
            int a;
            int counter = 0;
            
            char[] delimiterChars = {'!'};
            string[] words = fac.Split(delimiterChars);
            foreach (var word in words)
            {
                if (counter == words.Length - 1)
                    break;

                a = Int32.Parse(word);
                tempt = a * factor;
                var = var + tempt;
                factor = factor * 10;
                counter++;
            }
            int fact=var;
            for (int i = 1; i < var; i++)
            {
                fact = fact * i;
            }

            

            return var;
        }
        public static long Factoria(int x)
        {
            long result = 1;
            int right = 0;
            int nr = x;
            bool done = false;

            for (int i = 0; i < nr; i += (nr / 4))
            {
                int step = i;

                new Thread(new ThreadStart(() =>
                {
                    right = (step + nr / 4) > nr ? nr : (step + nr / 4);
                    long chunkResult = ChunkFactorial(step + 1, right);

                    lock (_locker)
                    {
                        result *= chunkResult;
                        if (right == nr)
                            done = true;
                    }
                })).Start();
            }

            while (!done)
            {
                Thread.Sleep(10);
            }

            return result;
        }

        public static long ChunkFactorial(int left, int right)
        {
            
            if (left == right)
                return left == 0 ? 1 : left;
            else return right * ChunkFactorial(left, right - 1);
        }


        

      
    }
}
