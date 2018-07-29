using System;
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
        public frmBot()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        

        private void frmBot_Load(object sender, EventArgs e)
        {
            // Get properties from Robot Class
            Robot Bot = new Robot();

            Bot.Boundry = 100;

            Bot.X = 15;
            Bot.Y = 15;

            GroupBox boundryBox = Bot.AddBoundryBox(this.Width, this.Height);

            char[] arrow = Bot.CreateArrow();

            Label lblBot = Bot.CreateBot();

            Debug.WriteLine(lblBot.Font);
            lblBot.Text = arrow[2].ToString();

            // Add controls.
            this.Controls.Add(boundryBox);

            boundryBox.Controls.Add(lblBot);

            

            
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {

        }
    }
}
