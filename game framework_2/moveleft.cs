using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_framework_2
{
    class moveleft:movement
    {
        public override void move(int speed, PictureBox pic)
        {
            pic.Left = pic.Left - speed;
        }
    }
}
