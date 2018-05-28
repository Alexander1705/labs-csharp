using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class SeniorDeveloper : Manager
    {
        public SeniorDeveloper(string fullName) : base(fullName) { }

        public override string Duties()
        {
            return "engineering & managing junior developers";
        }
    }
}
