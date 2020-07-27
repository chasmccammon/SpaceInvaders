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
        
        
        public void spawn()
        {
           
        }

        public void moveleft(Form form1,PictureBox player)
        {
            
            int test = player.Location.X;
            if(test > 0)
            {
                player.Location = new System.Drawing.Point(test -= 20, player.Location.Y);

            }
            //pictureBox1.Location = new System.Drawing.Point(50, 50);


        }

        public void moveright(Form form1,PictureBox player)
        {
            int test = player.Location.X ;

            if (test + 95 < 1584)
            {
                player.Location = new System.Drawing.Point(test += 20, player.Location.Y);

            }
        }

        public void fire()
        {

        }

        public void die()
        {

        }
    }
}
