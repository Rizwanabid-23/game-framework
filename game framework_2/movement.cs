using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace game_framework_2
{
    interface Imovement
    {
        void move(int speed, PictureBox pic);
        
    }
    
}
