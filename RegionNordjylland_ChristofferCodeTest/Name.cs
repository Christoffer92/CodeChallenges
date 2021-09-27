using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachChallenge {

    public class Name {

        public Name(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}