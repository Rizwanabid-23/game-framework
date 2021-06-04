using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_framework_2
{
    class decreaseHP:Iaction
    {
        ProgressBar pbar;
        int decrease;
        public decreaseHP(ProgressBar bar,int decrease)
        {
            this.pbar = bar;
            this.decrease = decrease;
        }
        public void impact()
        {
            
            if(pbar.Value>0)
            {
                this.pbar.Value -= decrease;
            }
        }
    }
}
