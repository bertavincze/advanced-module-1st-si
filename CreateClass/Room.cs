using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room
    {
        int number;

        public Room(int number)
        {
            this.number = number;
        }

        public int getNumber()
        {
            return number;
        }
    }
}
