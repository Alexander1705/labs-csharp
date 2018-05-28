using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02
{
    class Worker
    {
        private string fullName;
        private string bossFullName;

        public Worker(string fullName)
        {
            this.fullName = fullName;
        }

        public virtual string Duties()
        {
            return "undefined";
        }

        public virtual void PrintSubordinationTree(int indent = 0)
        {
            for (int i = 0; i < indent; ++i)
            {
                Console.Write('\t');
            }

            Console.WriteLine("{0} ({1})", fullName, Duties());
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string BossFullName { get => bossFullName; set => bossFullName = value; }
    }
}
