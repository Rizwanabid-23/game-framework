using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;


namespace game_framework_2
{
    class keyBoard:Imovement
    {
        
        static bool up=false, down=false, right=false, left=false;
        public void move(int speed, PictureBox pic)
        {
            if(left==true)
            {
                pic.Left = pic.Left - speed;
            }
            if(right==true)
            {
                pic.Left = pic.Left + speed;
            }
            if(up==true)
            {
                pic.Top = pic.Top - speed;
            }
            if(down==true)
            {
                pic.Top = pic.Top + speed;
            }
        }
        
        public void kmove(object sender,KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode==Keys.Right)
            {
                right = true;
            }
            if(e.KeyCode==Keys.Up)
            {
                up = true;
            }
            if(e.KeyCode==Keys.Down)
            {
                down = true;
            }
        }
        public void notmove(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
        }
    }
}
