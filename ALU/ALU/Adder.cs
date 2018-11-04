using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	class Adder {

        protected Xor P0 = new Xor();
        protected Xor P1 = new Xor();
        protected Xor P2 = new Xor();
        protected And P3 = new And();
        protected And P4 = new And();
        protected Or P5 = new Or();
        protected Or P6 = new Or();

        public bool[] Run(bool A, bool B, out bool carryOut, out bool[] decoderOutput)
        {



            bool[] array = new bool[10];
        }

        public bool Ativa(bool A, bool B, bool Vem1, out bool Vai1)
        {

            bool M0, M1, M2, SOMA;
            M0 = P0.Ativa(A, B);
            M1 = P3.Ativa(A, B);
            M2 = P1.Ativa(M1, Vem1);
            Vai1 = P2.Ativa(M0, M2);
            SOMA = P4.Ativa(M1, Vem1);
            return (SOMA);
        }
    }
}
