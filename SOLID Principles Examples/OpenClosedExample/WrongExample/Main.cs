using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.OpenClosedExample.WrongExample {
    public class Main {

        public void main() {
            ValidationService validate = new();
            validate.Validate("Password");
        }
        
    }
}
