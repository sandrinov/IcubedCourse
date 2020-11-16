using FirstWebApp.Data;
using FirstWebApp.Data.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IDataManager dataManager;

        public EmployeeController(IDataManager dm)
        {
            //dataManager = new SqlDataManager();
            //dataManager = FactoryDataManager.GetDataManager();
            dataManager = dm;
        }
        // GET: Employee/AllEmployees
        public ActionResult AllEmployees()
        {
            List<DTO_Employee> model = dataManager.GetAllEmployees();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            DTO_Employee model = dataManager.GetEmployeeByID(id);
            return View(model);
        }
    }
}