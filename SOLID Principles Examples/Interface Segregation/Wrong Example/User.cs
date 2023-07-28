using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.Interface_Segregation.Wrong_Example {
    public class User : IAuthService {
        public void login() {

        }

        public void logout() {

        }
    }
}
