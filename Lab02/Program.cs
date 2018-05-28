using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager ceo = new Manager("CEO");
            SeniorDeveloper cto1 = new SeniorDeveloper("CTO1");
            SeniorDeveloper cto2 = new SeniorDeveloper("CTO2");
            JuniorDeveloper jd1 = new JuniorDeveloper("JD1");
            JuniorDeveloper jd2 = new JuniorDeveloper("JD2");
            JuniorDeveloper jd3 = new JuniorDeveloper("JD3");
            JuniorDeveloper jd4 = new JuniorDeveloper("JD4");

            ceo.Subordinates.Add(cto1);
            ceo.Subordinates.Add(cto2);

            cto1.Subordinates.Add(jd1);
            cto1.Subordinates.Add(jd2);
            cto2.Subordinates.Add(jd3);
            cto2.Subordinates.Add(jd4);

            ceo.PrintSubordinationTree();
            Console.ReadKey();
        }
    }
}

