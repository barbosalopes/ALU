using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	public class LogicalUnit {
         And3 P0 = new And3();
         And P1 = new And();
         Or P2 = new Or();
         Not P4 = new Not();

         public bool[] Run(bool a, bool b, bool[] decoderOutput)
         {
            bool[] arraydevolta = new bool[4];

            arraydevolta[0] = P0.Ativa(decoderOutput[0], a, b);
            arraydevolta[1] = P1.Ativa(P2.Ativa(a, b), decoderOutput[1]);
            arraydevolta[2] = P1.Ativa(decoderOutput[2], P4.Ativa(a));
            arraydevolta[3] = P1.Ativa(decoderOutput[3], P4.Ativa(!b));

            return arraydevolta;
         }
	}
}
