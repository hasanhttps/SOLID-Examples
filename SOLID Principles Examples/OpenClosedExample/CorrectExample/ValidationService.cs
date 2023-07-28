using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.OpenClosedExample.CorrectExample {
    public class ValidationService {

        // It is proper way because if we need new validation for new object we don't have to write if else code in old code. We can create class and impelement from IValidationService and give it object to validate function as parametr. 

        public void Validate(IValidationService validation) {
            validation.Validate();
        }
    }
}
