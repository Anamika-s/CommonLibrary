using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary
{
    public class Employee
    {
        public string GetLeaves(int exp)
        {
            if (exp > 10)
                return "You will get 20 days";
            else if (exp >= 5 && exp <= 10)
                return "You will get 15 days";
            else
                return "You will get 10 days";

            
        }
    }
}
