using FirstWebApp.Data.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstWebApp.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class DTO_Employee
    {
        private Employee ef_emp;

        public DTO_Employee()
        {

        }
        public DTO_Employee(Employee ef_emp)
        {
            this.ef_emp = ef_emp;
            this.IDEmployee = ef_emp.EmployeeID;
            this.Country = ef_emp.Country;
            this.FirstName = ef_emp.FirstName;
            this.LastName = ef_emp.LastName;
        }

        [DisplayName("ID")]
        public int IDEmployee { get; set; }
        [DisplayName("Nome")]
        public String FirstName { get; set; }
        [DisplayName("Cognome")]
        public String LastName { get; set; }
        [DisplayName("Paese")]
        public String Country { get; set; }
    }
}