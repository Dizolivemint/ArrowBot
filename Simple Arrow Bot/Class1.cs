using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Arrow_Bot
{
    public class Robot
    {
        private int coordinateX;
        private int coordinateY;

        public int boundry;

        public int Boundry { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public void AddBot(int X, int Y)
        {
            this.coordinateX = X;
            this.coordinateY = Y;

        }

        // Add a GroupBox to a form and set some of its common properties.
        public GroupBox AddBoundryBox(int formWidth, int formHeight)
        {
            // Create a GroupBox and add a TextBox to it.
            GroupBox boundryBox = new GroupBox();
            // groupBox1.Controls.Add(textBox1);
            
            boundryBox.Location = new Point((formWidth - Boundry) / 2, (formHeight - Boundry) / 2);
            boundryBox.Height = Boundry;
            boundryBox.Width = Boundry;

            return boundryBox;
        }

        public char[] CreateArrow()
        {
            // Create an arrow for each direction into an array
            char[] arrow = new char[4];
            for (int i = 0; i < 4; i++)
            {
                arrow[i] = Convert.ToChar(231 + i);
                // West, East, North, South
            }

            return arrow;
        }

        public Label CreateBot()
        {
            // Create a Label and set the font
            Label lblBot = new Label();
            lblBot.Font = new Font("Wingdings", 12);

            lblBot.Location = new Point(0, 0);
            return lblBot;
        }

    }
}
