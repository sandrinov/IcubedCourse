using FirstWebApp.Data;
using FirstWebApp.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private DataManager dataManager;

        public EmployeeController()
        {
            dataManager = new DataManager();
        }
        // GET: Employee/AllEmployees
        public ActionResult AllEmployees()
        {
            List<DTO_Employee> model = dataManager.GetAllEmployees();
            return View(model);
        }
    }
}