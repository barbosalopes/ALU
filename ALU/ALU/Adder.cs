using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class Adder {

        /*
        protected Xor P0 = new Xor();
        protected Xor P1 = new Xor();
        protected Xor P2 = new Xor();
        protected And P3 = new And();
        protected And P4 = new And();
        protected Or P5 = new Or();
        protected Or P6 = new Or();
        protected And P7 = new And();*/

        //https://www.embarcados.com.br/wp-content/uploads/2015/11/adder-5.png
        protected Xor P1 = new Xor();
        protected Xor P2 = new Xor();
        protected And P3 = new And();
        protected And P4 = new And();
        protected Or P5 = new Or();

        //To define if the value should be passed 
        protected And P6 = new And();
        protected And P7 = new And();
        protected Or P8 = new Or();

        public bool Run(bool A, bool B, bool[] decoderOutput, bool carryIn, out bool carryOut)
        {
            bool res, sum, subtraction;
            bool R1 = P1.Ativa(A, B);
            res = P2.Ativa(carryIn, R1);

            bool R2 = P3.Ativa(A, B);
            bool R3 = P4.Ativa(carryIn, R1);
            carryOut = P5.Ativa(R2, R3);

            sum = P6.Ativa(res, decoderOutput[0]);
            subtraction = P7.Ativa(res, decoderOutput[1]);

            return P8.Ativa(sum, subtraction);
        }
        /*

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
        */
    }
}
