using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Sala
    {
        public bool[,] _sala = new bool[9,8];

        public Sala() 
        {
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 8; j++) 
                {
                    _sala[i, j] = false;
                }
            }
        }
    }
}
