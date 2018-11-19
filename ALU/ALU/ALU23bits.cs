using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU
{
    public class ALU23bits
    {
        ALU1bit[] ALU = new ALU1bit[23];

        public ALU23bits()
        {
            ALU = new ALU1bit[23];
            for (int i = 0; i < 23; i++)
            {
                ALU[i] = new ALU1bit();
            }
        }

        public bool[] Run(bool[] a, bool[] b, bool F0, bool F1, bool F2, bool CarryIn, out bool carryOut)
        {
            bool[] opCode = { F0, F1, F2 };
            bool[] opCodeToMakeComplementOfTwo = { true, false, true };
            if (opCode.SequenceEqual(opCodeToMakeComplementOfTwo)){
                b = Conversor.ConvertBoolToNegativeBool(b);
            }

            bool ci = CarryIn;
            bool[] output = new bool[23];
            for (int i = 0; i < a.Length; i++)
            {
                output[i] = ALU[i].Run(a[i], b[i], F0, F1, F2, ci, out carryOut);
                ci = carryOut;
            }
            carryOut = ci;
            return output;
        }
    }
}
