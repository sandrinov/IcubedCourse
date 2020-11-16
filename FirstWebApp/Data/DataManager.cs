using FirstWebApp.Data.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace FirstWebApp.Data
{
    public class DataManager
    {
        private string connectionString;
        private SqlConnection conn;

        public DataManager()
        {
            this.connectionString = "Data Source=DESKTOP-N5TF96M;Initial Catalog=Northwind;Integrated Security=True";
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
    }
}