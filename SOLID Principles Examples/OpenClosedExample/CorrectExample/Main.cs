using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.OpenClosedExample.CorrectExample {
    public class Main {

        public void main() {
            ValidationService validationService = new ValidationService();
            Password password = new Password();
            validationService.Validate(password);
            Username username = new Username();
            validationService.Validate(username);
        }
    }
}
