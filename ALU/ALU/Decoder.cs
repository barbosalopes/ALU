using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class Decoder {

        protected Not P0 = new Not();
        protected Not P1 = new Not();
        protected Not P2 = new Not();
        protected And3 P3 = new And3();
        protected And3 P4 = new And3();
        protected And3 P5 = new And3();
        protected And3 P6 = new And3();
        protected And3 P7 = new And3();
        protected And3 P8 = new And3();
        protected And3 P9 = new And3();
        protected And3 P10 = new And3();

        public bool[] Run (bool A, bool B, bool C)
        {
            bool D0, D1, D2, D3, D4, D5, D6, D7;

            D0 = P3.Ativa(P0.Ativa(A), P1.Ativa(B), P2.Ativa(C)); // 000
            D1 = P4.Ativa(P0.Ativa(A), P1.Ativa(B), C); // 001
            D2 = P5.Ativa(P0.Ativa(A), B, P2.Ativa(C)); // 010
            D3 = P6.Ativa(P0.Ativa(A), B, C); // 011
            D4 = P7.Ativa(A, P1.Ativa(B), P2.Ativa(C)); // 100
            D5 = P8.Ativa(A, P1.Ativa(B), C); // 101
            D6 = P9.Ativa(A, B, P2.Ativa(C)); // 110
            D7 = P10.Ativa(A, B, C); // 111

            bool[] array = new bool[8];
            array[0] = D0;
            array[1] = D1;
            array[2] = D2;
            array[3] = D3;
            array[4] = D4;
            array[5] = D5;
            array[6] = D6;
            array[7] = D7;

            return array;
        }
    }
}
