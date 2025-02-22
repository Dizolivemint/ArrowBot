﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Arrow_Bot
{
    public partial class frmBot : Form
    {
        // Create a new instance of the Robot class
        private Robot Bot = new Robot();

        private Label lblBot = new Label();

        public frmBot()
        {
            InitializeComponent();

        }

        private void frmBot_Load(object sender, EventArgs e)
        {
            // Make it so that the form can't be resized or it will mess with calculations
            // this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Set the starting coordinates
            this.Bot.startX = boundryBox.Width / 2;
            this.Bot.startY = boundryBox.Height / 2;

            // Create the Label
            this.lblBot = this.Bot.CreateBot();

            // Debug.WriteLine(this.lblBot.Font);

            boundryBox.Controls.Add(this.lblBot);

            ShowCoordinates();
        }

        private void ShowCoordinates()
        {
            lblCoordinates.Text = "X: " + this.Bot.X + ", " + "Y: " + this.Bot.Y;
        }
        private void btnGo1_Click(object sender, EventArgs e)
        {
            this.Bot.Pos(this.lblBot, 1);
            ShowCoordinates();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            this.lblBot.Text = Bot.Direction(1);
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            this.lblBot.Text = Bot.Direction(0);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            this.lblBot.Text = Bot.Direction(2);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            this.lblBot.Text = Bot.Direction(3);
        }

        private void btnGo10_Click(object sender, EventArgs e)
        {
            this.Bot.Pos(this.lblBot, 10);
            ShowCoordinates();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
