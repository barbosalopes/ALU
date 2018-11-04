using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class Or8 {
		bool M0, M1;
		Or4 P0 = new Or4();
		Or4 P1 = new Or4();
		Or P2 = new Or();
		public bool Ativa(bool A, bool B, bool C, bool D, bool E, bool F, bool G, bool H) {
			M0 = P0.Ativa(A, B, C, D);
			M1 = P1.Ativa(E, F, G, H);
			return (P2.Ativa(M0, M1));
		}
	}
}
