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
    public class game
    {
 
        public static ArrayList stored = new ArrayList();
        ArrayList collosion_list = new ArrayList();
        gameObject g = new gameObject();
        private game()
        {
        }
        private static game Instance=null;
        public static game getInstance()
        {
            if(Instance==null)
            {
                Instance = new game();
            }
            return Instance;
        }
        public void addObject(gameObject objs)
        {
            stored.Add(objs);
        }
        public void addCollosion(CollosionDetection cd)
        {
            collosion_list.Add(cd);
        }

        public void update()
        {           
            foreach(gameObject go in stored)
            {
                g.fall(go);
            }
        }   
        public void impact()
        {
            foreach(CollosionDetection c in collosion_list)
            {
                c.collosionUpdate(stored);
            }
        }
    }
}
