using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Arrow_Bot
{
    public partial class frmBot : Form
    {
        public frmBot()
        {
            InitializeComponent();
        }

        private void frmBot_Load(object sender, EventArgs e)
        {
            char arrow;
            arrow = Convert.ToChar(231);
            lblArrow.Text = arrow.ToString();
        }
    }

    public class Bot
    {
        private int coordinateX;
        private int coordinateY;

        private int mapFacing;

    }
}
