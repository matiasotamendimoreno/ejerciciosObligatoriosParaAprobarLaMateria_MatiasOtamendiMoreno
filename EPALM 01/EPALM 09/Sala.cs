using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPALM_09
{
    internal class Sala
    {
        public bool[,] _lugares = new bool[9,8];

        public Sala() 
        {
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 8; j++) 
                {
                    _lugares[i, j] = false;
                }
            }
        }
    }
}
