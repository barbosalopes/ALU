using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU
{
    class ALU32bits
    {
        protected ALU1bit A1 = new ALU1bit(); // Bit de sinal
        protected ALU8bits A8 = new ALU8bits(); // Expoente polarizado
        protected ALU23bits A23 = new ALU23bits(); // Mantissa fracionária 

        /*		
                 OPCODES
                F0	Saída
                0	A + B
                1	A - B
        */

        public ALU32bits()
        {

        }

        public bool Run(bool F0)
        {
            
            return false;
        }
    }
}
