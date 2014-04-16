using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string email;
        public double[] testResult;

        public string display(bool upperCase, bool includeEmail) {
            if (includeEmail)
            {
                if (upperCase)
                {
                    return "Student name is: " + firstName.ToUpper() + " " + lastName.ToUpper() + ", email: " + email + "\n";
                }
                else
                {
                    return "Student name is: " + firstName.ToLower() + lastName.ToLower() + ", email: " + email + "\n";
                }
            }
            else
            {
                if (upperCase)
                {
                    return "Student name is: " + firstName.ToUpper() + " " + lastName.ToUpper() + "\n";
                }
                else
                {
                    return "Student name is: " + firstName.ToLower() + " " + lastName.ToLower() + "\n";
                }
            }
        }
    }
}
