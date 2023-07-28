using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.Interface_Segregation.Wrong_Example {
    public interface IAuthService {

        void login();
        void logout();
    }
}
