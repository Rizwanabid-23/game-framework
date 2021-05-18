using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace game_framework
{
    class game
    {
        int speed;
        public static ArrayList stored = new ArrayList();
        public game(int move_speed)
        {
            this.speed = move_speed;
        }
        public void addObject(gameObject objs)
        {
            stored.Add(objs);
        }
        public void update()
        {
            gameObject g = new gameObject();
            for(int i=0;i<stored.Count;i++)
            {
                gameObject obj = (gameObject)stored[i];
                PictureBox box= obj.return_picturebox();
                g.fall(speed,box);

            }
        }
    }
}
