namespace TCPclient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.bwConnetion = new System.ComponentModel.BackgroundWorker();
            this.bCancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.haslo = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbNick = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.Label();
            this.nRoom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.niMsg = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(74, 24);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "192.168.0.13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(361, 24);
            this.nPort.Maximum = new decimal(new int[] {
            6500,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(120, 20);
            this.nPort.TabIndex = 3;
            this.nPort.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.Color.Wheat;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.HorizontalScrollbar = true;
            this.lbLog.Location = new System.Drawing.Point(26, 49);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(455, 69);
            this.lbLog.TabIndex = 4;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(180, 20);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(78, 23);
            this.bConnect.TabIndex = 6;
            this.bConnect.Text = "CONNECT";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bwConnetion
            // 
            this.bwConnetion.WorkerSupportsCancellation = true;
            this.bwConnetion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnetion_DoWork);
            // 
            // bCancel
            // 
            this.bCancel.Enabled = false;
            this.bCancel.Location = new System.Drawing.Point(264, 20);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(52, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "END";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbChat
            // 
            this.lbChat.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbChat.FormattingEnabled = true;
            this.lbChat.HorizontalScrollbar = true;
            this.lbChat.Location = new System.Drawing.Point(26, 125);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(455, 108);
            this.lbChat.TabIndex = 9;
            this.lbChat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbChat_KeyUp);
            // 
            // tbMsg
            // 
            this.tbMsg.BackColor = System.Drawing.Color.Bisque;
            this.tbMsg.Location = new System.Drawing.Point(26, 240);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(455, 20);
            this.tbMsg.TabIndex = 10;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(26, 267);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(455, 23);
            this.bSend.TabIndex = 11;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bw2
            // 
            this.bw2.WorkerSupportsCancellation = true;
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.Location = new System.Drawing.Point(487, 30);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(36, 13);
            this.haslo.TabIndex = 12;
            this.haslo.Text = "Hasło";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(529, 26);
            this.tbHaslo.MaxLength = 50;
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(141, 20);
            this.tbHaslo.TabIndex = 13;
            this.tbHaslo.Text = "password";
            // 
            // tbNick
            // 
            this.tbNick.Location = new System.Drawing.Point(529, 53);
            this.tbNick.MaxLength = 50;
            this.tbNick.Name = "tbNick";
            this.tbNick.Size = new System.Drawing.Size(141, 20);
            this.tbNick.TabIndex = 14;
            this.tbNick.Text = "nick";
            this.tbNick.WordWrap = false;
            // 
            // nick
            // 
            this.nick.AutoSize = true;
            this.nick.Location = new System.Drawing.Point(487, 56);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(29, 13);
            this.nick.TabIndex = 15;
            this.nick.Text = "Nick";
            // 
            // nRoom
            // 
            this.nRoom.Location = new System.Drawing.Point(529, 79);
            this.nRoom.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nRoom.Name = "nRoom";
            this.nRoom.Size = new System.Drawing.Size(141, 20);
            this.nRoom.TabIndex = 16;
            this.nRoom.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pokój";
            // 
            // lbUsers
            // 
            this.lbUsers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.Location = new System.Drawing.Point(490, 125);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(180, 108);
            this.lbUsers.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pokój";
            // 
            // niMsg
            // 
            this.niMsg.Icon = ((System.Drawing.Icon)(resources.GetObject("niMsg.Icon")));
            this.niMsg.Text = "notifyIcon1";
            this.niMsg.Visible = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Text = "SzymCZAT";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(682, 330);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nRoom);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.tbNick);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.nPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SzymCZAT [client] ";
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button bConnect;
        private System.ComponentModel.BackgroundWorker bwConnetion;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button bSend;
        private System.ComponentModel.BackgroundWorker bw2;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbNick;
        private System.Windows.Forms.Label nick;
        private System.Windows.Forms.NumericUpDown nRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon niMsg;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

