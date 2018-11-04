using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {

	public class Xor { // XOR = ~AB + A~B
		And P0 = new And();
		And P1 = new And();
		Or P2 = new Or();
		Not P3 = new Not();
		Not P4 = new Not();

		public bool Ativa(bool A, bool B) {
			bool M0, M1;
			M0 = P1.Ativa(P3.Ativa(A), B);
			M1 = P1.Ativa(A, P4.Ativa(B));
			return (P2.Ativa(M0, M1));
		}
	}
}
