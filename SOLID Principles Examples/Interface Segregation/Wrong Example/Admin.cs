using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles_Examples.Interface_Segregation.Wrong_Example;

namespace SOLID_Principles_Examples.Interface_Segregation.Wrong_Example {

    // It is wrong example because admin have to override logout but don't need logout. We can seperate IAuthLoginService and IAuthLogoutService it is interface segregation. 

    public class Admin : IAuthService {
        public void login() {

        }

        public void logout() {
            throw new NotImplementedException();
        }
    }
}
