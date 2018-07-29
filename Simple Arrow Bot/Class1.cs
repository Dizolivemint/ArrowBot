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

        // Create an arrow for each direction into an array
        public char[] arrow = new char[4];

        private int direction;
        
        public int X { get; set; }

        public int Y { get; set; }

        public string Direction(int direction)
        {
            this.direction = direction;
            return this.arrow[direction].ToString();
        }

        public void CreateArrow()
        {
            for (int i = 0; i < 4; i++)
            {
                this.arrow[i] = Convert.ToChar(231 + i);
                // West, East, North, South
            }

        }

        public Label CreateBot()
        {
            // Create a Label and set the font
            Label lblBot = new Label();
            lblBot.Font = new Font("Wingdings", 12);

            // Create the arrows
            this.CreateArrow();

            // Change direction to North
            lblBot.Text = this.Direction(2);

            this.Pos(lblBot, 0, 0);

            return lblBot;
        }

        public void Pos(Label Bot, int X, int Y)
        {
            if (this.direction == 3)
            {
                X = -X;
            }

            if (this.direction == 4)
            {
                Y = -Y;
            }

            Bot.Location = new Point(this.X + X, this.Y + Y);
        }

    }
}
