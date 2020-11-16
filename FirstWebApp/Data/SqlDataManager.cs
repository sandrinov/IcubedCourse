using FirstWebApp.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;

namespace FirstWebApp.Data
{
    public class SqlDataManager : IDataManager
    {
        private string connectionString;
        private SqlConnection conn;
        public SqlDataManager(String connstring)
        {
            
            this.connectionString = connstring;
            conn = new SqlConnection(connectionString);
        }

        public SqlDataManager()
        {
            string connstring = WebConfigurationManager.ConnectionStrings["northwindconnstring"].ConnectionString;
            this.connectionString = connstring;
            conn = new SqlConnection(connectionString);
        }

        public List<DTO_Employee> GetAllEmployees()
        {
            List<DTO_Employee> lst = new List<DTO_Employee>();
            String commandText = "Select * From Employees";
            SqlCommand cmd = new SqlCommand(commandText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int id = Int32.Parse(dr["EmployeeID"].ToString());
                string firstName = dr["FirstName"].ToString();
                string lastName = dr["LastName"].ToString();
                string country = dr["Country"].ToString();

                DTO_Employee newDto = new DTO_Employee() { 
                 IDEmployee = id,
                 FirstName = firstName,
                 LastName = lastName,
                 Country = country
                };

                lst.Add(newDto);

            }
            conn.Close();
            return lst;
        }

        public DTO_Employee GetEmployeeByID(int id)
        {
            DTO_Employee result = new DTO_Employee();
            String commandText = "Select * From Employees where EmployeeID = " + id;
            SqlCommand cmd = new SqlCommand(commandText, conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                string firstName = dr["FirstName"].ToString();
                string lastName = dr["LastName"].ToString();
                string country = dr["Country"].ToString();

                DTO_Employee newDto = new DTO_Employee()
                {
                    IDEmployee = id,
                    FirstName = firstName,
                    LastName = lastName,
                    Country = country
                };

                result = newDto;

            }
            conn.Close();
            return result;
        }
    }
}