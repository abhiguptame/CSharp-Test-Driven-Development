using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Utils
    {
        public virtual int GetEmployeeTypeValue(string type)
        {
            int employeeTypeValue = 1;

            switch (type)
            {
                case "Permanent":
                    employeeTypeValue = 1;
                    break;

                case "Contract":
                    employeeTypeValue = 0;
                    break;

                default:
                    break;
            }

            return employeeTypeValue;
        }
    }
}
