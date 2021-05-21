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
        game g;
        factory f = new factory();

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
            gameObject obj1 = factory.makeGameObject(enemy1, 2,f.left(),Char_types.enemy);
            gameObject obj2 = factory.makeGameObject(enemy2, 3,Char_types.enemy);
            gameObject obj3 = factory.makeGameObject(enemy3, 4, f.keyboard(),Char_types.hero);

            g.addObject(obj1); //sending objects to be stored in array
            g.addObject(obj2);
            g.addObject(obj3);
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

        public enum Char_types
        {
            hero,enemy,
        }
    }
}
