using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_framework_2
{
    class factory
    {
        
        int enemyCount, heroCount;
        ArrayList character_array = new ArrayList();

        public gameObject makeGameObject(PictureBox pic,int speed, Imovement move,Form1.Char_types types)
        {
            
            gameObject gameObject=new gameObject(pic,speed,move,types);
            character_array.Add(types);
            
            return gameObject;
        }
      
        public gameObject makeGameObject(PictureBox pic,int speed,Form1.Char_types types)
        {
            character_array.Add(types);
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
        public void calculate_charac_types()
        {
            foreach(Form1.Char_types t in character_array)
            {
                
                if(Form1.Char_types.enemy==t)
                {
                    enemyCount++;
                }
                if(Form1.Char_types.hero==t)
                {
                    heroCount++;
                }
            }
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
