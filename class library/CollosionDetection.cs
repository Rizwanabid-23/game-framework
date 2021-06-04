using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace game_framework_2
{
    public class CollosionDetection
    {
        char_types p1;
        char_types p2;
        game g = game.getInstance();
        Iaction action;
        public CollosionDetection(char_types first,char_types second,Iaction action)
        {
            this.action = action;

            this.p1 = first;
            this.p2 = second;
        }
        private bool check_detection(PictureBox first,PictureBox second)
        {
            if(first.Bounds.IntersectsWith(second.Bounds))
            {
                return true;
            }
            return false;
        }
        public void collosionUpdate(ArrayList games_char_list)
        {
            PictureBox picBox1;
            PictureBox picBox2;
            foreach (gameObject one in games_char_list)
            {
                if(one.types==p1)
                {
                    picBox1 = one.box;
                    foreach(gameObject second in games_char_list)
                    {
                        if(second.types==p2)
                        {
                            picBox2 = second.box;
                            bool alpha= check_detection(picBox1, picBox2);
                            if(alpha==true)
                            {
                                action.impact();
                            }
                        }
                    }
                }


            }
        }
        
    }
}
