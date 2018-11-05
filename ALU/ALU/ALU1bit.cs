using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	class ALU1bit {

        protected LogicalUnit LU = new LogicalUnit();
        protected Decoder DE = new Decoder();
        protected Adder AD = new Adder();

        protected Or4 P0 = new Or4();
        protected Or P1 = new Or();

		public bool Run(bool A, bool B, bool F0, bool F1, bool F2, bool carryIn, out bool carryOut) {

            bool M0, Output;

            bool[] RDE = new bool[8];
            RDE = DE.Run(F0, F1, F2);

            bool[] RLU = new bool[4];
            bool[] ILU = new bool[4];
            ILU[0] = RDE[0];
            ILU[1] = RDE[1];
            ILU[2] = RDE[2];
            ILU[3] = RDE[3];
            RLU = LU.Run(A, B, ILU);

            bool RAD;
            bool[] IAD = new bool[2];
            IAD[0] = RDE[4];
            IAD[1] = RDE[5];
            RAD = AD.Run(A, B, IAD, carryIn, out carryOut);

            M0 = P0.Ativa(RLU[0], RLU[1], RLU[2], RLU[3]);
            Output = P1.Ativa(RAD, M0);

            return Output;
		}
	}
}
