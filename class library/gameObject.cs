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
    public class gameObject
    {
        PictureBox box;
        int speed;
        Imovement move;
        char_types types;
        internal gameObject(PictureBox pic,int speed,Imovement movement,char_types types)
        {
            this.box = pic;
            this.speed = speed;
            this.move = movement;
            this.types = types;
        }

        public gameObject()
        {
        }

        internal gameObject(PictureBox pic,int speed,char_types types)
        {
            pic.BackColor = Color.Black;
            this.box = pic;
            this.types = types;
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
            types = go.types;
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
