using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeMB
{

    public static class Press
    {
        public static Hashtable _keys = new Hashtable();

        public static void wcisnijPusc(Keys key, bool i)
        {
            _keys[key] = i;
        }

        public static bool Button(Keys key)
        {
            if(_keys[key] == null)
             _keys[key] = false;
                return (bool)_keys[key];
            
        }
    }
}
