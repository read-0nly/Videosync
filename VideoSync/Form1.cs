﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VideoSync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionManager cm = new ConnectionManager();
            webBrowser1.DocumentText += "<body style='background-color:black;color:white'><b>Hello, </b>" + cm.Endpoint.ToString() + "<br><hr><br></body>";
            
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void connectToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open connection window, try to establish socket connection
            String targetEndpoint = Interaction.InputBox("Enter endpoint (IP.IP.IP.IP:Port)", "Connect to endpoint", "0.0.0.0:00000", -1, -1);     
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void receiveModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
