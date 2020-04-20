namespace VideoSync
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.initializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToPeerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatMsgTb = new System.Windows.Forms.TextBox();
            this.selfEndpointTb = new System.Windows.Forms.TextBox();
            this.keepAliveTimer = new System.Windows.Forms.Timer(this.components);
            this.recvQueueTimer = new System.Windows.Forms.Timer(this.components);
            this.sendQueueTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(422, 91);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(174, 231);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeToolStripMenuItem,
            this.connectToPeerToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // initializeToolStripMenuItem
            // 
            this.initializeToolStripMenuItem.Name = "initializeToolStripMenuItem";
            this.initializeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.initializeToolStripMenuItem.Text = "Initialize";
            this.initializeToolStripMenuItem.Click += new System.EventHandler(this.initializeToolStripMenuItem_Click);
            // 
            // connectToPeerToolStripMenuItem
            // 
            this.connectToPeerToolStripMenuItem.Name = "connectToPeerToolStripMenuItem";
            this.connectToPeerToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.connectToPeerToolStripMenuItem.Text = "Connect to Peer";
            this.connectToPeerToolStripMenuItem.Click += new System.EventHandler(this.connectToPeerToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // chatMsgTb
            // 
            this.chatMsgTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chatMsgTb.Location = new System.Drawing.Point(422, 328);
            this.chatMsgTb.Multiline = true;
            this.chatMsgTb.Name = "chatMsgTb";
            this.chatMsgTb.Size = new System.Drawing.Size(174, 58);
            this.chatMsgTb.TabIndex = 3;
            this.chatMsgTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatMsgTb_KeyDown);
            // 
            // selfEndpointTb
            // 
            this.selfEndpointTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selfEndpointTb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.selfEndpointTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selfEndpointTb.Location = new System.Drawing.Point(422, 1);
            this.selfEndpointTb.Name = "selfEndpointTb";
            this.selfEndpointTb.Size = new System.Drawing.Size(174, 20);
            this.selfEndpointTb.TabIndex = 4;
            // 
            // keepAliveTimer
            // 
            this.keepAliveTimer.Enabled = true;
            this.keepAliveTimer.Interval = 1000;
            this.keepAliveTimer.Tick += new System.EventHandler(this.keepAliveTimer_Tick);
            // 
            // recvQueueTimer
            // 
            this.recvQueueTimer.Enabled = true;
            this.recvQueueTimer.Interval = 166;
            this.recvQueueTimer.Tick += new System.EventHandler(this.recvQueueTimer_Tick);
            // 
            // sendQueueTimer
            // 
            this.sendQueueTimer.Enabled = true;
            this.sendQueueTimer.Interval = 333;
            this.sendQueueTimer.Tick += new System.EventHandler(this.sendQueueTimer_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(12, 27);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(404, 359);
            this.mediaPlayer.TabIndex = 5;
            this.mediaPlayer.NewStream += new System.EventHandler(this.mediaPlayer_NewStream);
            this.mediaPlayer.Buffering += new AxWMPLib._WMPOCXEvents_BufferingEventHandler(this.mediaPlayer_Buffering);
            this.mediaPlayer.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.mediaPlayer_MediaChange);
            this.mediaPlayer.CurrentMediaItemAvailable += new AxWMPLib._WMPOCXEvents_CurrentMediaItemAvailableEventHandler(this.mediaPlayer_CurrentMediaItemAvailable);
            this.mediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(422, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 58);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 398);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.chatMsgTb);
            this.Controls.Add(this.selfEndpointTb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatWindow";
            this.Text = "ChatWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatWindow_FormClosing);
            this.Load += new System.EventHandler(this.ChatWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem initializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToPeerToolStripMenuItem;
        private System.Windows.Forms.TextBox chatMsgTb;
        private System.Windows.Forms.TextBox selfEndpointTb;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer keepAliveTimer;
        private System.Windows.Forms.Timer recvQueueTimer;
        private System.Windows.Forms.Timer sendQueueTimer;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ListView listView1;
    }
}