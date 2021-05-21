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
    class game
    {
 
        public static ArrayList stored = new ArrayList();
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
        public void update()
        {
            gameObject g = new gameObject();
            foreach(gameObject go in stored)
            {
                g.fall(go);
            }
        }       
    }
}
