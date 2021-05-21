using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_framework_2
{
    class factory
    {
        static int enemyCount, heroCount;
        // Form1 form1=new Form1();
        
        
        public static gameObject makeGameObject(PictureBox pic,int speed, Imovement move,Form1.Char_types types)
        {
            gameObject gameObject=new gameObject(pic,speed,move,types);
            if(types==Form1.Char_types.enemy)
            {
                enemyCount++;
            }
            if(types==Form1.Char_types.hero)
            {
                heroCount++;
            }
            return gameObject;
        }
        public static gameObject makeGameObject()
        {
            gameObject gameObject = new gameObject();
            return gameObject;
        }
        public static gameObject makeGameObject(PictureBox pic,int speed,Form1.Char_types types)
        {
            if(types==Form1.Char_types.enemy)
            {
                enemyCount++;
            }
            if(types==Form1.Char_types.hero)
            {
                heroCount++;
            }
            gameObject gameObject = new gameObject(pic, speed,types);
            return gameObject;
        }

        public Imovement left()
        {
            
            return new moveleft();
        }
        public Imovement right()
        {
            
            return new moveright();
        }
        public Imovement up()
        {
            
            return new moveup();
        }
        public Imovement down()
        {
            
            return new movedown();
        }
        public Imovement keyboard()
        {
            
            return new keyBoard();
        }
        
        public int getHeroes()
        {
            return heroCount;
        }
        public int getEnemies()
        {
            return enemyCount;
        }
    }
}
