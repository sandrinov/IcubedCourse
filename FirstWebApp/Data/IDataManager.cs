using FirstWebApp.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Data
{
    public interface IDataManager
    {
        List<DTO_Employee> GetAllEmployees();
        DTO_Employee GetEmployeeByID(int id);

    }
}