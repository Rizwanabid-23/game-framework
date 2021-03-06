using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game_framework_2;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        factory f = new factory();
        game_framework_2.game g;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = game_framework_2.game.getInstance();
            gameObject obj1 = f.makeGameObject(enemy01, 3,new keyBoard() ,char_types.enemy);
            gameObject obj2 = f.makeGameObject(player01, 4, f.keyboard(), char_types.hero);

            
            g.addObject(obj1);
            g.addObject(obj2);

            f.calculate_charac_types();
        }

        private void tick(object sender, EventArgs e)
        {
            g.update();
            updateChracters();
        }

        keyBoard k = new keyBoard();
        private void keyDown(object sender, KeyEventArgs e)
        {
            k.kmove(sender, e);
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            k.notmove(sender, e);
        }
        private void updateChracters()
        {
            charactersUpdate.Text = "Enemies: " + f.getEnemies() + "  Player: " + f.getHeroes();
        }
    }
}
