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
        public Form1()
        {
            InitializeComponent();
        }

        private Socket SSockUDP;
        private IPEndPoint ipedD;
        private IPEndPoint ipedR;
        private void button_connexion_Click_Click(object sender, EventArgs e)
        {
            this.SSockUDP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.SSockUDP.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 500); // Définition du socket commit #5



            //connection sur le serveur 127.0.0.1 port 80 
            ipedR = new IPEndPoint(IPAddress.Parse(this.textBox_ip_recp.Text), int.Parse(textBox_port_recp.Text)); // correspond à ip Reception
             ipedD = new IPEndPoint(IPAddress.Parse(this.textBox_dest_ip.Text), int.Parse(textBox_dest_port.Text));
            
            //ipedD = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2022);
           
            

            try
            {
                //this.SSockUDP.Connect(ipedD);
                this.SSockUDP.Bind(ipedR);
            }
            catch (System.Net.Sockets.SocketException se)
            {
                MessageBox.Show("Erreur Connexion"+ se.ToString());
            }
        }

        private void button_fermer_Click_Click(object sender, EventArgs e)
        {
            this.SSockUDP.Shutdown(SocketShutdown.Both);
            this.SSockUDP.Close();
        }

        private void button_envoyer_Click(object sender, EventArgs e)
        {

            var messageEnvoi = Encoding.ASCII.GetBytes(this.richTextBox_envoi.Text);
            // this.SSockUDP.Send(messageEnvoi);;
            this.SSockUDP.SendTo(messageEnvoi, this.ipedD);
            
     
        }

        private void button_recevoir_Click(object sender, EventArgs e)
        {
            if(SSockUDP != null)
            {
                timer1.Start();
            }
            
        }

        private void button_cls_Click_1(object sender, EventArgs e)
        {
            this.textBox_recp.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(SSockUDP.Available != 0) // Fonction permet de vérifier si il y'a des donner en réception de la socket. 
            {
                var messageRecu = new byte[1024];
                int nbcarrecu = this.SSockUDP.Receive(messageRecu);
                this.textBox_recp.Text = "nbcarecu " + nbcarrecu + "\n" +
                             Encoding.ASCII.GetString(messageRecu, 0, nbcarrecu);
            }

        }
    }
}
