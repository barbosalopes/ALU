using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU {
	class LogicalUnit {
        And P0 = new And();
        And P1 = new And();
        Or P2 = new Or();
        And P3 = new And(); 
        Not P4 = new Not();
        And P5 = new And();
        Not P6 = new Not();
        And P7 = new And();

         public bool[] Run(bool a, bool b, bool[] decoderOutput)
         {
            bool[] arradevolta = new bool[4];
            arradevolta[0] = decoderOutput[0] && a && b;
            arradevolta[1] = decoderOutput[1] && a || b;
            arradevolta[2] = decoderOutput[2] && !a;
            arradevolta[3] = decoderOutput[3] && !b;
            return arradevolta;
         }
	}
}
