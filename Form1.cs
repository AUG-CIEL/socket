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

namespace socketUDP
{
    public partial class Form1 : Form
    {
       // private  Socket socket;
       private Socket SSockUDP;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button_cls_Click(object sender, EventArgs e)
        {
            this.textBox_recp.Clear();
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            this.SSockUDP = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream,
            ProtocolType.Tcp);

            //connection sur le serveur 127.0.0.1 port 80 
            IPEndPoint iped = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 80);

            
            try
            {
                this.SSockUDP.Connect(iped);
            }
            catch 
            {
                MessageBox.Show("Erreur Connexion"); 
            }
        }

        private void button_fermer_Click(object sender, EventArgs e)
        {
            this.SSockUDP.Shutdown(SocketShutdown.Both); 
            this.SSockUDP.Close();
        }

        private void button_envoyer_Click(object sender, EventArgs e)
        {
            this.SSockUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 5000);
            var messageEnvoi = Encoding.ASCII.GetBytes("Get /\r\n\r\n");
            this.SSockUDP.Send(messageEnvoi);
        }
    }
}
