using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    class Player
    {
        private int X;
        private int Y;
        public Player(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public PictureBox spawn()
        {
            PictureBox ship = new PictureBox();
            ship.Image = global::SpaceInvaders.Properties.Resources.pngkit_space_ship_png_328881;
            ship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ship.BackColor = System.Drawing.Color.Transparent;
            ship.Location = new System.Drawing.Point(X, Y);
            ship.Name = "player";
            ship.Size = new System.Drawing.Size(150, 150);
            ship.TabIndex = 0;
            ship.TabStop = false;
            return ship;
        }

        public void moveleft()
        {

        }

        public void moveright()
        {

        }

        public void fire()
        {

        }

        public void die()
        {

        }
    }
}
