using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace game_framework_2
{
    public partial class Form1 : Form
    {
        game g;

        public Form1()
        {
            InitializeComponent();
        }

        private void tick(object sender, EventArgs e)
        {
            g.update();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            g = game.getInstance();
            gameObject obj1 = new gameObject(enemy1,2,new moveleft()); //sending name of pictureBox,speed and movement type
            gameObject obj2 = new gameObject(enemy2,3,new moveup());
            gameObject obj3 = new gameObject(enemy3, 4, new movedown());

            g.addObject(obj1); //sending objects to be stored in array
            g.addObject(obj2);
            g.addObject(obj3);
        }
    }
}
