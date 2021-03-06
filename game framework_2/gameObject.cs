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
        Imovement move;
        public gameObject(PictureBox pic,int speed,Imovement movement)
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

        public gameObject(PictureBox pic,int speed)
        {
            pic.BackColor = Color.Black;
            this.box = pic;
            this.speed = speed;
            this.box.Left = this.box.Left - this.speed;
        }

        public void fall(gameObject go)
        {
            PictureBox pic;
            int speed;
            Imovement move;

            pic = go.box;
            speed = go.speed;
            if(go.move!=null)
            {
                move = go.move;
                move.move(speed, pic);
            }
            else
            {
                moveleft left = new moveleft();
                left.move(speed, pic);
            }
            
        }
    
    }
}
