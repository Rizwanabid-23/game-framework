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
    public partial class Form1 : Form
    {
        /*                  //could not make form1 singleton because main program class is static.
        private Form1()
        {
        }
        private static Form1 Instance = null;
        public static Form1 getInstance()
        {
            if(Instance==null)
            {
                Instance = new Form1();
            }
            return Instance;
        }
        */

        game g;
        factory f = new factory();
        factoryMovement fm = new factoryMovement();

        public Form1()
        {
            InitializeComponent();
        }
        private void tick(object sender, EventArgs e)
        {
            g.update();
            characterCounter_update();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            g = game.getInstance();
            gameObject obj1 = f.makeGameObject(enemy1, 2, MoveTypes.left, char_types.enemy);
            gameObject obj2 = f.makeGameObject(enemy2, 3, char_types.enemy);
            gameObject obj3 = f.makeGameObject(hero1, 4, MoveTypes.keyboard, char_types.hero);

            gameObject obj4 = f.makeGameObject(hero2, 8, MoveTypes.up, char_types.hero);
            g.addObject(obj1); //sending objects to be stored in array
            g.addObject(obj2);
            g.addObject(obj3);
            g.addObject(obj4);

            f.calculate_charac_types();     //calculte enemies and heroes at this moment
           
        }

        keyBoard keyBoard = new keyBoard();
        private void downPressed(object sender, KeyEventArgs e)
        {           
            keyBoard.kmove(sender, e);
        }

        private void downReleased(object sender, KeyEventArgs e)
        {
            keyBoard.notmove(sender, e);       
        }   

        public void characterCounter_update()
        {            
            characterCounters.Text = "Enemies:" + f.getEnemies() + " Heroes:" +f.getHeroes();
        }
       
    }
}
