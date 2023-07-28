using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.OpenClosedExample.WrongExample {
    public class ValidationService {

        // It is wrong format because when you add new property you need to change old code and it is not proper by OpenClosed Principle. You can add something but you can't change code.

        public void Validate(string name) {
            if (name == "Password") {

            }
            else if (name == "Username") {

            }
            else {

            }
        }

    }
}
