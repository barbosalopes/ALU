using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU
{
    class ALU23bits
    {
        ALU1bit[] ALU = new ALU1bit[23];
        Or8 PO = new Or8();

        public bool[] Run(bool[] a, bool[] b, bool F0, bool F1, bool F2, bool CarryIn, out bool carryOut)
        {
            bool cai = CarryIn;
            bool[] boleano = new bool[23];

            for (int i = 0; i < a.Length; i++)
            {
                boleano[i] = ALU[i].Run(a[i], b[i], F0, F1, F2, cai, out carryOut);
                cai = carryOut;
            }
            carryOut = cai;
            return boleano;
        }
    }
}
