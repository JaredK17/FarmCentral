using System;
using ST10090287_ProgPart2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10090287_ProgPart2.Models
{
    public class Employee
    {
        

        public string EMPLOYEE_ID { get; set; }

        public string EMPLOYEE_NAME { get; set; }

        public string EMPLOYEE_SURNAME { get; set; }

        public string EMPLOYEE_EMAIL { get; set; }
        public string EMPLOYEE_PASSWORD { get; set; }

        public Employee()
        {
        }

        public Employee(string eMPLOYEE_ID, string eMPLOYEE_NAME, string eMPLOYEE_SURNAME, string eMPLOYEE_EMAIL, string eMPLOYEE_PASSWORD)
        {
            EMPLOYEE_ID = eMPLOYEE_ID;
            EMPLOYEE_NAME = eMPLOYEE_NAME;
            EMPLOYEE_SURNAME = eMPLOYEE_SURNAME;
            EMPLOYEE_EMAIL = eMPLOYEE_EMAIL;
            EMPLOYEE_PASSWORD = eMPLOYEE_PASSWORD;
        }

        

     
        }
    }

