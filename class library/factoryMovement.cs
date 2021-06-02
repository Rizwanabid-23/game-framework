using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace game_framework_2
{
    class factoryMovement
    {

        ArrayList free = new ArrayList();
        ArrayList occupied = new ArrayList();
        public Imovement getMovement(MoveTypes type)
        {
            Imovement movement = checkType(type);
            if(movement!=null)
            {
                free.Add(movement);
                occupied.Remove(movement);
            }
            else
            {
                Imovement m;
                    if (type==MoveTypes.left)
                    {
                    m = new moveleft();
                    occupied.Add(m);
                    return m;
                    }
                    else if (type==MoveTypes.right)
                    {
                    m = new moveright();
                    occupied.Add(m);
                    return m;
                    }
                    else if (type==MoveTypes.down)
                    {
                    m = new movedown();
                    occupied.Add(m);
                    return m;
                    }
                    else if (type==MoveTypes.up)
                    {
                    m = new moveup();
                    occupied.Add(m);
                    return m;
                    }
                    else if(type== MoveTypes.keyboard)
                {
                    m = new keyBoard();
                    occupied.Add(m);
                    return m;
                }
            }
            return null;
        }
        public Imovement checkType(MoveTypes types)
        {
            foreach(Imovement i in free)
            {
                if(i.getMoveType()==types)
                {
                    return i;
                }
            }
            return null;
        }
        public void release(Imovement type)
        {
            occupied.Remove(type);
            free.Add(type);
        }
    }
    
}
