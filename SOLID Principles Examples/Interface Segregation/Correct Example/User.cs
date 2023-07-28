using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.Interface_Segregation.Correct_Example {
    public class User : IAuthLoginService, IAuthLogoutService {
        public void login() {

        }

        public void Logout() {

        }
    }
}
