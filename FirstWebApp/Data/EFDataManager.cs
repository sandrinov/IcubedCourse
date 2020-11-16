using FirstWebApp.Data.DTO;
using FirstWebApp.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Data
{
    public class EFDataManager : IDataManager
    {
        NorthwindEntities ctx;
        public EFDataManager()
        {
            ctx = new NorthwindEntities();
        }
        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> lst = new List<DTO_Employee>();
            var res = from e in ctx.Employees
                      orderby e.LastName
                      select e;

            foreach (Data.EF.Employee ef_emp in res)
            {
                DTO_Employee dto = new DTO_Employee(ef_emp);
                lst.Add(dto);
            }
            return lst;
        }

        public DTO_Employee GetEmployeeByID(int id)
        {
            DTO_Employee res = null;
            var querylinq = from e in ctx.Employees
                            where e.EmployeeID == id
                            select e;

            Data.EF.Employee ef_emp = querylinq.FirstOrDefault();
            if (ef_emp != null)
            {
                res = new DTO_Employee(ef_emp); 
            }
            return res;
        }
    }
}