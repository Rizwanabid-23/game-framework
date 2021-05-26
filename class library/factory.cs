using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_framework_2
{
    public class factory
    {
        
        int enemyCount, heroCount;
        ArrayList character_array = new ArrayList();

        public gameObject makeGameObject(PictureBox pic,int speed, Imovement move,char_types types)
        {
            
            gameObject gameObject=new gameObject(pic,speed,move,types);
            character_array.Add(types);
            
            return gameObject;
        }
      
        public gameObject makeGameObject(PictureBox pic,int speed,char_types types)
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
            foreach(char_types t in character_array)
            {
                
                if(char_types.enemy==t)
                {
                    enemyCount++;
                }
                if(char_types.hero==t)
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
