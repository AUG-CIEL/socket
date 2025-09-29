namespace socketUDP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ip_recp = new System.Windows.Forms.TextBox();
            this.textBox_port_recp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_connexion_Click = new System.Windows.Forms.Button();
            this.button_fermer = new System.Windows.Forms.Button();
            this.button_envoyer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dest_ip = new System.Windows.Forms.TextBox();
            this.textBox_dest_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_recevoir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_envoi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_cls = new System.Windows.Forms.Button();
            this.textBox_recp = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recp.";
            // 
            // textBox_ip_recp
            // 
            this.textBox_ip_recp.Location = new System.Drawing.Point(54, 25);
            this.textBox_ip_recp.Name = "textBox_ip_recp";
            this.textBox_ip_recp.Size = new System.Drawing.Size(69, 20);
            this.textBox_ip_recp.TabIndex = 1;
            this.textBox_ip_recp.Text = "127.0.0.1";
            // 
            // textBox_port_recp
            // 
            this.textBox_port_recp.Location = new System.Drawing.Point(140, 25);
            this.textBox_port_recp.Name = "textBox_port_recp";
            this.textBox_port_recp.Size = new System.Drawing.Size(60, 20);
            this.textBox_port_recp.TabIndex = 2;
            this.textBox_port_recp.Text = "2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IpeR";
            // 
            // button_connexion_Click
            // 
            this.button_connexion_Click.Location = new System.Drawing.Point(329, 23);
            this.button_connexion_Click.Name = "button_connexion_Click";
            this.button_connexion_Click.Size = new System.Drawing.Size(166, 23);
            this.button_connexion_Click.TabIndex = 4;
            this.button_connexion_Click.Text = "Créer Socket et Bind(IPeR)";
            this.button_connexion_Click.UseVisualStyleBackColor = true;
            this.button_connexion_Click.Click += new System.EventHandler(this.button_connexion_Click_Click);
            // 
            // button_fermer
            // 
            this.button_fermer.Location = new System.Drawing.Point(329, 70);
            this.button_fermer.Name = "button_fermer";
            this.button_fermer.Size = new System.Drawing.Size(165, 23);
            this.button_fermer.TabIndex = 5;
            this.button_fermer.Text = "Fermer Close()";
            this.button_fermer.UseVisualStyleBackColor = true;
            this.button_fermer.Click += new System.EventHandler(this.button_fermer_Click_Click);
            // 
            // button_envoyer
            // 
            this.button_envoyer.Location = new System.Drawing.Point(329, 119);
            this.button_envoyer.Name = "button_envoyer";
            this.button_envoyer.Size = new System.Drawing.Size(165, 23);
            this.button_envoyer.TabIndex = 6;
            this.button_envoyer.Text = "Envoyer SendTo(IPeD)";
            this.button_envoyer.UseVisualStyleBackColor = true;
            this.button_envoyer.Click += new System.EventHandler(this.button_envoyer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dest.";
            // 
            // textBox_dest_ip
            // 
            this.textBox_dest_ip.Location = new System.Drawing.Point(53, 57);
            this.textBox_dest_ip.Name = "textBox_dest_ip";
            this.textBox_dest_ip.Size = new System.Drawing.Size(70, 20);
            this.textBox_dest_ip.TabIndex = 8;
            this.textBox_dest_ip.Text = "127.0.0.1";
            // 
            // textBox_dest_port
            // 
            this.textBox_dest_port.Location = new System.Drawing.Point(140, 57);
            this.textBox_dest_port.Name = "textBox_dest_port";
            this.textBox_dest_port.Size = new System.Drawing.Size(60, 20);
            this.textBox_dest_port.TabIndex = 9;
            this.textBox_dest_port.Text = "2022";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IPeD";
            // 
            // button_recevoir
            // 
            this.button_recevoir.Location = new System.Drawing.Point(329, 170);
            this.button_recevoir.Name = "button_recevoir";
            this.button_recevoir.Size = new System.Drawing.Size(165, 35);
            this.button_recevoir.TabIndex = 11;
            this.button_recevoir.Text = "Recevoir ReceiveFrom() Bloquant Timeout";
            this.button_recevoir.UseVisualStyleBackColor = true;
            this.button_recevoir.Click += new System.EventHandler(this.button_recevoir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Envoi";
            // 
            // richTextBox_envoi
            // 
            this.richTextBox_envoi.Location = new System.Drawing.Point(53, 121);
            this.richTextBox_envoi.Name = "richTextBox_envoi";
            this.richTextBox_envoi.Size = new System.Drawing.Size(176, 68);
            this.richTextBox_envoi.TabIndex = 13;
            this.richTextBox_envoi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Recp.";
            // 
            // button_cls
            // 
            this.button_cls.Location = new System.Drawing.Point(267, 333);
            this.button_cls.Name = "button_cls";
            this.button_cls.Size = new System.Drawing.Size(46, 23);
            this.button_cls.TabIndex = 16;
            this.button_cls.Text = "CLS";
            this.button_cls.UseVisualStyleBackColor = true;
            this.button_cls.Click += new System.EventHandler(this.button_cls_Click_1);
            // 
            // textBox_recp
            // 
            this.textBox_recp.Location = new System.Drawing.Point(53, 244);
            this.textBox_recp.Multiline = true;
            this.textBox_recp.Name = "textBox_recp";
            this.textBox_recp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_recp.Size = new System.Drawing.Size(198, 112);
            this.textBox_recp.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 381);
            this.Controls.Add(this.textBox_recp);
            this.Controls.Add(this.button_cls);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox_envoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_recevoir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_dest_port);
            this.Controls.Add(this.textBox_dest_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_envoyer);
            this.Controls.Add(this.button_fermer);
            this.Controls.Add(this.button_connexion_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_port_recp);
            this.Controls.Add(this.textBox_ip_recp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ip_recp;
        private System.Windows.Forms.TextBox textBox_port_recp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_connexion_Click;
        private System.Windows.Forms.Button button_fermer;
        private System.Windows.Forms.Button button_envoyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dest_ip;
        private System.Windows.Forms.TextBox textBox_dest_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_recevoir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_envoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_cls;
        private System.Windows.Forms.TextBox textBox_recp;
        private System.Windows.Forms.Timer timer1;
    }
}

