using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Arrow_Bot
{
    public class Robot
    {

        // Create an arrow for each direction into an array
        public char[] arrow = new char[4];

        private int direction;

        public int startX { get; set; }
        public int startY { get; set; }
        
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

            this.X = this.startX;
            this.Y = this.startY;

            this.Pos(lblBot, 0);

            return lblBot;
        }

        public void Pos(Label Bot, int units)
        {
            int Y = 0;
            int X = 0;
            int multi = 1;
            int boundry;

            // Go negative if East or North
            if (this.direction == 0 || this.direction == 2)
            {
                units = 0 - units;
                multi = -1;
            }

            // Change Y Value if North or South
            if (this.direction == 2 || this.direction == 3)
            {
                Y = units;
                boundry = this.startY + 100 * multi;
            } else
            {
                X = units;
                boundry = this.startX + 100 * multi;
            }


            Debug.WriteLine("Y:", (this.Y).ToString());
            Debug.WriteLine("Boundry:", boundry.ToString());
            Debug.WriteLine("X:", (this.X).ToString());

            if (multi > 0)
            {
                if (this.X + X > boundry || this.Y + Y > boundry)
                {


                    Debug.WriteLine("X:", X);
                    Debug.WriteLine("Y:", Y);

                    Debug.WriteLine("Multiplier: " + multi);
                    Debug.WriteLine("Units: " + units);

                    MessageBox.Show("Cannot go past 100 units", "Boundry limit reached");
                    return;
                }
            } else 
            {
               if (this.X + X < 0 || this.Y + Y < 0)
                {
                    MessageBox.Show("Cannot go less than 0 units", "Boundry limit reached");
                    return;
                }
            }
            

            this.X += X;
            this.Y += Y;

            Bot.Location = new Point(this.X, this.Y);
        }

    }
}
