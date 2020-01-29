using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class TestPerson
    {
        public string firstname;
        public string secondname;

        public string GetFullName()
        {
            return firstname + secondname;
        }
    }
}
