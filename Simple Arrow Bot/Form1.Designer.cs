﻿namespace Simple_Arrow_Bot
{
    partial class frmBot
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
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnGo10 = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.boundryBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(33, 846);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(132, 80);
            this.btnGo1.TabIndex = 0;
            this.btnGo1.Text = "Go 1";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnGo10
            // 
            this.btnGo10.Location = new System.Drawing.Point(484, 846);
            this.btnGo10.Name = "btnGo10";
            this.btnGo10.Size = new System.Drawing.Size(133, 80);
            this.btnGo10.TabIndex = 1;
            this.btnGo10.Text = "Go 10";
            this.btnGo10.UseVisualStyleBackColor = true;
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(291, 742);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(53, 60);
            this.btnNorth.TabIndex = 2;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(291, 866);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(53, 60);
            this.btnSouth.TabIndex = 3;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(229, 805);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(53, 60);
            this.btnWest.TabIndex = 4;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(354, 805);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(53, 60);
            this.btnEast.TabIndex = 5;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // boundryBox
            // 
            this.boundryBox.Location = new System.Drawing.Point(33, 26);
            this.boundryBox.Name = "boundryBox";
            this.boundryBox.Size = new System.Drawing.Size(600, 600);
            this.boundryBox.TabIndex = 6;
            this.boundryBox.TabStop = false;
            // 
            // frmBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 968);
            this.Controls.Add(this.boundryBox);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnGo10);
            this.Controls.Add(this.btnGo1);
            this.Name = "frmBot";
            this.Text = "Simple Arrow Bot";
            this.Load += new System.EventHandler(this.frmBot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnGo10;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.GroupBox boundryBox;
    }
}

