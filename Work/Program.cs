using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        Menager menager = new Menager(new WareHouse());
        List<Workers> employes = new List<Workers> {
            new EmployPz(),
            new EmployPR(),
            new EmployPNZ()
        };
    }

  
}
