using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Player player = new Player(500, 800);
            PictureBox box = new PictureBox();
            box = player.spawn();
            this.Controls.Add(box); 
            InitializeComponent();
            box.ClientSizeChanged(300,300);
            
        }
    }
}
