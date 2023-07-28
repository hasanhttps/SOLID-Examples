using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.Liskov_s_Substition.Wrong_Example {
    public class Child : Adult {

        public override void MakeDinner() {
            // It is not correct example because child can'y make dinner or cook. Liskov's Substition says that inherited class must be able to do everything in base class.
        }
    }
}
