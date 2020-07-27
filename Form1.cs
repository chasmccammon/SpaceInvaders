using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        Player player = new Player();
        public Form1()
        {
            
            InitializeComponent();

            this.KeyPress += form1_KeyPress;

        }
        public PictureBox getplayer
        {
            get { return this.pictureBox1; }
            
        }

        private void form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar) 
            {
                case 'a':
                    player.moveleft(this,pictureBox1);
                    break;
                case 'd':
                    player.moveright(this, pictureBox1);
                    break;
              

            }






        }

       

        }
    }

