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
        protected And P7 = new And();

        public bool Run(bool A, bool B, bool[] decoderOutput, bool carryIn, out bool carryOut)
        {
            bool M0, M1, M2, M3, M4, M5, M6, SUM, D0, D1, D3;

            D0 = decoderOutput[0];
            D1 = decoderOutput[1];

            D3 = P7.Ativa(D0, !D1);

            M0 = P0.Ativa(A, B); // A XOR B
            M1 = P1.Ativa(M0, carryIn); // M0 XOR carryIn
            M2 = P2.Ativa(!D3, A); // decoderOutput XOR A
            M3 = P3.Ativa(carryIn, B); // carryIn AND B
            M4 = P5.Ativa(B, !D3); // B OR decoderOutput
            M5 = P4.Ativa(M2, M4); // M2 AND M4
            M6 = P6.Ativa(M3, M5); // M3 OR M5

            SUM = M1;
            carryOut = M6;

            return SUM;
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
