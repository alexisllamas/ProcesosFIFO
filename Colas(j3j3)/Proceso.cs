using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_j3j3_
{
    class Proceso
    {
        static private Random ran = new Random();
        private short ciclos;

        public short Ciclos
        {
            get { return ciclos; }
            set { ciclos = value; }
        }

        public Proceso()
        {
            ciclos = (short)ran.Next(4, 13);
        }
    }
}
