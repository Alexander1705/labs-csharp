using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class JuniorDeveloper : Worker
    {
        public JuniorDeveloper(string fullName) : base(fullName) { }

        public override string Duties()
        {
            return "engineering";
        }
    }
}
