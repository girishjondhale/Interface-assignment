using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interf
{
    public class Employee
    {
        int id;
        string name;
        double basicsal, hra, ta, pf, gs, totalsal;

        public Employee(int id, string name, double basicsal)
        {
            this.id = id;
            this.name = name;
            this.basicsal = basicsal;
        }
        public void Calculatesal()
        {
            hra = basicsal * 40 / 100;
            ta = basicsal * 20 / 100;
            pf = basicsal * 12 / 100;
            totalsal = basicsal + hra + ta + pf;
            gs = (basicsal + hra + ta) - pf;
        }

        public string ToString()
        {
            return ($"grosssalary={gs}\nempid={id}\nempname={name}\nbasicsal={basicsal}");
        }
    }
}
