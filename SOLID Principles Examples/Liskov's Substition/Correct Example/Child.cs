using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples.Liskov_s_Substition.Correct_Example {
    public class Child : Person {

        // It is correct form because child can do everything on the base class

        public override void Breate() {

        }

        public override void Eat() {

        }

        public override void Drink() {

        }

    }
}
