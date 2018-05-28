using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Manager : Worker
    {
        private List<Worker> subordinates;

        public Manager(string fullName) : base(fullName)
        {
            subordinates = new List<Worker>();
        }

        internal List<Worker> Subordinates { get => subordinates; set => subordinates = value; }

        public override string Duties()
        {
            return "managing other people";
        }

        public override void PrintSubordinationTree(int indent = 0)
        {
            base.PrintSubordinationTree(indent);

            foreach (Worker worker in subordinates)
            {
                worker.PrintSubordinationTree(indent + 1);
            }
        }
    }
}
