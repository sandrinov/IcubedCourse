using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Data.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class DTO_Employee
    {
        public int IDEmployee { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Country { get; set; }
    }
}