using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Linq;
using System.Net;

namespace TCPclient
{
    public partial class Form1 : Form
    {

        TcpClient client = null;
        BinaryReader reading = null;
        BinaryWriter writing = null;
        private int visibleItems = 0;
        private int visibleItemsLogs = 0;

        private void lbChat_KeyUp(object sender, KeyEventArgs e)//enter
        {
            if (sender != lbChat) return;

            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        }

        private void CopySelectedValuesToClipboard()//ctr+c
        {
            try
            {
                string items = "";
                foreach (int index in lbChat.SelectedIndices)
                {
                    items += (lbChat.Items[index] as string) + '\n';
                }
                Clipboard.SetText(items.Trim()); // trim to remove the remaining '\n'

                //Clipboard.SetText(builder.ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        static string Hash(string input)//hasowanie
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }

        private string jsonS(string msg, string sys)
        {
            string[] send = { msg, sys };
            string json = JsonConvert.SerializeObject(send);
            return json;
        }
        private string jsonS(string msg)
        {
            string[] send = { msg };
            string json = JsonConvert.SerializeObject(send);
            return json;
        }

        private string[] jsonD(string msg)
        {
            string[] json = JsonConvert.DeserializeObject<string[]>(msg);
            return json;
        }
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bSend.PerformClick();
            }
        }

        protected void Displaynotify(string title, string msg)
        {
            try
            {
                niMsg.Text = "SzymCZAT";
                niMsg.Visible = true;
                niMsg.BalloonTipTitle = title;
                niMsg.BalloonTipText = msg;
                niMsg.ShowBalloonTip(100);
            }
            catch (Exception ex)
            {
            }
        }

        public Form1()
        {
            InitializeComponent();
            tbMsg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            Random rnd = new Random();
            tbNick.Text += rnd.Next(1, 100);

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    lbLog.Items.Add(ip.ToString());
                    tbAddress.Text = ip.ToString();
                }
            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            tbMsg.Focus();
            lbChat.Items.Clear();
            lbChat.Invoke(new MethodInvoker(delegate {
                visibleItems = lbChat.ClientSize.Height / lbChat.ItemHeight;
            }));
            lbLog.Invoke(new MethodInvoker(delegate {
                visibleItemsLogs = lbLog.ClientSize.Height / lbLog.ItemHeight;
            }));
            try
            {
                bConnect.Enabled = false;
                if (!bwConnetion.IsBusy)
                    bwConnetion.RunWorkerAsync();
                bCancel.Enabled = true;
                tbAddress.Enabled = false;
                tbHaslo.Enabled = false;
                nPort.Enabled = false;
                tbNick.Enabled = false;
                nRoom.Enabled = false;
            }
            catch
            {
            }
        }

        private void bwConnetion_DoWork(object sender, DoWorkEventArgs e)
        {


            bool activeCall = false;
            string host = tbAddress.Text;
            int port = System.Convert.ToInt16(nPort.Value);
            string password = tbHaslo.Text;
            string nick = tbNick.Text;
            int room = System.Convert.ToInt16(nRoom.Value);

            IPAddress address = Dns.GetHostAddresses(host)[0];           

            //connection:
            if (password != "" && nick != "" && host != "")
            {
                try
                {
                    
                    client = new TcpClient(address.ToString(), port);
                    NetworkStream ns = client.GetStream();
                    reading = new BinaryReader(ns);
                    writing = new BinaryWriter(ns);
                    string[] send = { Hash(password), nick, room.ToString() };
                    string json = JsonConvert.SerializeObject(send);
                    writing.Write(json);
                    lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Łącze..."); }));
                    string response = jsonD(reading.ReadString())[0];
                    if (response == "1")
                    {
                        activeCall = true;
                        lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port); }));
                        if (!bw2.IsBusy)
                            bw2.RunWorkerAsync();
                        lbUsers.Invoke(new MethodInvoker(delegate {
                            lbUsers.Items.Clear();
                            lbUsers.Items.Add(nick);
                        }));
                    } else if (response == "2")
                    {
                        lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Nick jest zajęty"); }));
                        activeCall = false;
                        bCancel.Invoke(new MethodInvoker(delegate {
                            bCancel.PerformClick();
                        }));
                    }
                    else
                    {
                        lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Odrzucono"); }));
                        bCancel.Invoke(new MethodInvoker(delegate {
                            bCancel.PerformClick();
                        }));
                        activeCall = false;
                    }
                    lbLog.Invoke(new MethodInvoker(delegate { lbLog.TopIndex = Math.Max(lbLog.Items.Count - visibleItemsLogs + 1, 0); }));
                }
                catch (Exception ex)
                {
                    lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Problem z połaczniem"); }));
                    activeCall = false;
                    bCancel.Invoke(new MethodInvoker(delegate {
                        bCancel.PerformClick();
                    }));
                    lbLog.Invoke(new MethodInvoker(delegate { lbLog.TopIndex = Math.Max(lbLog.Items.Count - visibleItemsLogs + 1, 0); }));

                    //MessageBox.Show(ex.ToString());
                }


                ////sending a message:
            }

        }

        private void bCancel_Click(object sender, EventArgs e)
        {

            try
            {
                writing.Write("//command END");
                bwConnetion.CancelAsync();
                bw2.CancelAsync();
                bw2.Dispose();
                client.Close();
            }
            catch
            {
            }
            finally {
                bConnect.Enabled = true;
                bCancel.Enabled = false;
                tbAddress.Enabled = true;
                tbHaslo.Enabled = true;
                tbNick.Enabled = true;
                nRoom.Enabled = true;
                nPort.Enabled = true;
            }
        }

        private void bw2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] messageRecived;
                while (true)
                {
                    messageRecived = jsonD(reading.ReadString());
                    if (messageRecived[0].Length > 30)
                    {
                        string msg = messageRecived[0];
                        Displaynotify("Nowa wiadomość", msg.Remove(30, (msg.Length - 30)) + "...");
                    }
                    else
                    { Displaynotify("Nowa wiadomość", messageRecived[0]); }

                    lbChat.Invoke(new MethodInvoker(delegate { lbChat.Items.Add(messageRecived[0]); }));
                    lbChat.Invoke(new MethodInvoker(delegate { lbChat.TopIndex = Math.Max(lbChat.Items.Count - visibleItems + 1, 0); }));
                    if (messageRecived.Length == 2)
                    {
                        lbUsers.Invoke(new MethodInvoker(delegate {
                            lbUsers.Items.Clear();
                            string[] users = jsonD((messageRecived[1]));
                            for (int i = 0; i < users.Length; i++)
                            {
                                lbUsers.Items.Add(users[i]);
                            }
                        }));

                    }

                }

            }
            catch (Exception ex)
            {
                lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Połączenie zakończone"); }));
                client.Close();
                bCancel.Invoke(new MethodInvoker(delegate { bCancel.PerformClick(); }));
                // MessageBox.Show(ex.ToString(), "Błąd recive ");
            }
        }
        private int spam = 0;
        private bool resetedSpam = false;
        private void resetSpam() {
            if (!resetedSpam)
            { spam = 0; resetedSpam = false; }
        }
        private void bSend_Click(object sender, EventArgs e)
        {
            
            if (tbMsg.Text != "")
                try
            {
                   // resetSpam().Delay()
                    resetedSpam = true;
                    if (spam<5) {
                        string messageSent = tbMsg.Text;//for example//=TextBoxl.text;
                        writing.Write(messageSent);
                        tbMsg.Text = "";
                        spam++;
                    }
                //lbChat.Items.Add(messageSent);
            }
            catch
            {
                lbLog.Invoke(new MethodInvoker(delegate { lbLog.Items.Add("Problem z połaczniem"); }));
                lbLog.Invoke(new MethodInvoker(delegate { lbLog.TopIndex = Math.Max(lbLog.Items.Count - visibleItemsLogs + 1, 0); }));

                }
        }
    }
}
