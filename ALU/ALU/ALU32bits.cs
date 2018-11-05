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
                F3	Saída
                0	A + B
                1	A - B
        */

        public ALU32bits()
        {

        }

        public bool Run(bool[] A, bool[] B, bool F0, bool carryIn, out bool carryOut)
        {
            bool M0;
            bool[] M1 = new bool[23];
            bool[] M2 = new bool[8];

            // Início bit de sinal

            M0 = A1.Run(A[0], B[0], true, false, F0, carryIn, out carryOut); 
            
            // Fim bit de sinal

            // Início mantissa fracionária

            bool[] IA23 = new bool[23];
            bool[] IB23 = new bool[23];

            for (int i = 0, aux = 1; i < 24; i++, aux++)
            {
                IA23[i] = A[aux];
                IB23[i] = B[aux];
            }

            M1 = A23.Run(IA23, IB23, true, false, F0, carryIn, out carryOut); 
            
            // Fim mantissa fracionária

            // Início expoente polarizado

            bool[] IA8 = new bool[8];
            bool[] IB8 = new bool[8];

            for (int i = 0, aux = 25; i < 8; i++, aux++)
            {
                IA8[i] = A[aux];
                IB8[i] = B[aux];
            }

            M2 = A8.Run(IA8, IB8, true, false, F0, carryIn, out carryOut); 
            
            // Fim expoente polarizado

            return false;
        }
    }
}
