using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	class ALU1bit {

		And P0 = new And(); // A & B
		Or P1 = new Or(); // A | B
		Xor P1a = new Xor(); // A xor B 
		Not P2 = new Not(); // ~B	
		And P3 = new And(); // HABILITA AND	
		And P4 = new And(); // HABILITA OR
		And P4a = new And(); // HABILITA XOR
		And P5 = new And(); // HABILITA NOT
		Or8 P7 = new Or8(); // A | B | C | D | E | F | G | H 

		/*		
                 OPCODES
                F2	F1	F0	Saída
                0	0	0	A AND B
                0	0	1	A OR B
                0	1	0	A XOR B
                0	1	1	A'
                1	0	0	B'
                1	0	1	A Plus B 
                1	1	0	A - B
                1	1	1	A = B
        */

		public int Ativa(bool A, bool B, bool[] F, bool Vem1, out bool Vai1) {
			bool D0, D1, D2, M0, M1, M2, M3, M4, M5, S;
			bool D4, M1a, M4a;
			int saida;
			Vai1 = false;  // valor provisorio para retorno da Funcao Aritmetica, substituir depois de implementar o Somador completo
			D0 = false; D1 = false; D2 = false; D4 = false; // valores provisorios na saida decoder 3x8, retirar depois de completar a ALU	 

			if (!F[2] & !F[1] & !F[0]) {// teste provisorio, retirar depois de completar a ALU - Opode F2F1F0 = 000 AND

				return A && B;

				D0 = true;
			}


			if (!F[2] & !F[1] & F[0]) {// teste provisorio, retirar depois de completar a ALU - Opode F2F1F0 = 001 OR

				return A || B;

				D1 = true;
			}
			if (!F[2] & F[1] & !F[0]) { // teste provisorio, retirar depois de completar a ALU - Opode F2F1F0 = 010 XOR 

				return ^ A; 

				D2 = true;
			}
			if (!F[2] & F[1] & F[0]) { // teste provisorio, retirar depois de completar a ALU - Opode F2F1F0 = 011 NOT(A)	

				return !A;
			}

			if (F[2] & !F[1] & !F[0]) {// teste provisorio, retirar depois de completar a ALU - Opode F2F1F0 = 100 NOT(B) 

				return !B;
				D4 = true;
			}

			if (F[2] & !F[1] & F[0]) { // teste provisorio, retirar depois de completar a ALU	
				Console.WriteLine("\nOpode F2F1F0 = 101 nao implementado - Digite qualquer tecla para para voltar ao menu.");
				Console.WriteLine("----------------------------------------------");
				Console.ReadKey();
				saida = -1;
				return saida;
			}

			if (F[2] & F[1] & !F[0]) { // teste provisorio, retirar depois de completar a ALU	
				Console.WriteLine("\nOpode F2F1F0 = 110 nao implementado - Digite qualquer tecla para para voltar ao menu.");
				Console.WriteLine("----------------------------------------------");
				Console.ReadKey();
				saida = -1;
				return saida;
			}

			if (F[2] & F[1] & F[0]) { // teste provisorio, retirar depois de completar a ALU	
				Console.WriteLine("\nOpode F2F1F0 = 111 nao implementado - Digite qualquer tecla para para voltar ao menu.");
				Console.WriteLine("----------------------------------------------");
				Console.ReadKey();
				saida = -1;
				return saida;
			}
			M0 = P0.Ativa(A, B); // Funcao Logica AND(A,B) - F2F1F0 = 000	
			M1 = P1.Ativa(A, B); // Funcao Logica OR(A,B) - F2F1F0 = 001
			M1a = P1a.Ativa(A, B); // Funcao Logica XOR(A,B) - F2F1F0 = 010
			M2 = P2.Ativa(B); // Funcao Logica Not (B)  - F2F1F0 = 100
			M3 = P3.Ativa(M0, D0); // Habilita saida funcao logica AND(A,B) 
			M4 = P4.Ativa(M1, D1); // Habilita saida funcao logica OR(A,B)
			M4a = P4a.Ativa(M1a, D2); // Habilita saida funcao logica XOR(A,B)
			M5 = P5.Ativa(M2, D4); // Habilita saida funcao logica NOT(B) -  Not (B)  - F2F1F0 = 100
			S = P7.Ativa(M3, M4, M4a, false, M5, false, false, false);
			if (S) saida = 1;
			else saida = 0;
			return saida;
		}
	}
}
