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
        factoryMovement fm = new factoryMovement();

        public gameObject makeGameObject(PictureBox pic,int speed, MoveTypes move,char_types types)
        {          
            gameObject gameObject=new gameObject(pic,speed,fm.getMovement(move),types);
            character_array.Add(types);
            
            return gameObject;
        }
      
        public gameObject makeGameObject(PictureBox pic,int speed,char_types types)
        {
            character_array.Add(types);
            gameObject gameObject = new gameObject(pic, speed,types);            
            return gameObject;
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
