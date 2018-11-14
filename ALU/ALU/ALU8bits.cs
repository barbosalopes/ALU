using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class ALU8bits {

        private ALU1bit[] alu8;

        public ALU8bits()
        {
            alu8 = new ALU1bit[8];
            for(int i = 0; i < 8; i++)
            {
                alu8[i] = new ALU1bit();
            }
        }

        public bool[] Run(bool[]a, bool[]b,bool f0, bool f1, bool f2, bool CarryIn, out bool CarryOut)
        {
            bool ci = CarryIn; 
            bool[] output = new bool[8];
            for(int i= a.Length-1; i >= 0; i--)
            {
                output[i] = alu8[i].Run(a[i], b[i], f0, f1, f2, ci, out CarryOut);
                ci = CarryOut;   
            }
            CarryOut = ci;
            return output;
        }
    }
}
