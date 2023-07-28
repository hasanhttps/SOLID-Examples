using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles_Examples {
    public class StringCollection {

        public List<string> strings = new();

        // WRONG Example

        //public void AddString(string? str) {

        //    bool checkExist = false;

        //    // CheckNotNull

        //    if (str == null)
        //        throw new ArgumentNullException(nameof(str));

        //    // CheckExist

        //    foreach(var item in strings) {
        //        if (item == str)
        //            checkExist = true;
        //    }

        //    // Add

        //    if (!checkExist)
        //        strings.Add(str);


        //}

        // Correct Example

        public void AddString(string? str) {

            // CheckNotNull

            if (str == null)
                throw new ArgumentNullException(nameof(str));

            // Check Add

            CheckandAdd(str);

        }

        // Functions Must be written in other classes

        public bool Check(string str) {
            foreach(var item in strings) {
                if (item == str)
                    return true;
            }
            return false;
        }

        public void CheckandAdd(string str) {
            if (!Check(str))
                strings.Add(str);
        }
    }
}
