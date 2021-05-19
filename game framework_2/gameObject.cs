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
    class gameObject
    {
        PictureBox box;
        int speed;
        movement move;
        public gameObject(PictureBox pic,int speed,movement movement)
        {
            pic.BackColor = Color.Red;
            pic.Visible = true;

            this.box = pic;
            this.speed = speed;
            this.move = movement;
        }
        public gameObject()
        {

        }

        public PictureBox return_picturebox()
        {
            return this.box;
        }
        public int return_speed()
        {
            return this.speed;
        }
        public movement return_move()
        {
            return this.move;
        }
        public void fall(gameObject go)
        {
            PictureBox pic;
            int speed;
            movement move;

            pic = go.return_picturebox();
            speed = go.return_speed();
            move = go.return_move();
            move.move(speed, pic);
        }
    
    }
}
